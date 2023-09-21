create or alter function dbo.MealCalorieCount(@MealId int)
returns int 
as
begin
	declare @value int  = 0

		select @value =sum(r.calories) 
		from CourseMealRecipe cmr
		join CourseMeal cm
		on cm.CourseMealid = cmr.CourseMealid 
		join recipe r
		on cmr.recipeid = r.recipeid
		where cm.Mealid = @MealId

	return @value
end
go

select MealCalorieCount = dbo.MealCalorieCount(m.Mealid) 
from meal m