create or alter proc dbo.CookbookUpdate(
	@Cookbookid int ,
	@usersid int ,
	@CookbookName varchar (30),
	@Price decimal(7,2),
	@DateCreated date,
	@IsActive bit
)
as
begin
	declare @return int = 0

	select @Cookbookid = isnull(@Cookbookid, 0), @Price = nullif(@Price, 0), @IsActive = nullif(@IsActive, 0)

	if @Cookbookid = 0
	begin

		insert CookBook(usersid, CookbookName, Price, DateCreated, IsActive)

		values(@usersid, @CookbookName, @Price, @DateCreated, @IsActive)

		select @Cookbookid = SCOPE_IDENTITY()
	end
	else
	begin
		update CookBook
		set
			usersid = @usersid,
			cookbookname = 	@CookbookName,
			price = @Price, 
			datecreated = @DateCreated, 
			isactive = @IsActive 
		where CookBookId = @Cookbookid
	end

	finished:
	return @return

end
go

--select * from cookbook c