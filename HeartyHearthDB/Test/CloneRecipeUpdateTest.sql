declare @recipeid int = 36, @message varchar (500) = '' , @return int = 0

exec ClonedRecipeUpdate
@RecipeId = @recipeid output,
@Message = @message 

select @recipeid

select * from recipe r 

--select * 
--from recipe r 
--joins

--select * from DirectionRecipe order by 1 desc


