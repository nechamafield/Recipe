-- SM Excellent! 100% See comments, no need to resubmit
use heartyhearthdb 
go 


--Home Page:  One resultset with number of recipes, meals, and cookbooks

SELECT NumRecipes = count(distinct r.Recipename), NumMeals = count(DISTINCT m.Mealid), numCookbooks = count(distinct cb.Cookbookid)
from Recipe r
cross join Meal m
cross join CookBook cb 


--Recipe list page:
    --List of all Recipes that are either published or archived, published recipes should appear at the top. 
    --Archived recipes should appear gray. Surround the archived recipe with <span style="color:gray">recipe name</span>
    --In the resultset show the Recipe with its status, dates it was published and archived (blank if not archived), user, number of calories and number of ingredient
    

select RecipeName = 
    case r.RecipeStatus  
        when 'archived' then CONCAT('<span style="color:gray">', r.RecipeName, '</span>')
        else r.RecipeStatus
    end, 
    r.RecipeStatus, r.datepublished, DateArchived = isnull(convert(varchar(20),r.datearchived), ''), u.username, r.calories, NumIngredients = COUNT(ir.ingredientid)
from recipe r 
join users u 
on r.usersid = u.Usersid
join IngredientRecipe ir 
on ir.Recipeid = r.Recipeid
where r.RecipeStatus in ('published', 'archived')
group by r.RecipeName, r.RecipeStatus, r.datepublished, DateArchived, u.username, r.calories
order by r.RecipeStatus desc 


--Recipe details page:
    --Show for a specific recipe (three result sets):
        --a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
        --b) List of ingredients: show the measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
        --c) List of prep steps sorted by sequence.
SELECT r.RecipeName, r.calories, NumIngredience = count(distinct Ingredientid), NumSteps = COUNT(distinct dr.StepNumber), r.RecipePictureName 
from Recipe r 
join ingredientrecipe ir 
on ir.recipeid = r.Recipeid
join directionrecipe dr 
on r.Recipeid = dr.recipeid 
where r.RecipeName = 'chocolate chip cookies'
group by r.RecipeName, r.calories,  r.RecipePictureName 

SELECT distinct MeasuredIngredient = concat(ir.Amount, ' ', m.Measurementname, ' ', i.ingredientname), ir.ingredientsequence, r.RecipePictureName
from Recipe r 
join IngredientRecipe ir 
on ir.Recipeid = r.Recipeid
join Ingredient i 
on i.ingredientid = ir.Ingredientid
join Measurement m 
on m.Measurementid = ir.Measurementid
where r.RecipeName = 'chocolate chip cookies'
order by ir.ingredientsequence

select dr.StepNumber, dr.Direction, r.RecipePictureName
from DirectionRecipe dr 
join Recipe r 
on r.Recipeid = dr.Recipeid
where r.RecipeName = 'chocolate chip cookies'
order by dr.StepNumber

--Meal list page:
    --All active meals, meal name, user that created meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal

SELECT m.MealName, u.username, SumCalories = isnull(sum(r.Calories), 0), NumCourses = count(c.CourseType), NumRecipes = COUNT(r.RecipeName)
from meal m 
join users u 
on u.Usersid = m.Usersid
join CourseMeal cm 
on cm.Mealid = m.Mealid
join coursemealrecipe cmr 
on cmr.coursemealid = m.mealid
join recipe r 
on r.Recipeid = cmr. recipeid 
join course c 
on c.Courseid = cm.Courseid
where m.IsActive = 1
group by m.MealName, u.username
order by m.MealName


--Meal details page:
    --Show for a specific meal:
        --a) Meal header: meal name, user, date created.
        --b) List of all recipes. 
            --Display in one column the course type, recipe, and for the main course show which dish is the main and which are side. 
			--In this format "Course Type: Main\Side dish - Recipe Name. Then main dishes should be bold, using the bold tags as shown below
                --ex: 
                    --Appetizer: Mixed Greens
                    --<b>Main: Main dish - Onion Pastrami Chicken</b>
					--Main: Side dish - Roasted cucumbers with mustard
