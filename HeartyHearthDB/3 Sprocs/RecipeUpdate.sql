create or alter proc dbo.RecipeUpdate(
	@Recipeid int ,
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

	select @Recipeid = isnull(@Recipeid, 0), @DatePublished = nullif(@datepublished, ''), @DateArchived = nullif(@DateArchived, '')

	--if @DatePublished is null and exists(select * from Recipe r where r.DatePublished is null and r.Recipeid <> @Recipeid)
	--if @DateArchived is null and exists(select * from Recipe r where r.DateArchived is null and r.Recipeid <> @Recipeid)
	--begin
	--	select @return = 1, @Message = 'There can only be 1 recipe at a time.'
	--	goto finished

	--end

	if @Recipeid = 0
	begin
		if @Calories = 0
		begin
			select @Calories = max(r.calories) + 1 from Recipe r
		end

		insert Recipe(usersid, Cuisineid, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
		values(@usersid, @Cuisineid, @RecipeName, @Calories, @DateDrafted, @DatePublished, @DateArchived)

		select @Recipeid = SCOPE_IDENTITY()
	end
	else
	begin
		update Recipe
		set
			usersid = @usersid, 
			Cuisineid = @Cuisineid, 
			RecipeName = @RecipeName, 
			Calories = @Calories, 
			DateDrafted = @DateDrafted, 
			DatePublished = @DatePublished, 
			DateArchived = @DateArchived
		where recipeid = @recipeid
	end

	finished:
	return @return

end
go