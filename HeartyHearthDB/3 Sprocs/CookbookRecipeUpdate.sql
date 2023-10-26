create or alter procedure dbo.CookbookRecipeUpdate(
	@CookbookRecipeId int  output,
	@RecipeId int ,
	@CookbookId int ,
	@RecipeSequence int,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CookbookRecipeId = isnull(@CookbookRecipeId,0)

	if @CookbookRecipeId = 0
	begin
		insert CookbookRecipe(Cookbookid, Recipeid, RecipeSequence)
		values(@CookbookId, @RecipeId, @RecipeSequence)

		select @CookbookRecipeId= SCOPE_IDENTITY()
	end
	else
	begin
		update CookbookRecipe
		set
			Cookbookid = @CookbookId,
			Recipeid = @RecipeId, 
			RecipeSequence = @RecipeSequence
		where CookBookRecipeid = @CookbookRecipeId
	end

	finished:
	return @return
end
go


--select * from CookBookRecipe


