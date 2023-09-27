create or alter procedure dbo.StepsGet (@IngredientId int = 0, @RecipeId int = 0, @All bit = 0)
as
begin

	select dr.Direction, dr.StepNumber 
	from DirectionRecipe dr
	where dr.Recipeid = @RecipeId
	order by dr.StepNumber

end
go

--/*
exec StepsGet
exec StepsGet @All = 1

exec StepsGet @RecipeId = ' ' -- return no results
exec StepsGet @RecipeId =  3

declare @Id int
select top 1 @id = i.Ingredientid from Ingredient i
exec StepsGet @Ingredientid = @Id
--*/

