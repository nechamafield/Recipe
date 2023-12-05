create or alter procedure dbo.CookbookRecipeGet(
	@CookbookRecipeId int = 0,
	@CookbookId int = 0,
	@All bit = 0,
	@Message varchar(500) = ''  output
)
as
begin


	select @All = isnull(@All,0), @CookbookRecipeId = isnull(@CookbookRecipeId,0), @CookbookId = isnull (@CookbookId, 0)

	select  distinct c.Cookbookid, c.CookbookName, r.RecipeName, cr.RecipeSequence, r.Recipeid
	from CookBook c
	left join CookBookRecipe cr
	on c.Cookbookid = cr.Cookbookid
	left join Recipe r 
	on r.Recipeid = cr.Recipeid
	where c.Cookbookid = @CookbookId
	or @All = 1
	order by c.CookbookName, cr.RecipeSequence

end
go

--/*
exec CookbookRecipeGet @All = 1

exec CookbookRecipeGet @cookbookid = 3
--*/



