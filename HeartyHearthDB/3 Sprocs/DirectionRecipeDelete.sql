create or alter procedure dbo.DirectionRecipeDelete(
	@DirectionRecipeId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @DirectionRecipeId = isnull(@DirectionRecipeId,0)

	delete DirectionRecipe where DirectionRecipeid = @DirectionRecipeId

	return @return
end
go
