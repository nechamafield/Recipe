-- SM WOw excellent neat code! 100%
use HeartyHearthDB
go

delete cookbookrecipe
delete cookbook
delete coursemealrecipe
DELETE coursemeal
delete meal
DELETE course
DELETE directionrecipe
DELETE ingredientrecipe
delete measurement
delete recipe
delete cousine
delete users
delete ingredient
go

insert ingredient(ingredientname)
SELECT 'Sugar'
union select 'Oil'
union select 'Eggs'
union select 'Flour'
union select 'Vanilla Sugar'
union select 'Baking Powder'
union select 'Chocolate Chips'
union select 'Granny Smith Apples'
union select 'Vanilla Yogurt'
union select 'Orange Juice'
union select 'Honey'
union select 'Ice Cubes'
union select 'Bread'
union select 'Butter'
union select 'Shredded Cheese'
union select 'Crushed Garlic'
union select 'Black Pepper'
union select 'Salt'
union select 'Vanilla Pudding'
union select 'Whipped Cream Cheese'
union select 'Sour Cream Cheese'
union select 'Grape Juice'
union select 'Lemon Juice'
union select 'Water'
union select 'Colored Pepper'
union select 'Zucchini'
union select 'Yellow Squash'
union select 'onion'
union select 'Purple Onion'
union select 'Oil'
union select 'Basil'
union select 'Chicken Cutlets'
union select 'Corn Starch'

SELECT * from ingredient i 

insert users(userfirstname, userlastname, username)
SELECT 'Nechama', 'Field', 'nf3003050'
union select 'Chana', 'Adler', 'ca4256985'
union select 'Bracha', 'Fischer', 'bf425!'
union select 'Miriam', 'Horowitz', 'mh7770109'
union select 'Rivkah', 'Vorcher', 'rv3561%'

SELECT * from users 

insert cousine(CousineType)
SELECT 'American'
union select 'French'
union select 'English'
union select 'Hungarian'
union select 'Flemish'

select * from cousine

;
with x as(
    select username = 'nf3003050', cousinetype = 'American' ,recipename = 'Chocolate Chip Cookies',calories = 100, datedrafted = '12/03/15', datepublished = '12/03/17 19:54:44.123', DateArchived = '12/03/22'
    UNION select 'ca4256985', 'French', 'Apple Yogurt Smoothie', 150, '12/15/13', '11/11/19 06:56:36.562', '12/29/21'
    union select 'bf425!', 'English', 'Cheese Bread', 230,  '01/13/21', '10/26/21 12:45:32.125', null
    union select 'mh7770109', 'Hungarian', 'Butter Muffins', 190,  '06/28/03', null, '09/25/09'
    union select 'rv3561%', 'Flemish', 'Grape Juice Ices', 50,  '05/15/06', '12/29/06 05:32:59.956', null
    union select 'rv3561%', 'Flemish', 'Roasted Veggies', 75,  '08/21/01', null, null
    union select 'nf3003050', 'Hungarian', 'Batter Dipped Chicken', 250, '08/21/16', '11/11/19 06:56:36.562', null
)

insert recipe(userid, cousineid, recipename, calories,  datedrafted, datepublished, datearchived)
select u.UserId, c.cousineid, x.recipename,x.calories, x.datedrafted, x.datepublished, x.DateArchived
from x  
join users u 
on x.username = u.Username
join cousine c 
on c.cousinetype = x.cousinetype

select * from Recipe r 

insert measurement(Measurementname)
select 'cup'
union select 'tsp'
union select 'tbsp'
union select 'club'
union select 'oz'
union select 'cloves'
union select 'pinch'
union select 'stick'
union select 'dash'
union select 'lb'

select * from Measurement

