create or alter procedure dbo.CloneRecipeListGet (
@RecipeId int = 0, 
@RecipeName varchar(30) = '',
@IncludeBlank bit = 0,
@All bit = 0)

as
begin

	select @IncludeBlank = isnull(@IncludeBlank, 0), @RecipeName = isnull(@RecipeName, 0)

	select r.Recipeid, r.RecipeName 
	from recipe r
	where r.recipeid = @RecipeId
	or @All = 1
	or @RecipeName = r.RecipeName
	order by r.RecipeName desc

end
go

