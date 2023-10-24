create or alter procedure dbo.IngredientDelete(
	@IngredientId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @IngredientId = isnull(@IngredientId,0)

	delete IngredientRecipe where IngredientId = @IngredientId

	return @return
end
go

select * from IngredientRecipe






