create or alter procedure dbo.IngredientGet (@IngredientId int = 0, @Recipeid int = 0,  @All bit = 0)
as
begin

	select r.Recipeid, i.ingredientname,m.Measurementname, ir.Amount,ir.IngredientSequence 
	from recipe r
	join IngredientRecipe ir
	on ir.Recipeid = r.Recipeid
	join Ingredient i
	on i.ingredientid = ir.Ingredientid
	join Measurement m
	on ir.Measurementid = m.Measurementid
	where r.Recipeid = @Recipeid
	or @All = 1
	order by ir.IngredientSequence

end
go

--/*
exec IngredientGet
exec IngredientGet @All = 1

exec IngredientGet @Recipeid = ' ' -- return no results
exec IngredientGet @Recipeid = 3

declare @Id int
select top 1 @id = i.Ingredientid from Ingredient i
exec IngredientGet @Ingredientid = @Id
--*/





