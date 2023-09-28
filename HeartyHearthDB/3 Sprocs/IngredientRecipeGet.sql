create or alter procedure dbo.IngredientRecipeGet(
	@IngredientRecipeId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @IngredientRecipeId = isnull(@IngredientRecipeId,0), @RecipeId = isnull (@RecipeId, 0)

	select ir.IngredientRecipeid, ir.Recipeid, ir.Ingredientid 
	from IngredientRecipe ir
	where ir.IngredientRecipeid = @IngredientRecipeId
	or @All = 1
	or  ir.Recipeid = @RecipeId

	return @return
end
go

--/*
exec IngredientRecipeGet @All = 1

exec IngredientRecipeGet @RecipeId = 7
--*/



