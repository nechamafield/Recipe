create or alter procedure dbo.IngredientGet (@Ingredientid int = 0,  @All bit = 0)
as
begin

	select @Ingredientid = nullif (@Ingredientid, 0)

	select i.ingredientid, i.ingredientname, ir.RecipeId
	from Ingredient i
	join IngredientRecipe ir
	on ir.IngredientId = i.ingredientid
	where i.ingredientid = @Ingredientid
	or @All = 1
	order by i.ingredientid, i.ingredientname
end
go
 


--exec IngredientGet @All = 1

