create or alter procedure dbo.IngredientRecipeDelete(
	@IngredientRecipeId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @IngredientRecipeId = isnull(@IngredientRecipeId,0)

	delete IngredientRecipe where IngredientRecipeid = @IngredientRecipeId

	return @return
end
go
