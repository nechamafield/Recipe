-- SM Excellent! 100%
use HeartyHearthDB
go 

--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.

delete cbr
--SELECT *
from CookBookRecipe cbr 
join CookBook cb
on  cbr.Cookbookid = cb.Cookbookid 
join Users u 
on u.UserId = cb.userid
WHERE u.Username = 'rv3561%'

delete cb 
--SELECT *
from CookBook cb 
join Users u 
on u.UserId = cb.userid
WHERE u.Username = 'rv3561%'

delete cmr
--SELECT *
from CourseMealRecipe cmr 
join CourseMeal cm 
on cm.CourseMealid = cmr.CourseMealid
join Meal m 
on m.Mealid = cm.Mealid
join Users u 
on u.UserId = m.userid
where u.Username = 'rv3561%'

delete cm 
--select *
from CourseMeal cm 
join Meal m 
on m.Mealid = cm.Mealid
join Users u 
on u.UserId = m.userid
where u.Username = 'rv3561%'

DELETE m
--SELECT *
from Meal m 
join Users u 
on u.UserId = m.userid
where u.Username = 'rv3561%'

DELETE cbr 
--SELECT *
from CookbookRecipe cbr 
join Recipe r 
on cbr.Recipeid = r.Recipeid
join Users u 
on u.Userid = r.Userid
where u.Username = 'rv3561%'

DELETE cmr 
--SELECT *
from CourseMealRecipe cmr 
join Recipe r 
on cmr.Recipeid = r.Recipeid
join Users u 
on u.Userid = r.Userid
where u.Username = 'rv3561%'

delete dr 
--SELECT *
from DirectionRecipe dr 
join Recipe r 
on dr.Recipeid = r.Recipeid
join Users u 
on u.Userid = r.Userid
where u.Username = 'rv3561%'

delete ir
--SELECT *
from IngredientRecipe ir  
join Recipe r 
on ir.Recipeid = r.Recipeid
join Users u 
on u.Userid = r.Userid
where u.Username = 'rv3561%'

delete r 
--SELECT *
from Recipe r 
join Users u 
on u.Userid = r.Userid
where u.Username = 'rv3561%'

delete u 
--SELECT *
from Users u 
where u.Username = 'rv3561%'


--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name.
select ClonedRecipeName = concat(r.RecipeName, ' - clone'), i.ingredientname, dr.StepNumber, dr.Direction
from Recipe r 
join DirectionRecipe dr 
on dr.Recipeid = r.Recipeid 
join IngredientRecipe ir 
on ir.Recipeid = r.Recipeid
join Ingredient i 
on i.ingredientid = ir.Ingredientid
where r.RecipeName = 'chocolate chip cookies'
order by i.ingredientname, dr.StepNumber

/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name.

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
*/

;
with x as(
    SELECT r.RecipeName, u.UserFirstName, u.UserLastName, u.UserId, r.RecipePictureName
    from Recipe r 
    join Users u 
    on u.UserId = r.Userid
    where u.Username = 'rv3561%'
)
insert CookBook(userid, CookbookName, Price, IsActive)
SELECT x.userid, CONCAT('Recipes by ', x.UserFirstName, ' ', x.UserLastName ), COUNT(x.RecipeName) * 1.33, 1 --x.RecipeName, i.ingredientname, dr.StepNumber, dr.Direction, Sequences = ROW_NUMBER() over (order by x.recipename)
from x 
join Recipe r 
on x.RecipeName = r.RecipeName 
group by x.Userid, x.UserFirstName, x.UserLastName


;
with x as (
    SELECT cb.Cookbookid, cb.CookbookName, r.Recipeid, r.RecipeName
    from CookBook cb 
    join Users u 
    on cb.Userid = u.UserId
    join Recipe r 
    on r.userid = u.userid
    where cb.CookbookName LIKE 'Recipes by%'
)

insert CookBookRecipe(Cookbookid, Recipeid, RecipeSequence)
select x.Cookbookid, x.Recipeid, ROW_NUMBER() over (order by x.recipename)
from x 

/*
4) Sometimes the calorie count of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count for butter went down by 2 per ounce, and 10 per stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/
---- SM Excellent refactoring. 
;
with x as (
    SELECT r.recipename, SumPriceForoz = SUM(r.Calories) - 2, SumPriceForStick  = SUM(r.Calories) - 10
    from Recipe r 
    group by r.RecipeName
)

update r 
set r.Calories =  case  
        when i.ingredientname = 'butter' and m.Measurementname = 'oz' then  x.SumPriceForoz
        when i.ingredientname = 'butter' and m.Measurementname = 'stick' then x.SumPriceForStick
        else r.Calories
    end
--SELECT r.RecipeName, i.ingredientname, ir.Amount, m.Measurementname, r.Calories, NewCalorieCount = 
--    case  
--        when i.ingredientname = 'butter' and m.Measurementname = 'oz' then x.SumPrice - 2
--        when i.ingredientname = 'butter' and m.Measurementname = 'stick' then x.SumPrice - 10
--        else r.Calories
--    end
from x 
join recipe r 
on r.RecipeName = x.RecipeName 
join IngredientRecipe ir 
on r.Recipeid = ir.Recipeid 
join Ingredient i 
on i.ingredientid = ir.Ingredientid
join Measurement m 
on m.Measurementid = ir.Measurementid


select * from Recipe r 

/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
;
with x as(
    SELECT AvgTimeinDraft = AVG(DATEDIFF(hour, r.DateDrafted, r.DatePublished))
    from Recipe r 
)

select u.UserFirstName, u.UserLastName,  
      EmailAddress = concat(SUBSTRING(u.UserFirstName,1,1), u.UserLastName, '@heartyhearth.com'),
      Alert = CONCAT('Your recipe [', r.RecipeName, '] is sitting is draft for ', DATEDIFF(hour, r.datedrafted, GETDATE()), 
                    ' hours. This is ',(DATEDIFF(hour, r.datedrafted, GETDATE()) - x.avgtimeindraft),' hours more than the average ', 
                    x.AvgTimeinDraft, ' hours all other recipes took to be published.')
from x
cross join users u 
join Recipe r 
on u.UserId = r.Userid
where DATEDIFF(hour, r.DateDrafted, GETDATE()) > x.AvgTimeinDraft
and r.RecipeStatus = 'draft'

/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and recieve a 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/
;
with x as (
    select TotalCookBooks = count(*), AvgPrice = AVG(cb.Price), SumPrice = sum(cb.price) --, cb.CookbookName, cb.Price
    from CookBook cb
    --group by cb.CookbookName, cb.Price
)
 
SELECT EmailBody = CONCAT('cookbooks from HeartyHearth.com! We have ',x.TotalCookBooks, ' books for sale, average price is ', cast(ROUND(x.AvgPrice, 2) as numeric(7,2)), 
        '. You can order them all and recieve a 25% discount, for a total of ', cast(round(x.SumPrice * .75, 2) as numeric(7,2)),'. Click <a href = "www.heartyhearth.com/order/',NEWID(),'">here</a> to order.')
from x 
