create or alter procedure dbo.RecipeDelete(
	@RecipeId int,
	@Message varchar(500) = ' ' output
)
as
begin
	declare @return int = 0

		if exists(select * from Recipe r where r.RecipeId = @RecipeId and ((datediff(day, r.DateArchived, getdate() ) <= 30  and r.recipestatus = 'archived') or (r.RecipeStatus = 'Published') or (r.RecipeStatus  LIKE 'draft')))
		begin
			select @return = 1, @Message = 'Cannot delete recipe that is not currently in draft or archived for over 30 days.'
			goto finished
		end

	begin try
	begin tran
		delete CookBookRecipe where Recipeid = @RecipeId
		delete CourseMealRecipe where Recipeid = @RecipeId
		delete IngredientRecipe where RecipeId = @RecipeId
		delete DirectionRecipe where Recipeid = @RecipeId
		delete Recipe where Recipeid = @RecipeId 
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	finished:
	return @return
end
go


--test
--/*
set nocount on
declare @recipeid int 

declare @return int, @message varchar (500)
exec @return =  RecipeDelete @recipeid = @recipeid, @message = @message output 

select @return, @message
--*/

