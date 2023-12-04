create or alter proc dbo.ClonedRecipeUpdate(
	@RecipeId int = 0 output,
	@All bit = 0,
	@Message varchar (500) =  '' output
)
as
begin
    ;with x as(
	    select r.usersid, r.Cuisineid,  r.RecipeName, r.Calories, r. DateDrafted, r.DatePublished, r.DateArchived
	    from Recipe r 
        where r.RecipeId = @RecipeId
    )
    insert Recipe(usersid, CuisineId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
    select x.usersid, x.Cuisineid, concat(x.RecipeName, ' - cloned') , x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
    from x
		
		select @RecipeId = SCOPE_IDENTITY()
	
	;with x as(
		select RecipeName = concat(r.RecipeName,' - cloned'), ir.Amount, ir.IngredientId, ir.MeasurementId, ir.IngredientSequence
		from Recipe r
		join IngredientRecipe ir
		on r.RecipeId = ir.RecipeId
		--where r.RecipeId = @RecipeId
	)
	insert IngredientRecipe(Ingredientid, Recipeid, Measurementid, Amount, IngredientSequence)
	select x.Ingredientid, r.RecipeId, x.Measurementid, x.Amount, x.IngredientSequence
	from x
	join Recipe r
	on r.RecipeName = x.RecipeName

	;with x as(
		select RecipeName = concat(r.RecipeName,' - cloned'), dr.StepNumber, dr.Direction
		from Recipe r
		join DirectionRecipe dr
		on r.RecipeId = dr.RecipeId
		--where r.RecipeId = @RecipeId
	)
	insert DirectionRecipe(RecipeId, StepNumber, Direction)
	select r.RecipeId, x.StepNumber, x.Direction
	from x
	join Recipe r
	on r.RecipeName = x.RecipeName

end
go
