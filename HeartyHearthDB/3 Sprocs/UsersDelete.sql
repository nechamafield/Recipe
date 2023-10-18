create or alter procedure dbo.usersDelete(
	@usersId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @usersId = isnull(@usersId,0)

	delete users where usersId = @usersId

	return @return
end
go
