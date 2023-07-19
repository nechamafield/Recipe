-- SM Excellent work! 100%
use heartyhearthdb 
go 

drop table if EXISTS cookbookrecipe
drop table if exists cookbook
drop TABLE if EXISTS coursemealrecipe
drop TABLE if EXISTS coursemeal
drop table if exists meal
drop table if EXISTS course
drop table if exists directionrecipe
drop table if exists ingredientrecipe
drop table if exists measurement
drop table if exists Recipe
drop table if exists cousine
drop table if exists Users
drop table if EXISTS ingredient

create table dbo.Ingredient(
    ingredientid INT not null IDENTITY PRIMARY KEY,
    ingredientname varchar(30)  not null
        CONSTRAINT c_IngredientName_cannot_be_Blank CHECK (ingredientname <> '')
        CONSTRAINT u_Ingredient_IngredientName UNIQUE,
    ingredientpicturename as concat('Ingredient-', replace(ingredientname, ' ', '_'), '.jpg') persisted
)

CREATE TABLE dbo.Users(
    UserId int not null IDENTITY PRIMARY KEY,
    UserFirstName VARCHAR(30) not null
        CONSTRAINT c_UserFirstName_cannot_be_Blank CHECK (userfirstname <> ''),
    UserLastName VARCHAR(30) not null
        CONSTRAINT c_UserLastName_cannot_be_Blank CHECK (userlastname <> ''),
    Username VARCHAR(30) not NULL
        CONSTRAINT c_UserName_cannot_be_Blank CHECK (username <> '')
        CONSTRAINT u_Users_UserName UNIQUE 
        
)

create table dbo.Cousine(
    Cousineid int not null IDENTITy PRIMARY KEY, 
    CousineType VARCHAR(30) not null 
        CONSTRAINT c_CousinetType_cannot_be_blank CHECK(cousinetype <> '')
        CONSTRAINT u_Cousine_CousineType UNIQUE
)

create table dbo.Recipe(
    Recipeid int not null IDENTITY PRIMARY KEY,
    Userid int not null CONSTRAINT f_Users_Userid FOREIGN KEY REFERENCES users(UserId),
    cousineid int not null CONSTRAINT f_cousine_cousineid FOREIGN KEY REFERENCES cousine(cousineid),
    RecipeName VARCHAR(30) not NULL
        CONSTRAINT c_RecipeName_cannot_be_Blank CHECK (Recipename <> '')
        CONSTRAINT u_Recipe_RecipeName UNIQUE,
    Calories int not null
        constraint c_Calories_must_be_greater_than_0 CHECK(calories > 0),
    DateDrafted DATEtime not NULL DEFAULT GETDATE()
        CONSTRAINT c_DateDrafted_cannot_be_in_future CHECK(DateDrafted <= GETDATE()),
    DatePublished datetime 
        CONSTRAINT c_DatePublished_cannot_be_in_future CHECK(Datepublished <= GETDATE()),
    DateArchived DATETIME 
        CONSTRAINT c_DateArchived_cannot_be_in_future CHECK(datearchived <= GETDATE()),
    RecipeStatus as case  
                        when datepublished is not null and datearchived is null then 'Published'
                        when datearchived is not null then 'archived'
                        else 'Draft'
                    end,
    RecipePictureName as concat('Recipe-', replace(recipename, ' ', '_'), '.jpg') persisted
)

create table dbo.Measurement(
    Measurementid int not null IDENTITY PRIMARY KEY,
    Measurementname VARCHAR(30) not NULL
        CONSTRAINT c_MeasurementName_cannot_be_blank CHECK(Measurementname <> '')
       CONSTRAINT u_Measurement_Measurementname UNIQUE
)

create table dbo.IngredientRecipe(
    IngredientRecipeid int not null IDENTITY PRIMARY KEY,
    Ingredientid int not null CONSTRAINT f_IngredientRecipe_Ingredient FOREIGN KEY REFERENCES ingredient(ingredientid),
    Recipeid int not null CONSTRAINT f_IngredientRecipe_Recipe FOREIGN KEY REFERENCES recipe(Recipeid),
    Measurementid int null CONSTRAINT f_IngredientRecipe_Measurement FOREIGN KEY REFERENCES measurement(measurementid), 
    Amount decimal(3,2) not null CONSTRAINT c_Amount_must_be_greater_than_0 CHECK(amount > 0),
    IngredientSequence int not null CONSTRAINT c_IngredientSequence_must_be_greater_than_0 CHECK(IngredientSequence > 0),
        CONSTRAINT u_IngredientRecipe_Ingredientid_Recipeid UNIQUE(ingredientid, Recipeid),
        CONSTRAINT u_IngredientRecipe_IngredientSequence_Recipeid UNIQUE(IngredientSequence, Recipeid)
)

