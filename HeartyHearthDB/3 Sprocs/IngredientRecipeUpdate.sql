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

	select @IngredientRecipeId = isnull(@IngredientRecipeId,0), @RecipeId = isnull(@RecipeId,0), @MeasurementId = isnull(@MeasurementId,0)

	if @IngredientRecipeId = 0
	begin
		insert IngredientRecipe(ingredientid, recipeid, measurementid, amount, ingredientsequence)
		values(@IngredientId, @RecipeId, @MeasurementId, @Amount, @IngredientSequence)

		select @IngredientRecipeId= SCOPE_IDENTITY()
	end
	else
	begin
		update IngredientRecipe
		set
			Ingredientid = @IngredientId,
			Recipeid = @RecipeId, 
			Measurementid = @MeasurementId,
			Amount = @Amount,
			IngredientSequence = @IngredientSequence
		where IngredientRecipeid = @IngredientRecipeId
	end

	finished:
	return @return
end
go

