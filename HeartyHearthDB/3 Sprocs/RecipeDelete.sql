create or alter procedure dbo.RecipeDelete(
	@RecipeId int,
	@Message varchar(500) = ' ' output
)
as
begin
	declare @return int = 0

		--AF 'having count > 1' is not necessary, you already wrote 'if exists', so it will only go into the 'if statement' if this select statement returns something
		if exists(select * from Recipe r WHERE (DATEADD(DAY, 30, r.DateArchived) <= GETDATE() or r.RecipeStatus LIKE 'draft') and Recipeid = @RecipeId HAVING count(*) >= 1)
		begin
			select @return = 1, @Message = 'Cannot delete recipe that is not currently in draft or archived for over 30 days.'
			goto finished
		end

	begin try
		delete IngredientRecipe where RecipeId = @RecipeId
		delete DirectionRecipe where Recipeid = @RecipeId
		delete Recipe where Recipeid = @RecipeId 
		--commit
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

