create or alter procedure dbo.CookbookGet (@RecipeId int = 0, @CookbookName varchar (100) = '', @All bit = 0)

as
begin

		select @CookbookName = nullif (@CookbookName, '')

	select c.CookbookName, Author = concat(u.UserFirstName, ' ', u.UserLastName), NumRecipes = count(r.Recipeid), c.Price
	from CookBook c
	join Users u
	on c.usersid = u.UsersId
	join Recipe r
	on r.Usersid = u.UsersId
	or @All = 1
	or c.CookbookName like '%' + @CookbookName + '%'
	group by c.CookbookName, u.UserFirstName, u.UserLastName, c.Price
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

select c.CookbookName, Author = concat(u.UserFirstName, ' ', u.UserLastName), NumRecipes = count(r.Recipeid), c.Price
from CookBook c
join Users u
on c.usersid = u.UsersId
join Recipe r
on r.Usersid = u.UsersId
group by c.CookbookName, u.UserFirstName, u.UserLastName, c.Price
