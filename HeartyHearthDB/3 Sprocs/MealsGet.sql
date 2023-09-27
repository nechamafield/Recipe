create or alter procedure dbo.MealsGet (
	@MealsId int = 0, 
	@Mealname varchar (30) = '',  
	@Users varchar (50) = '',
	@NumCourses varchar (30) = '',
	@All bit = 0
	)
as
begin

	select @Mealname = nullif (@MealName, ''), @Users = nullif(@users, ''), @NumCourses = nullif(@NumCourses, '')
	
	select m.MealName,Calories =  sum( r.Calories), Users = concat(u.UserFirstName,' ', u.UserLastName), NumCourses = count(c.CourseType)--, NumRecipes = count(r.recipename)
	from meal m
	join Users u
	on m.usersid = u.UsersId
	join Recipe r
	on r.Usersid = u.UsersId

	join CourseMeal cm on cm.Mealid = m.Mealid
join Course c on c.Courseid = cm.Courseid

	where m.Mealid = @MealsId
	or @All = 1
	or m.MealName like '%' + @MealName+ '%'
	group by  m.MealName, u.UserFirstName, u.UserLastName, c.Coursetype--, r.RecipeName
	order by m.MealName
end
go

--/*
exec MealsGet
exec MealsGet  @All = 1

exec MealsGet  @mealname = ' ' -- return no results
exec MealsGet  @mealname = 'a'

declare @Id int
select top 1 @id = m.mealid from meal m
exec MealsGet @Mealsid = @Id
--*/

select sum(r.calories), m.MealName, numcourses = count(c.CourseType)
from Meal m 
join Users u on m.usersid = u.UsersId 
join Recipe r on r.Usersid = u.UsersId
join CourseMeal cm on cm.Mealid = m.Mealid
join Course c on c.Courseid = cm.Courseid
group by m.mealname, c.CourseType

