create or alter procedure dbo.usersDelete(
	@usersId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @usersId = isnull(@usersId,0)

	delete CourseMeal
	delete Meal
	delete DirectionRecipe
	delete IngredientRecipe
	delete CourseMealRecipe
	delete recipe
	delete CookBookRecipe
	delete CookBook
	delete users where usersId = @usersId

	return @return
end
go

/*
delete CourseMeal
delete Meal
delete DirectionRecipe
delete IngredientRecipe
delete CourseMealRecipe
delete recipe
delete CookBookRecipe
delete CookBook
delete u
 from users  u
where u.usersid = 3
*/
