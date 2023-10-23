create or alter proc dbo.RecipeStatusUpdate(
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