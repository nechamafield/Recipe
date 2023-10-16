create or alter procedure dbo.IngredientDelete(
	@CuisineId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CuisineId = isnull(@CuisineId, 0)

	delete Ingredient  where ingredientid = @CuisineId

	return @return
end
go
