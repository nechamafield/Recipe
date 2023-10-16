create or alter procedure dbo.UsersUpdate(
		@UsersId int  output,
		@UsersFirstName varchar (50),
		@UsersLastName varchar (50),
		@Username varchar (50),
		@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @UsersId = isnull(@Usersid,0)
	
	if @Usersid = 0
	begin
		insert Users(UserFirstName, UserLastName, Username)
		values(@UsersFirstName, @UsersLastName, @Username)

		select @UsersId= scope_identity()
	end
	else
	begin
		update Users
		set
			UsersId = @UsersId, 
			UserFirstName = @UsersFirstName,
			UserLastName = @UsersLastName,
			Username = @Username
		where UsersId = @UsersId
	end
	
	return @return
end
go