create table dbo.DirectionRecipe(
    DirectionRecipeid int not null IDENTITY PRIMARY KEY,
    Recipeid int not null CONSTRAINT f_DirectionRecipe_Recipe foreign KEY REFERENCES recipe(Recipeid),
    StepNumber int not null 
        CONSTRAINT c_StepNumber_must_be_greater_than_0 CHECK(stepnumber > 0),
    Direction varchar(200) 
        CONSTRAINT c_Direction_cannot_be_blank CHECK (direction <> ''),
        CONSTRAINT u_DirectionRecipe_StepNumber_Recipeid unique (stepnumber, recipeid),
        CONSTRAINT u_DirectionRecipe_Recipeid_Direction unique (Recipeid, direction)
)

create table dbo.Course(
    Courseid int not null IDENTITY PRIMARY KEY,
    CourseType VARCHAR(30) not null 
        CONSTRAINT c_CourseType_cannot_be_blank CHECK (coursetype <> '')
        CONSTRAINT u_Course_CourseType UNIQUE,
    CourseSequence int 
        CONSTRAINT c_CourseType_must_be_greater_than_0 CHECK (coursesequence > 0)
        CONSTRAINT u_Course_CourseSequence UNIQUE
)

create table dbo.Meal(
    Mealid int not null IDENTITY PRIMARY KEY,
    userid int not null CONSTRAINT f_Meal_Userid FOREIGN KEY REFERENCES users(Userid),
    MealName VARCHAR(30)
        CONSTRAINT c_Meal_Name_cannot_be_Blank CHECK (mealname <> '')
        CONSTRAINT u_Meal_MealName UNIQUE,
    DateCreated date not null DEFAULT GETDATE(),
    IsActive bit not NULL DEFAULT 1, 
    MealPictureName as concat('Meal-', replace(mealname, ' ', '_'), '.jpg') persisted
)

create table dbo.CourseMeal(
    CourseMealid int not null IDENTITY PRIMARY KEY,
    Courseid int not null CONSTRAINT f_CourseMeal_Course FOREIGN KEY REFERENCES course(courseid),
    Mealid int not null CONSTRAINT f_CourseMeal_Meal FOREIGN KEY REFERENCES Meal(Mealid), 
        CONSTRAINT u_CourseMeal_Courseid_Mealid unique(courseid, mealid)
)

create table dbo.CourseMealRecipe(
    CourseMealRecipeid int not null IDENTITY PRIMARY KEY,
    CourseMealid int not null CONSTRAINT f_CourseMealRecipe_CourseMeal FOREIGN KEY REFERENCES coursemeal(coursemealid),
    Recipeid int not null CONSTRAINT f_CourseMealRecipe_Recipe FOREIGN KEY REFERENCES recipe(Recipeid),
    IsMain bit not null,
        CONSTRAINT u_CourseMealRecipe_CourseMealid_Recipeid UNIQUE(coursemealid, recipeid)
)

create table dbo.CookBook(
    Cookbookid int not null IDENTITY PRIMARY KEY,
    userid int not null CONSTRAINT f_Cookbook_Userid FOREIGN KEY REFERENCES users(Userid),
    CookbookName varchar(50) not null
        CONSTRAINT c_CookbookName_cannot_be_blank CHECK (cookbookname <> '')
        CONSTRAINT u_Cookbook_CookBookName UNIQUE,
    Price decimal(7,2) not null
        CONSTRAINT c_Price_cannot_be_negative CHECK (price > 0),
    DateCreated date not null DEFAULT GETDATE(),
    IsActive bit not null Default 1,
    CookbookPictureName as concat('Cookbook-', replace(cookbookname, ' ', '_'), '.jpg') persisted
)

create TABLE dbo.CookBookRecipe(
    CookBookRecipeid  int not null IDENTITY PRIMARY KEY,
    Cookbookid int not null CONSTRAINT f_Cookbookrecipe_Cookbookid FOREIGN KEY REFERENCES cookbook(cookbookid),
    Recipeid int not null CONSTRAINT f_Cookbookrecipe_Recipeid FOREIGN KEY REFERENCES recipe(recipeid),
    RecipeSequence int not null 
        CONSTRAINT c_Recipe_Sequence_cannot_be_0 CHECK (recipesequence > 0),
        CONSTRAINT u_CookbookRecipe_Recipeid_Cookbookid UNIQUE(recipeid, cookbookid),
        CONSTRAINT u_CookbookRecipe_RecipeSequence_Cookbook unique(recipesequence, cookbookid)
)
