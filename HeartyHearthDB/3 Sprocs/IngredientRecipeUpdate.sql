create or alter procedure dbo.IngredientRecipeUpdate(
	@IngredientRecipeId int  output,
	@RecipeId int ,
	@IngredientId int ,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @IngredientRecipeId = isnull(@IngredientRecipeId,0)

	if @IngredientRecipeId = 0
	begin
		insert IngredientRecipe(Recipeid, Ingredientid)
		values(@RecipeId, @IngredientId)

		select @IngredientRecipeId= scope_identity()
	end
	else
	begin
		update IngredientRecipe
		set
			Recipeid = @RecipeId, 
			Ingredientid = @IngredientId
		where IngredientRecipeid = @IngredientRecipeId
	end

	return @return
end
go