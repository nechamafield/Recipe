create or alter procedure dbo.IngredientForRecipeGet (@IngredientId int = 0, @Recipeid int = 0,  @All bit = 0)
as
begin

	select distinct i.ingredientname, r.RecipeId,  m.Measurementname,  ir.Amount,ir.IngredientSequence, ir.IngredientRecipeId, i.ingredientId, m.MeasurementId
	from recipe r
	join IngredientRecipe ir
	on ir.Recipeid = r.Recipeid
	join Ingredient i
	on i.ingredientid = ir.Ingredientid
	join Measurement m
	on ir.Measurementid = m.Measurementid
	where r.RecipeId = @Recipeid
	or @All = 1
	order by ir.IngredientSequence

end
go



/*
exec IngredientGet
exec IngredientForRecipeGet @All = 1

exec IngredientGet @Recipeid = ' ' -- return no results
exec IngredientGet @Recipeid = 3

declare @Id int
select top 1 @id = i.Ingredientid from Ingredient i
exec IngredientGet @Ingredientid = @Id
*/

select distinct i.ingredientname from ingredient i 
	


