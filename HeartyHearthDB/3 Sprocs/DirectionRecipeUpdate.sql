create or alter procedure dbo.DirectionRecipeUpdate(
	@DirectionRecipeId int  output,
	@RecipeId int ,
	@StepNumber int,
	@Direction varchar(100) = '',
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId,0)

	if @DirectionRecipeId = 0
	begin
		insert DirectionRecipe(Recipeid, StepNumber, Direction)
		values(@RecipeId, @StepNumber, @Direction)

		select @DirectionRecipeId= scope_identity()
	end
	else
	begin
		update DirectionRecipe
		set
			Recipeid = @RecipeId,
			StepNumber = @StepNumber,
			Direction = @Direction
		where DirectionRecipeid = @DirectionRecipeId
	end

	finished:
	return @return
end
go

--select * from DirectionRecipe

