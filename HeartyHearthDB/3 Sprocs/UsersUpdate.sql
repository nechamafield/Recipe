create or alter procedure dbo.UsersUpdate(
		@UsersId int  output,
		@UserFirstName varchar (50),
		@UserLastName varchar (50),
		@Username varchar (50),
		@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @UsersId = isnull(@Usersid,0)
	
	if @UsersId = 0
	begin
		insert Users(UserFirstName, UserLastName, Username)
		values(@UserFirstName, @UserLastName, @Username)

		select @UsersId= scope_identity()
	end
	else
	begin
		update Users
		set
			UserFirstName = @UserFirstName,
			UserLastName = @UserLastName,
			Username = @Username
		where UsersId = @UsersId
	end
	
	return @return
end
go



