create or alter procedure dbo.MealsGet (@MealsId int = 0, @Mealname varchar (30) = '',  @All bit = 0)
as
begin

	select @Mealname = nullif (@MealName, '')

	select m.Mealid, m.MealName,  Users = concat(u.UserFirstName,' ', u.UserLastName), count( r.Calories)
	from meal m
	join Users u
	on m.usersid = u.UsersId
	join Recipe r
	on r.Usersid = u.UsersId
	where m.Mealid = @MealsId
	or @All = 1
	or m.MealName like '%' + @MealName+ '%'
	group by m.Mealid, m.MealName,  u.UserFirstName, u.UserLastName, r.Calories
	order by m.MealName
end
go
/*
exec MealsGet
exec MealsGet  @All = 1

exec MealsGet  @mealname = ' ' -- return no results
exec MealsGet  @mealname = 'a'

declare @Id int
select top 1 @id = m.mealid from meal m
exec MealsGet @Mealsid = @Id
*/

--select * from Meal