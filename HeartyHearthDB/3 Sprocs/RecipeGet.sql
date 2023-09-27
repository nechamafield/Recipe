create or alter procedure dbo.RecipeGet (@RecipeId int = 0, @RecipeName varchar (100) = '', @All bit = 0)

as
begin

		select @RecipeName = nullif (@RecipeName, '')

	select r.Recipeid, r.RecipeName,  r.RecipeStatus, Users = concat(u.UserFirstName , ' ', u.UserLastName), r.Calories,  NumIngredients = count(ir.Ingredientid)
	from recipe r
	join Users u
	on u.UsersId = r.Usersid
	join IngredientRecipe ir
	on ir.Recipeid = r.Recipeid
	where r.recipeid = @RecipeId
	or @All = 1
	or r.RecipeName like '%' + @RecipeName + '%'
	group by r.RecipeName, r.RecipeStatus, r.Calories, u.UserFirstName, u.UserLastName, r.Recipeid
	order by r.RecipeStatus desc

end
go
/*
exec RecipeGet
exec RecipeGet  @All = 1

exec RecipeGet  @RecipeName = ' ' -- return no results
exec RecipeGet  @recipeName = 'a'

declare @Id int
select top 1 @id =r.recipeid from recipe r
exec RecipeGet @Recipeid = @Id
*/
