create or alter proc dbo.ClonedRecipeUpdate(
	@Recipeid int output,
	@usersid int ,
	@Cuisineid int ,
	@RecipeName varchar (30),
	@Calories int ,
	@DateDrafted datetime ,
	@DatePublished datetime ,
	@DateArchived datetime ,
	@Message varchar (500) = ' ' output
)
as
begin
	declare @return int = 0

	select @Recipeid = isnull(@Recipeid, 0), @DatePublished = nullif(@datepublished, ''), @DateArchived = nullif(@DateArchived, ''), @usersid = nullif(@usersid, 0), @Cuisineid = nullif(@CuisineId, 0)


	if @Recipeid = 0
	begin
		if @Calories = 0
		begin
			select @Calories = max(r.calories) + 1 from Recipe r
			where Recipeid = @Recipeid
		end
		if @RecipeName = ''
		begin
			select @RecipeName = concat(r.RecipeName, ' - Cloned') from Recipe r
			where Recipeid = @Recipeid
		end
end
		;
		with x as(
		select r.usersid, r.Cuisineid, r.RecipeName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived
		from Recipe r
		where r.Recipeid = @Recipeid
		)

		insert Recipe(usersid, Cuisineid, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
		select x.usersid, x.Cuisineid, concat(x.RecipeName, ' - Cloned'), x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
		from x


		select @Recipeid = SCOPE_IDENTITY()
	end

	finished:
	return @return

go
