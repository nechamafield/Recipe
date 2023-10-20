create or alter procedure dbo.StatusRecipeGet (
@RecipeId int = 0, 
@All bit = 0)

as
begin

	

	select r.Recipeid, r.RecipeName, r.DateDrafted, r.DatePublished, r.DateArchived
	from recipe r
	where r.recipeid = @RecipeId
	or @All = 1
	order by r.RecipeStatus desc

end
go

--/*
exec StatusRecipeGet @All = 1
--*/

--select * from recipe