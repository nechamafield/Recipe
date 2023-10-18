create or alter procedure dbo.usersGet (@usersId int = 0, @usersname varchar (30) = '',  @All bit = 0)
as
begin

	select @usersname = nullif (@usersName, '')

	select u.usersId, usersCompleteName = concat(u.usersFirstName, ' ', u.usersLastName), u.usersname
	from users u
	where u.usersId = @usersId
	or @All = 1
	or u.usersname like '%' + @usersname+ '%'
	order by u.usersId, u.usersFirstName, u.usersLastName, u.usersname
end
go
/*
exec usersGet
exec usersGet  @All = 1

exec usersGet  @usersname = ' ' -- return no results
exec usersGet  @usersname = 'a'

declare @Id int
select top 1 @id = u.usersid from users u
exec usersGet @usersid = @Id
*/