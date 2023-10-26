create or alter procedure dbo.CookbookGet (@CookbookId int = 0, @IncludeBlank bit = 0, @All bit = 0)

as
begin

	select @CookbookId = isnull(@CookbookId, 0), @IncludeBlank = isnull(@IncludeBlank, 0), @All = isnull(@All, 0)

	select distinct c.CookbookName, c.Cookbookid, UsersCompleteName = concat(u.usersFirstName, ' ', u.usersLastName), NumRecipes = count(r.Recipeid), c.Price, u.usersId, c.DateCreated, c.IsActive, r.Recipeid
	from CookBook c
	join users u
	on c.usersid = u.usersId
	join Recipe r
	on r.usersid = u.usersId
	where  c.CookbookId =  @CookbookId
	or @All = 1
	group by  c.Cookbookid, c.CookbookName, u.usersFirstName, u.usersLastName, c.Price, u.usersId, c.DateCreated, c.IsActive, r.Recipeid
	order by c.CookbookName

end
go
/*
exec CookbookGet
exec CookbookGet  @All = 1

exec CookbookGet  @CookbookName = ' ' -- return no results
exec CookbookGet  @CookbookName = 'a'

declare @Id int
select top 1 @id = r.Cookbookname from recipe r
exec CookbookGet @CookbookName = @Id
*/

--select c.CookbookName, Author = concat(u.usersFirstName, ' ', u.usersLastName), NumRecipes = count(r.Recipeid), c.Price, c.DateCreated
--from CookBook c
--join users u
--on c.usersid = u.usersId
--join Recipe r
--on r.usersid = u.usersId
--group by c.CookbookName, u.usersFirstName, u.usersLastName, c.Price, c.DateCreated

