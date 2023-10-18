create or alter procedure dbo.mealGet (
	@usersId int = 0, 
	@IncludeBlank bit = 0,
	@All bit = 0
	)
as
begin

	select @usersId = isnull(@usersId, 0), @IncludeBlank = isnull(@IncludeBlank, 0), @All = isnull(@All, 0)
	
	select m.MealName,Calories =  sum( r.Calories), users = concat(u.usersFirstName,' ', u.usersLastName), NumCourses = count(c.CourseType)--, NumRecipes = count(r.recipename)
	from meal m
	join users u
	on m.usersid = u.usersId
	join Recipe r
	on r.usersid = u.usersId

	join CourseMeal cm on cm.Mealid = m.Mealid
	join Course c on c.Courseid = cm.Courseid

	where u.usersid = @usersId
	or @All = 1
	group by  m.MealName, u.usersFirstName, u.usersLastName, c.Coursetype--, r.RecipeName
	order by m.MealName
end
go

--/*
exec mealGet
exec mealGet  @All = 1

declare @Id int
select top 1 @id = m.mealid from meal m
exec mealGet @usersId = @Id
--*/



