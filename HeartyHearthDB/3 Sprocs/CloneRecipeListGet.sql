create or alter procedure dbo.CloneRecipeGet (
@RecipeId int = 0, 
@RecipeName varchar(30) = '',
@IncludeBlank bit = 0,
@All bit = 0)

as
begin

	select @IncludeBlank = isnull(@IncludeBlank, 0), @RecipeName = isnull(@RecipeName, 0)

	select r.Recipeid, RecipeName = (r.RecipeName + ' - Cloned')
	from recipe r
	where r.recipeid = @RecipeId
	or @All = 1
	or @RecipeName = r.RecipeName
	order by r.RecipeName desc

end
go

--/*
exec CloneRecipeGet @All = 1
--*/

--select * from recipe