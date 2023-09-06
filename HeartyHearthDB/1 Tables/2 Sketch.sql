
/*
ingredient
    ingredientid
    ingredientname varchar(30) - not null not blank, unique
    ingredientpicturename as default ('ingredient'-ingredientname.jpg)
user
    userid
    userfirstname varchar(30) - not blank
    userlastname varchar(30) - not blank
    username varchar(30) - not blank, unique
        unique - firstname, lastname, username
Cousine
    cousineid
    cousinetype varchar(30) - not blank
recipe 
    recipeid
    status as case getdate() = 
                            when < datepublished then 'draft'
                            when > datepublished and < datearchived then 'published'
                            else 'archived'
                            end
    userid
    cousineid
    recipename varchar(30) - not blank, unique
    recipepicturename as (recipe-recipename.jpg)
    datedrafted datetime -not null
    datepublished datetime -  (can be null)
    datearchived datetime -  (can be null)
measurement
    measurementid
    measuremetname varchar(30) not blank, unique
ingredientrecipe
    ingredientrecipeid
    ingredientid
    recipeid
    measurementid
    amount int - not 0
        unique ingredientid, recipeid
directionrecipe (1 to many with recipe)
    directionrecipeid
    direction
    recipeid
    stepnumber int
        unique - stepnumber, direction
        unique - direction, recipeid
course
    courseid
    coursetype varchar(30)- not blank, unique
    coursesequence num - not 0
        unique - coursetype, coursesequence
meal
    mealid
    userid
    mealname varchar(30) - not blank, unique
    mealpicutename as (meal-mealname.jpg)
    mealstatus bit 
        unique - mealname, mealstatus
coursemeal
    coursemealid
    courseid
    mealid
        unique - courseid, mealid
coursemealrecipe
    coursemealrecipeid
    coursemealid
    recipeid
    ismain bit 
        unique - recipeid, ismain 
cookbook
    cookbookid
    userid
    cookbookname varchar(50) - not blank, unique
    cookbookpicturename as (cookbooktype-cookbookname.jpg)
    price decimal - not blank
    cookbookstatus bit
        unique - cookbookname, price, cookbookstatus 
cookbookrecipe
    cookbookrecipeid
    cookbookid
    recipeid
    recipesequence num - not 0
        unique - recipeid, cookbookid

*/