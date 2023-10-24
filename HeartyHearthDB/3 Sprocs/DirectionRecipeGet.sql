create or alter procedure dbo.DirectionRecipeGet(
	@DirectionRecipeId int = 0,
	@RecipeId int = 0,
	@Includeblank bit = 0,
	@All bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @DirectionRecipeId = isnull(@DirectionRecipeId,0), @RecipeId = isnull (@RecipeId, 0)

	select dr.DirectionRecipeid, dr.StepNumber, dr.Direction
	from DirectionRecipe dr
	where dr.DirectionRecipeid = @DirectionRecipeId
	or @All = 1
	or  dr.Recipeid = @RecipeId

	return @return
end
go


--/*
exec DirectionRecipeGet @All = 1

exec DirectionRecipeGet @RecipeId = 7
--*/

select * from directionrecipe