;
with x as(
    select ingredientname = 'Sugar', RecipeName = 'Chocolate Chip Cookies', Measurementname = 'cup', amount = '1', ingredientsequence = 1
    union select 'oil', 'Chocolate Chip Cookies', 'cup', 1.5, 2
    union select 'eggs', 'Chocolate Chip Cookies', '', 3, 3
    union select 'flour', 'Chocolate Chip Cookies', 'cup', 2, 4
    union select 'vanilla sugar', 'Chocolate Chip Cookies', 'tsp', 1, 5
    union select 'baking powder', 'Chocolate Chip Cookies', 'tsp', 2, 6
    union select 'baking soda', 'Chocolate Chip Cookies', 'tsp', 1.5, 7
    union select 'chocolate chips','Chocolate Chip Cookies', 'cup', 1, 8
    union select 'granny smith apples', 'Apple Yogurt Smoothie', '', 3, 1
    union select 'vanilla Yogurt', 'Apple Yogurt Smoothie', 'cup', 2, 2
    union select 'sugar', 'Apple Yogurt Smoothie', 'tsp', 2, 3
    union select 'orange juice', 'Apple Yogurt Smoothie', 'cup', .5, 4
    union select 'honey', 'Apple Yogurt Smoothie', 'tbsp', 2, 5
    union select 'ice cubes', 'Apple Yogurt Smoothie', '', 5, 6
    union select 'bread', 'Cheese Bread', 'club', 1, 1
    union select 'butter', 'Cheese Bread', 'oz', 4, 2
    union select 'shredded cheese', 'Cheese Bread', 'oz', 8, 3
    union select 'crushed garlic', 'Cheese Bread', 'cloves',2, 4
    union select 'black pepper', 'Cheese Bread', 'tsp', .25, 5
    union select 'salt', 'Cheese Bread', 'pinch', 1, 6
    union select 'butter', 'Butter Muffins', 'stick', 1, 1
    union select 'sugar', 'Butter Muffins', 'cup', 3, 2
    union select 'vanilla pudding', 'Butter Muffins', 'tbsp', 2, 3
    union select 'eggs', 'Butter Muffins', '', 4, 4
    union select 'whipped cream cheese', 'Butter Muffins', 'oz', 8, 5
    union select 'sour cream cheese', 'Butter Muffins', 'oz', 8, 6
    union select 'flour', 'Butter Muffins', 'cup', 1, 7
    union select 'baking powder', 'Butter Muffins', 'tsp', 2, 8
    union select 'grape juice', 'grape juice ices', 'cup', 3, 1
    union select 'lemon juice', 'grape juice ices', 'cup', 1, 2
    union select 'water', 'grape juice ices', 'cup', 1, 3
    union select 'suger', 'grape juice ices', 'cup', 1, 4
    union select 'colored peppers', 'roasted veggies', '', 3, 1
    union select 'zucchini', 'roasted veggies', '', 2, 2
    union select 'yellow squash', 'roasted veggies', '', 2, 3
    union select 'onion', 'roasted veggies','', 1, 4
    union select 'purple onion', 'roasted veggies', '', 1, 5
    union select 'oil', 'roasted veggies', 'cup', .5, 6
    union select 'basil', 'roasted veggies', 'tsp', .5, 7
    union select 'black pepper', 'roasted veggies', 'dash', 1, 8
    union select 'salt', 'roasted veggies', 'tsp', 1, 9
    union select 'chicken cutlets', 'Batter dipped chicken', 'lb', 5, 1
    union select 'corn starch', 'Batter dipped chicken', 'cup', .5, 2
    union select 'oil', 'Batter dipped chicken', 'cup', .25, 3
    union select 'eggs', 'Batter dipped chicken', '', 1, 4
    union select 'salt', 'Batter dipped chicken', 'pinch', 1, 5
)

insert ingredientrecipe(ingredientid, recipeid, measurementid, amount, ingredientsequence)
select i.ingredientid, r.Recipeid, m.Measurementid, x.amount, x.ingredientsequence
from x 
join Ingredient i 
on i.ingredientname = x.ingredientname
join Recipe r 
on r.RecipeName = x.RecipeName
left join Measurement m 
on m.Measurementname = x.Measurementname


select r.RecipeName, ir.IngredientSequence, i.ingredientname 
from ingredientrecipe ir left join recipe r on r.Recipeid = ir.Recipeid left join Ingredient i on i.ingredientid = ir.Ingredientid 
 --where i.ingredientname = '%apple%'
 order by ir.Recipeid, ir.IngredientSequence