SELECT m.MealName, u.Username, m.datecreated, m.MealPictureName
from meal m 
join users u 
on m.usersid = u.Usersid
where m.MealName = 'Lunch'

---- SM You're checking on coursetype = 'main' twice. Consider doing that nested. And instead of checking case when column, do case column when.

SELECT c.CourseType, r.RecipeName, cmr.IsMain, 
        MealDetails = concat(c.CourseType, ': ', case 
                                                    when c.coursetype = 'main' and cmr.IsMain = 1 then concat('<b>','Main Dish - ',r.RecipeName, '</b>')
                                                    when c.CourseType = 'main' and cmr.IsMain = 0 then concat('Side Dish - ',r.RecipeName)
                                                    else r.RecipeName
                                                 end), m.MealPictureName
from Meal m 
join CourseMeal cm 
on cm.Mealid = m.Mealid
join Course c 
on c.Courseid = cm.Courseid
join CourseMealRecipe cmr 
on cmr.CourseMealid = cm.CourseMealid
join Recipe r 
on r.Recipeid = cmr.Recipeid
where m.MealName = 'lunch'


--Cookbook list page:
    --Show all active cookbooks with author and number of recipes per book. Sorted by book name.

SELECT cb.CookbookName, u.UserFirstName, u.UserLastName, RecipesPerBook = COUNT(cbr.Recipeid)
from CookBook cb 
join Users u 
on u.UsersId = cb.usersid
join CookBookRecipe cbr 
on cbr.Cookbookid = cb.Cookbookid
where cb.isactive = 1
GROUP by cb.CookbookName, u.UserFirstName, u.UserLastName
order by cb.CookbookName


--Cookbook details page:
    --Show for specific cookbook:
    --a) Cookbook header: cookbook name, user, date created, price, number of recipes.
    --b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  Note: User will click on recipe to see all ingredients and steps.
SELECT cb.CookbookName, u.Username, cb.datecreated, cb.Price, NumRecipes = COUNT(cbr.Recipeid), cb.CookbookPictureName
from CookBook cb 
join Users u 
on cb.usersid = u.UsersId
join CookBookRecipe cbr 
on cbr.Cookbookid = cb.Cookbookid
where cb.CookbookName = 'treats for two'
group by cb.CookbookName, u.Username, cb.datecreated, cb.Price, cb.CookbookPictureName

SELECT r.RecipeName, c.CousineType, NumIngredients = count(distinct ir.Ingredientid), NumSteps = count(distinct dr.StepNumber)
from CookBookRecipe cbr 
join CookBook cb 
on cb.Cookbookid = cbr.Cookbookid
join Recipe r 
on r.Recipeid = cbr.Recipeid
join Cousine c 
on c.Cousineid = r.cousineid
join IngredientRecipe ir 
on r.Recipeid = ir.Recipeid
join DirectionRecipe dr 
on dr.Recipeid = r.Recipeid
where cb.CookbookName = 'treats for two'
group by r.RecipeName, c.CousineType, cbr.RecipeSequence
order by cbr.recipesequence


--April Fools Page:
    --On April 1st we have a page with a joke cookbook. For that page provide the following.
    --a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name proper cased. There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
    --b) When the user clicks on a specific recipe they should see a list of the first ingredient of each recipe in the system, and a list of the last step in each recipe in the system

---- SM Now you dont need "where" anymore.
SELECT distinct ReversedRecipe = concat((upper(substring(reverse(r.RecipeName), 1,1))), SUBSTRING(lower(reverse(r.RecipeName)), 2,LEN(r.recipename))), 
       NewPicture = replace((CONCAT('Recipe-', reverse(concat(upper(substring(r.RecipeName, 1,1)), SUBSTRING(lower(r.RecipeName), 2,LEN(r.recipename)))), '.jpg')), ' ', '_')
from Recipe r 
join CookBookRecipe cbr 
on cbr.Recipeid = r.Recipeid


