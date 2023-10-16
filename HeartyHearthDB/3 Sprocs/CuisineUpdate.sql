create or alter procedure dbo.CuisineUpdate(
		@CuisineId int  output,
		@CuisineType varchar (30),
		@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CuisineId = isnull(@Cuisineid,0), @CuisineType = isnull(@CuisineType, '')
	
	if @CuisineId = 0
	begin
		insert cuisine(CuisineType)
		values(@CuisineType)

		select @CuisineId= scope_identity()
	end
	else
	begin
		update Cuisine
		set
			CuisineType = @CuisineType
		where CuisineId = @CuisineId
	end
	
	return @return
end
go

--select * from cuisine c