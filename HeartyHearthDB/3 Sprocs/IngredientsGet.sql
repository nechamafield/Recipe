create or alter procedure dbo.IngredientsGet (@IngredientsId int = 0, @IngredientName varchar (30) = '',  @All bit = 0)
as
begin

	select @IngredientName = nullif (@IngredientName, '')

	select i.ingredientid, i.ingredientname
	from Ingredient i
	where i.ingredientid = @IngredientsId
	or @All = 1
	or i.ingredientname like '%' + @IngredientName + '%'
	order by i.ingredientid, i.ingredientname
end
go
 


--exec IngredientsGet @All = 1

