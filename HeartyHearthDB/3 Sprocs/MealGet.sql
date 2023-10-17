create or alter procedure dbo.mealGet (
	@UserId int = 0, 
	@IncludeBlank bit = 0,
	@All bit = 0
	)
as
begin

	select @UserId = isnull(@UserId, 0), @IncludeBlank = isnull(@IncludeBlank, 0), @All = isnull(@All, 0)
	
	select m.MealName,Calories =  sum( r.Calories), Users = concat(u.UserFirstName,' ', u.UserLastName), NumCourses = count(c.CourseType)--, NumRecipes = count(r.recipename)
	from meal m
	join Users u
	on m.usersid = u.UsersId
	join Recipe r
	on r.Usersid = u.UsersId

	join CourseMeal cm on cm.Mealid = m.Mealid
	join Course c on c.Courseid = cm.Courseid

	where u.Usersid = @UserId
	or @All = 1
	group by  m.MealName, u.UserFirstName, u.UserLastName, c.Coursetype--, r.RecipeName
	order by m.MealName
end
go

--/*
exec mealGet
exec mealGet  @All = 1

declare @Id int
select top 1 @id = m.mealid from meal m
exec mealGet @UserId = @Id
--*/



