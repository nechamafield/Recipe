create or alter procedure dbo.RecipeGet (@RecipeId int = 0, @RecipeName varchar (100) = '', @RecipeStatus varchar(30) = '', @All bit = 0)

as
begin

		select @RecipeName = nullif (@RecipeName, ''), @RecipeStatus = nullif (@RecipeStatus, '')

	select r.Recipeid, r.RecipeName,  r.RecipeStatus, users = concat(u.UserFirstName , ' ', u.UserLastName), r.Calories,  NumIngredients = count(ir.Ingredientid), r.Cuisineid, r.DateDrafted, r.DatePublished, r.DateArchived
	from recipe r
	join users u
	on u.usersId = r.usersid
	join IngredientRecipe ir
	on ir.Recipeid = r.Recipeid
	where r.recipeid = @RecipeId
	or @All = 1
	or r.RecipeName like '%' + @RecipeName + '%'
	or r.RecipeStatus like '%' + @RecipeStatus + '%'
	group by r.RecipeName, r.RecipeStatus, r.Calories, u.userFirstName, u.userLastName, r.Recipeid, r.Cuisineid, r.DateDrafted, r.DatePublished, r.DateArchived
	order by r.RecipeStatus desc 

end
go
/*
exec RecipeGet
exec RecipeGet  @All = 1
exec RecipeGet @RecipeStatus = 'archived'

exec RecipeGet  @RecipeName = ' ' -- return no results
exec RecipeGet  @recipeName = 'a'

declare @Id int
select top 1 @id =r.recipeid from recipe r
exec RecipeGet @Recipeid = @Id
*/


select r.recipename, r.recipestatus from Recipe r
