create or alter function dbo.RecipeDesc(@RecipeId int)
returns varchar (150)
as
begin
	declare @value varchar (150) = ''

	select @value = 
			concat(r.RecipeName, ' (', c.CuisineType, ') has ', 
			count(ir.ingredientid), ' ingredients and ',
			count(dr.DirectionRecipeid), ' steps.'
			)
	from recipe r
	join Cuisine c
	on c.Cuisineid = r.Cuisineid
	join IngredientRecipe ir
	on ir.Recipeid = r.Recipeid
	join DirectionRecipe dr
	on r.Recipeid = dr.Recipeid
	where r.Recipeid = @RecipeId
	group by r.RecipeName,c.CuisineType 
	

	return @value
end
go

select RecipeDesc = dbo.RecipeDesc(r.recipeid), r.* 
from recipe r



