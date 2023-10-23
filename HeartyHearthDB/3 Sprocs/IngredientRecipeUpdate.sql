create or alter procedure dbo.IngredientRecipeUpdate(
	@IngredientRecipeId int  output,
	@RecipeId int ,
	@IngredientId int ,
	@MeasurementId int, 
	@Amount int, 
	@IngredientSequence int,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @IngredientRecipeId = isnull(@IngredientRecipeId,0)

	if @IngredientRecipeId = 0
	begin
		insert IngredientRecipe(ingredientid, recipeid, measurementid, amount, ingredientsequence)
		values(@IngredientId, @RecipeId, @MeasurementId, @Amount, @IngredientSequence)

		select @IngredientRecipeId= scope_identity()
	end
	else
	begin
		update IngredientRecipe
		set
			Ingredientid = @IngredientId,
			Recipeid = @RecipeId, 
			Measurementid = @MeasurementId,
			Amount = @Amount,
			@IngredientSequence = @IngredientSequence
		where IngredientRecipeid = @IngredientRecipeId
	end

	return @return
end
go