;
with x as(
    select recipename = 'chocolate chip cookies', stepnumber = 1, direction = 'First combine sugar, oil, and eggs in a bowl'
    union select 'chocolate chip cookies', 2, 'mix well'
    union select 'chocolate chip cookies', 3, 'add flour, vanilla sugar, baking powder, and baking soda'
    union select 'chocolate chip cookies', 4, 'beat for 5 minutes'
    union select 'chocolate chip cookies', 5, 'add chocolate chips'
    union select 'chocolate chip cookies', 6, 'freeze for 1-2 hours'
    union select 'chocolate chip cookies', 7, 'roll into balls and place spread out on a cookie sheet'
    union select 'chocolate chip cookies', 8, 'bake on 350 for 10 min.'
    union select 'Apple Yogurt Smoothie', 1, 'Peel the apples and dice'
    union select 'Apple Yogurt Smoothie', 2, 'Combine all ingredients in bowl except for apples and ice cubes'
    union select 'Apple Yogurt Smoothie', 3, 'mix until smooth'
    union select 'Apple Yogurt Smoothie', 4, 'add apples and ice cubes'
    union select 'Apple Yogurt Smoothie', 5, 'pour into glasses.'
    union select 'Cheese Bread', 1, 'Slit bread every 3/4 inch'
    union select 'Cheese Bread', 2, 'Combine all ingredients in bowl'
    union select 'Cheese Bread', 3, 'fill slits with cheese mixture'
    union select 'Cheese Bread', 4, 'wrap bread into a foil and bake for 30 minutes.'
    union select 'Butter Muffins', 1, 'Cream butter with sugars'
    union select 'Butter Muffins', 2, 'Add eggs and mix well'
    union select 'Butter Muffins', 3, 'Slowly add rest of ingredients and mix well'
    union select 'Butter Muffins', 4, 'fill muffin pans 3/4 full and bake for 30 minutes.'
    union select 'Grape Juice Ices', 1, 'Combine everything in a pot'
    union select 'Grape Juice Ices', 2, 'Bring it to a boil'
    union select 'Grape Juice Ices', 3, 'Freeze'
    union select 'Grape Juice Ices', 4, 'blend once frozen'
    union select 'Grape Juice Ices', 5, 'refreeze'
    union select 'Roasted veggies', 1, 'Preheat oven to 450'
    union select 'Roasted veggies', 2, 'dice all veggies'
    union select 'Roasted veggies', 3, 'combine in 9x13'
    union select 'Roasted veggies', 4, 'mix oil with spices'
    union select 'Roasted veggies', 5, 'pour seasoning over veggies'
    union select 'Roasted veggies', 6, 'place in oven for 1 hr'
    union select 'Roasted veggies', 7, 'stir every 20 minutes'
    union select 'Batter Dipped Chicken', 1, 'cut cutlets into small pieces'
    union select 'Batter Dipped Chicken', 2, 'add in rest of ingredients'
    union select 'Batter Dipped Chicken', 3, 'mix with a strong spoon'
    union select 'Batter Dipped Chicken', 4, 'heat oil in frying pan on medium flame'
    union select 'Batter Dipped Chicken', 5, 'using a spoon, fill up the pan with cutlets in batter'
    union select 'Batter Dipped Chicken', 6, 'take out using a slotted spoon'
    union select 'Batter Dipped Chicken', 7, 'repeat until all cutlets are fried'                    
)

insert directionrecipe(recipeid, stepnumber, direction)
select r.Recipeid, x.stepnumber, x.direction
from x 
join Recipe r 
on r.RecipeName = x.recipename

select * from directionrecipe dr

insert Course(coursetype, coursesequence)
select 'Appetizer', 1
union select 'Soup', 2
union select 'Main', 3
union select 'Dessert', 4

select * from course

;
with x as(
    select username = 'nf3003050', mealname = 'Breakfast Bash', isactive = 1 
    union select 'bf425!', 'Supper', 1
    union select 'mh7770109', 'Lunch', 1
    union select 'rv3561%', 'Brunch', 0
)

insert meal(userid, mealname, isactive)
select u.UserId, x.mealname,  x.isactive
from x 
join Users u 
on u.Username = x.username

SELECT * from meal m 

