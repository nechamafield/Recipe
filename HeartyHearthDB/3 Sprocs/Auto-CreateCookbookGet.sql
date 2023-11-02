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
	    SELECT u.usersFirstName, u.usersLastName, u.usersId, CookbookName = CONCAT('Recipes by ', u.usersFirstName, ' ', u.usersLastName ), Price = COUNT(r.RecipeName) * 1.33
	    from Recipe r 
	    join users u 
	    on u.usersId = r.usersid
	    where u.usersId = @UsersId
		group by u.usersid, u.usersFirstName, u.usersLastName
	)

	insert CookBook(usersid, CookbookName, Price, IsActive)
	SELECT x.usersid, x.CookbookName, x.Price, 1 
	from x
	
			select @CookbookId = SCOPE_IDENTITY()
	;
	     with x as(
		SELECT CookbookName = CONCAT('Recipes by ', u.usersFirstName, ' ', u.usersLastName ), r.RecipeName, u.usersId
	    from Recipe r 
		join users u
	    on r.usersid = u.usersid
	    --where cb.Cookbookid = @CookbookId
		where u.usersId = @UsersId
	)

	insert CookBookRecipe(Cookbookid, Recipeid, RecipeSequence)
	select cb.CookbookId, r.RecipeId, ROW_NUMBER() over (order by x.recipename)
	from x
	join Recipe r
	on r.RecipeName = x.RecipeName
	join Cookbook cb
	on cb.Cookbookid = @CookbookId

	--select @CookbookId = SCOPE_IDENTITY()	
	end
go


/*

exec AutoCreateCookbookGet  @All = 1
*/

