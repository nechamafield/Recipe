--AS When you default a param to blank it shouldn't actually have a blank space rather ie: ''
--AS Table column params should go before @All
create or alter procedure dbo.CousineGet (@CousineId int = 0, @CousineType varchar (30) = '',  @All bit = 0)
as
begin
--AS Same as comment above
	select @CousineType = nullif (@CousineType, '')

	select c.Cousineid, c.CousineType
	from Cousine c
	where c.Cousineid = @CousineId
	or @All = 1
	or c.CousineType like '%' + @CousineType + '%'
	order by c.Cousineid, c.CousineType
end
go
--AS Comment out the tests at the bottom
/*
exec CousineGet
exec CousineGet @All = 1

exec CousineGet @CousineType = ' ' -- return no results
exec CousineGet @CousineType = 'a'

declare @Id int
select top 1 @id = c.cousineid from cousine c
exec CousineGet @Cousineid = @Id
*/
