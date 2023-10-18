create or alter procedure dbo.DirectionGet (@DirectionId int = 0, @RecipeId int = 0, @All bit = 0)
as
begin

	select dr.Direction, dr.StepNumber 
	from DirectionRecipe dr
	where dr.Recipeid = @RecipeId
	or @All = 1
	order by dr.StepNumber

end
go

--/*
exec DirectionGet
exec DirectionGet @All = 1

exec DirectionGet @RecipeId = ' ' -- return no results
exec DirectionGet @RecipeId =  3

declare @Id int
select top 1 @id = i.Ingredientid from Ingredient i
exec DirectionGet @Directionid = @Id
--*/

