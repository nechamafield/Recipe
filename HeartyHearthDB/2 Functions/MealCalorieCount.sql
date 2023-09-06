create or alter function dbo.MealCalorieCount(@MealId int)
returns varchar (50)
as
begin
	declare @value varchar (50) = ''

		select @value =sum(r.calories) 
		from CourseMealRecipe cmr
		join CourseMeal cm
		on cm.CourseMealid = cmr.CourseMealid 
		join recipe r
		on cmr.recipeid = r.recipeid
		where cm.Mealid = @MealId
		group by cm.Mealid

	return @value
end
go

select MealCalorieCount = dbo.MealCalorieCount(m.Mealid) 
from meal m