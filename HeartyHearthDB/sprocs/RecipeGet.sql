create or alter procedure dbo.RecipeGet (@RecipeId int = 0, @All bit = 0, @RecipeName varchar (100) = ' ')
as
begin
		select @RecipeName = nullif (@RecipeName, ' ')

	select *
	from recipe r
	where r.recipeid = @RecipeId
	or @All = 1
	or r.RecipeName like '%' + @RecipeName+ '%'
	order by 
end
go

/*
exec RecipeGet
exec RecipeGet  @All = 1

exec RecipeGet  @RecipeName = ' ' -- return no results
exec RecipeGet  @RecipeName = 'a'

declare @Id int
select top 1 @id = r.recipeid from recipe r
exec RecipeGet @Recipeid = @Id
*/