;
with x as (
    select coursetype = 'main', Mealname = 'Breakfast Bash'
    union select 'appetizer', 'breakfast bash'
    union select 'main', 'supper'
    union select 'dessert', 'supper'
    union select 'appetizer', 'lunch'
    union select 'main', 'lunch'
    union select 'dessert', 'Lunch'
    union select 'appetizer', 'brunch'
    union select 'main', 'brunch'
    union select 'dessert', 'brunch'
)

insert coursemeal(courseid, mealid)
select c.courseid, m.mealid 
from x
join course c 
on c.coursetype = x.coursetype
join meal m 
on m.mealname = x.Mealname

SELECT * from coursemeal

;
with x as (
    select coursetype = 'main', mealname = 'breakfast bash', recipename = 'Butter Muffins', ismain =0
    union SELECT 'main', 'breakfast bash', 'cheese bread', 1
    union select 'appetizer', 'breakfast bash', 'apple yogurt smoothie', 0
    union select 'main', 'Supper', 'batter dipped chicken', 1
    union select 'main', 'supper', 'roasted veggies', 0
    union select 'dessert', 'supper', 'grape juice ices', 0
    union select 'appetizer', 'lunch', 'apple yogurt smoothie', 0
    union select 'main', 'lunch', 'cheese bread', 1
    union select 'dessert', 'lunch', 'chocolate chip cookies', 0
    union SELECT 'dessert', 'lunch', 'grape juice ices', 0
    union select 'main', 'brunch', 'cheese bread', 1
    union SELECT 'main', 'brunch', 'roasted veggies', 0
    union select 'appetizer', 'brunch', 'butter muffins', 0
    union select 'dessert', 'brunch', 'chocolate chip cookies', 0
)

INSERT coursemealrecipe(coursemealid, recipeid, ismain)
SELECT cm.coursemealid, r.recipeid, x.ismain
from x
join Course c 
on c.CourseType = x.coursetype
join Meal m 
on m.MealName = x.mealname
join CourseMeal cm 
on m.Mealid = cm.Mealid 
and cm.Courseid = c.Courseid
join recipe r 
on r.recipename = x.recipename

select * from coursemealrecipe

;
with x as(
    select username = 'nf3003050', cookbookname = 'Treats for two', price = 30, isactive = 1
    union select 'ca4256985', 'The Bakers Taster', 39.99, 0
    union select 'rv3561%', 'The Cookbook', 25, 1
    union select 'mh7770109', 'Cookoo Cooks', 45.89, 1
)

insert cookbook(userid, cookbookname, price, isactive)
SELECT u.UserId, x.cookbookname, x.price, x.isactive
from x 
join users u 
on u.Username = x.username

select * from Cookbook cb 


;
with x as (
    select cookbookname = 'Treats for two', recipename = 'chocolate chip cookies', recipesequence = 1 
    union select 'Treats for two', 'apple yogurt smoothie', 2
    union select 'Treats for two', 'Cheese Bread',3
    union select 'Treats for two', 'Butter Muffin', 4
    union select 'The Bakers Taster', 'chocolate chip cookies', 1
    union select 'The Bakers Taster', 'Butter Muffin', 2
    union select 'The Bakers Taster', 'Cheese Bread', 3
    union select 'The Cookbook', 'apple yogurt smoothie', 1
    union select 'The Cookbook', 'Batter dipped chicken', 2
    union select 'The Cookbook', 'roasted veggies', 3
    union select 'The Cookbook', 'grape juice ices', 4
    union select 'Cookoo Cooks', 'chocolate chip cookies', 1
    union select 'Cookoo Cooks', 'apple yogurt smoothie', 2
    union select 'Cookoo Cooks', 'Cheese Bread', 3
    union select 'Cookoo Cooks', 'Butter Muffin', 4
    union select 'Cookoo Cooks', 'grape juice ices', 5
    union select 'Cookoo Cooks','roasted veggies', 6
    union select 'Cookoo Cooks', 'batter dipped chicken', 7
)

insert cookbookrecipe(cookbookid, recipeid, recipesequence)
SELECT cb.cookbookid, r.Recipeid, x.recipesequence
from x 
join cookbook cb 
on cb.cookbookname = x.cookbookname
join Recipe r 
on r.RecipeName = x.recipename

select * from cookbookrecipe cbr

