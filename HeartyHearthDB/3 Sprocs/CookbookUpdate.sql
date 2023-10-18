create or alter proc dbo.CookbookUpdate(
	@Cookbookid int ,
	@usersid int ,
	@CookbookName varchar (30),
	@Price int,
	@DateCreated date,
	@IsAvtive bit
)
as
begin
	declare @return int = 0

	select @Cookbookid = isnull(@Cookbookid, 0), @Price = nullif(@Price, 0)

	if @Cookbookid = 0
	begin

		insert CookBook(usersid, CookbookName, Price, DateCreated, IsActive)

		values(@usersid, @CookbookName, @Price, @DateCreated, @IsAvtive)

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
			isactive = @IsAvtive 
		where CookBookId = @Cookbookid
	end

	finished:
	return @return

end
go

--select * from cookbook c