;
with x as(
    SELECT MaxStepNum = MAX(dr.StepNumber), dr.Recipeid
    from DirectionRecipe dr 
    group by dr.Recipeid
)

SELECT r.RecipeName, ListofFirstIngredient =  i.ingredientname, ListofLastStep = dr.Direction
from x 
left join DirectionRecipe dr 
on x.Recipeid = dr.Recipeid
left join IngredientRecipe ir 
on ir.Recipeid = x.Recipeid
left join Ingredient i 
on i.ingredientid = ir.Ingredientid
cross join Recipe r 
where ir.IngredientSequence = 1
and r.RecipeName = 'chocolate chip cookies'
and x.MaxStepNum = dr.StepNumber


--For site administration page:
----5 seperate reports
    --a) List of how many recipes each user created per status. Show 0 if none
	--b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
    --c) List of how many meals each user created and whether they're active or inactive. Show 0 if none
    --d) List of how many cookbooks each user created and whether they're active or inactive. Show 0 if none
    --e) List of archived recipes that were never published, and how long it took for them to be archived.

SELECT NumRecipes = count(r.RecipeName), u.Username, r.RecipeStatus
from Users u 
left join Recipe r 
on r.Usersid = u.UsersId
group by u.Username, r.RecipeStatus
order by u.Username

SELECT NumRecipesPerUser = COUNT(r.RecipeName), AvgDays = isnull(AVG(DATEDIFF(day, r.DateDrafted, r.DatePublished)),0), u.Username
from Users u 
left join Recipe r 
on r.Usersid = u.UsersId
group by u.Username

select u.username, NumMealsPerUser = COUNT(m.MealName), 
        MealStatus = case 
                        when m.IsActive = 1 then 'active'
                        when m.IsActive = 0 then 'inactive'
                        else 'N/A'
                    end
from Users u 
left join meal m  
on m.usersid = u.UsersId
group by u.Username, m.IsActive

select u.username, numCookbooks = COUNT(cb.CookbookName), 
        CookBookStatus = case 
                        when cb.IsActive = 1 then 'active'
                        when cb.IsActive = 0 then 'inactive'
                        else 'N/A'
                    end
from CookBook cb
join Users u 
on cb.usersid = u.UsersId
group by u.Username, cb.IsActive


select r.RecipeName, TimeUntilArchived = DATEDIFF(day, r.DateDrafted, r.DateArchived)
from Recipe r 
where r.DatePublished is null 
and r.RecipeStatus = 'archived'

--For user dashboard page:
    --a) Show number of the user's recipes, meals and cookbooks. 
    --b) List of their recipes, display the status and the number of hours between the status it's in and the one before that. Show null if recipe has the status drafted.
    --c) Count of their recipes per cuisine. Show 0 for none.

SELECT u.username, NumRecipes = count(r.RecipeName), NumMeals = COUNT(m.MealName), NumCookBooks = COUNT(cb.CookbookName)
from Recipe r 
join Users u 
on r.Usersid = u.UsersId
left join meal m 
on m.usersid = u.UsersId
left join CookBook cb 
on u.UsersId = cb.usersid
group by u.Username

select 
    u.Username, 
    r.RecipeName, 
    r.RecipeStatus, 
    NumHours = case 
        when r.RecipeStatus <> 'draft' then 
            datediff(
                hour, 
                case 
                    when r.DatePublished is not null and r.DateArchived is not null then r.DatePublished
                    else r.DateDrafted
                end, 
                case 
                    when r.DateArchived is not null then r.DateArchived
                    else r.DatePublished
                end
            )
    end
from users u 
join Recipe r 
on r.Usersid = u.UsersId
order by u.Username

select u.Username, c.cousinetype, NumRecipesPerCuisine = count(r.RecipeName)
from users u 
join Recipe r 
on r.Usersid = u.UsersId
join Cousine c 
on r.cousineid = c.Cousineid
group by u.Username, c.cousinetype