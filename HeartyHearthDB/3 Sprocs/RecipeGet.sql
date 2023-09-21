<<<<<<< HEAD
create or alter procedure dbo.RecipeGet (@RecipeId int = 0, @All bit = 0, @RecipeName varchar (30) = '')
=======

create or alter procedure dbo.RecipeGet (@RecipeId int = 0, @RecipeName varchar (100) = '', @All bit = 0)
>>>>>>> 61c6e13f224266ded1278f6d705534e118893636
as
begin

		select @RecipeName = nullif (@RecipeName, '')

<<<<<<< HEAD
	select r.Recipeid, r.Usersid, r.cousineid, r.RecipeName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePictureName
=======

	select r.Recipeid, r.Usersid, r.cousineid, r.RecipeName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePictureName
>>>>>>> 61c6e13f224266ded1278f6d705534e118893636
	from recipe r
	where r.recipeid = @RecipeId
	or @All = 1
	or r.RecipeName like '%' + @RecipeName+ '%'
<<<<<<< HEAD
	order by r.Recipeid, r.Usersid, r.cousineid, r.RecipeName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePictureName
=======

	order by r.Recipeid, r.Usersid, r.cousineid, r.RecipeName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePictureName
>>>>>>> 61c6e13f224266ded1278f6d705534e118893636
end
go
/*
exec RecipeGet
exec RecipeGet  @All = 1

exec RecipeGet  @RecipeName = ' ' -- return no results
exec RecipeGet  @recipeName = 'a'

declare @Id int
select top 1 @id =r.recipeid from recipe r
exec RecipeGet @Recipeid = @Id
*/
