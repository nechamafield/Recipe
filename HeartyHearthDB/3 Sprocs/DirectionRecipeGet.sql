create or alter procedure dbo.DirectionRecipeGet(
	@DirectionRecipeId int = 0,
	@RecipeId int = 0,
	@Includeblank bit = 0,
	@All bit = 0,
	@Message varchar(500) = ''  output
)
as
begin

	select @All = isnull(@All,0), @DirectionRecipeId = isnull(@DirectionRecipeId,0), @RecipeId = isnull (@RecipeId, 0)

	select dr.DirectionRecipeId	, dr.StepNumber, dr.Direction, dr.RecipeId
	from DirectionRecipe dr
	where dr.DirectionRecipeId = @DirectionRecipeId
	or @All = 1
	or  dr.RecipeId = @RecipeId

end
go

--/*
exec DirectionRecipeGet @All = 1

exec DirectionRecipeGet @RecipeId = 7
--*/

select * from directionrecipe

