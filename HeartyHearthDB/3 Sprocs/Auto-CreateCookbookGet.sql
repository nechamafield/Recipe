create or alter procedure dbo.AutoCreateCookbookGet (
	@CookbookId int = 0 output, 
	@UsersId int = 0 output,
	@IncludeBlank bit = 0, 
	@All bit = 0,
	@Message varchar (500) =  '' output
)

as
begin

	;with x as(
	    SELECT r.RecipeName, u.usersFirstName, u.usersLastName, u.usersId, CookbookName = CONCAT('Recipes by ', u.usersFirstName, ' ', u.usersLastName ), Price = COUNT(r.RecipeName) * 1.33
	    from Recipe r 
	    join users u 
	    on u.usersId = r.usersid
	    where u.usersId = @UsersId
		group by u.usersid, u.usersFirstName, u.usersLastName, r.RecipeName
	)

	insert CookBook(usersid, CookbookName, Price, IsActive)
	SELECT x.usersid, x.CookbookName, x.Price, 1 
	from x 
	join Recipe r 
	on x.RecipeName = r.RecipeName 
	
			select @CookbookId = SCOPE_IDENTITY()
	;
	with x as (
	    SELECT CookbookName = CONCAT('Recipes by ', u.usersFirstName, ' ', u.usersLastName ), r.RecipeName, u.usersId
	    from CookBook cb 
	    join users u 
	    on cb.usersid = u.usersId
	    join Recipe r 
	    on r.usersid = u.usersid
	    --where cb.Cookbookid = @CookbookId
		where u.usersId = @UsersId
	)
	
	insert CookBookRecipe(Cookbookid, Recipeid, RecipeSequence)
	select cb.CookbookId, r.RecipeId, ROW_NUMBER() over (order by x.recipename)
	from x
	join CookBook cb 
	on x.usersId = cb.usersid
	join Recipe r
	on x.usersId = r.usersid

	--select @CookbookId = SCOPE_IDENTITY()
	
	end
go


/*

exec AutoCreateCookbookGet  @All = 1
*/

