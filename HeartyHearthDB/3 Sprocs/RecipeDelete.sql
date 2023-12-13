create or alter procedure dbo.RecipeDelete(
	@RecipeId int,
	@Message varchar(500) = ' ' output
)
as
begin
	declare @return int = 0

	--this works for all delete tests besides in draft or archived
		if exists(select * from Recipe r WHERE  (dateadd(day,30, datearchived) >= GETDATE() and recipestatus = 'archived')and Recipeid = @RecipeId)
	--this only works for delete test in  draft or archived		
		--f exists(select * from Recipe r WHERE(DATEADD(DAY, 30, r.DateArchived) >= GETDATE() or r.RecipeStatus not LIKE 'draft') and Recipeid = @RecipeId)
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

