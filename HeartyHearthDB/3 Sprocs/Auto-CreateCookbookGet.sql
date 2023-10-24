create or alter procedure dbo.AutoCreateCookbookGet (@CookbookId int = 0, @IncludeBlank bit = 0, @All bit = 0)

as
begin

with x as(
    SELECT r.RecipeName, u.usersFirstName, u.usersLastName, u.usersId, r.RecipePictureName
    from Recipe r 
    join users u 
    on u.usersId = r.usersid
    where u.usersname = 'rv3561%'
)
insert CookBook(usersid, CookbookName, Price, IsActive)
SELECT x.usersid, CONCAT('Recipes by ', x.usersFirstName, ' ', x.usersLastName ), COUNT(x.RecipeName) * 1.33, 1 --x.RecipeName, i.ingredientname, dr.StepNumber, dr.Direction, Sequences = ROW_NUMBER() over (order by x.recipename)
from x 
join Recipe r 
on x.RecipeName = r.RecipeName 
group by x.usersid, x.usersFirstName, x.usersLastName


;
with x as (
    SELECT cb.Cookbookid, cb.CookbookName, r.Recipeid, r.RecipeName
    from CookBook cb 
    join users u 
    on cb.usersid = u.usersId
    join Recipe r 
    on r.usersid = u.usersid
    where cb.CookbookName LIKE 'Recipes by%'
)

insert CookBookRecipe(Cookbookid, Recipeid, RecipeSequence)
select x.Cookbookid, x.Recipeid, ROW_NUMBER() over (order by x.recipename)
from x 


	--select @CookbookId = isnull(@CookbookId, 0), @IncludeBlank = isnull(@IncludeBlank, 0), @All = isnull(@All, 0)

	--select c.Cookbookid, c.CookbookName, Author = concat(u.usersFirstName, ' ', u.usersLastName), NumRecipes = count(r.Recipeid), c.Price, UsersId = u.usersId, c.DateCreated, active = c.IsActive
	--from CookBook c
	--join users u
	--on c.usersid = u.usersId
	--join Recipe r
	--on r.usersid = u.usersId
	----or @All = 1
	----or c.CookbookId =  @CookbookId
	--group by  c.Cookbookid, c.CookbookName, u.usersFirstName, u.usersLastName, c.Price, u.usersId, c.DateCreated, c.IsActive

end
go
/*
exec CookbookGet
exec AutoCreateCookbookGet  @All = 1
*/

