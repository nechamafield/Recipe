create or alter procedure dbo.usersUpdate(
		@usersId int  output,
		@usersFirstName varchar (50),
		@usersLastName varchar (50),
		@usersname varchar (50),
		@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @usersId = isnull(@usersid,0)
	
	if @usersId = 0
	begin
		insert users(usersFirstName, usersLastName, usersname)
		values(@usersFirstName, @usersLastName, @usersname)

		select @usersId= scope_identity()
	end
	else
	begin
		update users
		set
			usersFirstName = @usersFirstName,
			usersLastName = @usersLastName,
			usersname = @usersname
		where usersId = @usersId
	end
	
	return @return
end
go



