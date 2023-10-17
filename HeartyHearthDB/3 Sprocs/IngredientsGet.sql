create or alter procedure dbo.IngredientGet (@IngredientId int = 0,  @All bit = 0)
as
begin

	select @IngredientId = nullif (@IngredientId, 0)

	select i.ingredientid, i.ingredientname
	from Ingredient i
	where i.ingredientid = @IngredientId
	or @All = 1
	order by i.ingredientid, i.ingredientname
end
go
 


--exec IngredientGet @All = 1

