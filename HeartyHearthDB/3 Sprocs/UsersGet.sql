create or alter procedure dbo.UsersGet (@UsersId int = 0, @Username varchar (30) = '',  @All bit = 0)
as
begin

	select @Username = nullif (@UserName, '')

	select u.UsersId, u.UserFirstName, u.UserLastName, u.Username
	from users u
	where u.UsersId = @UsersId
	or @All = 1
	or u.Username like '%' + @Username+ '%'
	order by u.UsersId, u.UserFirstName, u.UserLastName, u.Username
end
go
/*
exec UsersGet
exec UsersGet  @All = 1

exec UsersGet  @Username = ' ' -- return no results
exec UsersGet  @Username = 'a'

declare @Id int
select top 1 @id = u.usersid from users u
exec UsersGet @Usersid = @Id
*/