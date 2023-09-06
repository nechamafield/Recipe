create or alter procedure dbo.CousineGet (@CousineId int = 0, @CousineType varchar (30) = '',  @All bit = 0)
as
begin

	select @CousineType = nullif (@CousineType, '')

	select c.Cousineid, c.CousineType
	from Cousine c
	where c.Cousineid = @CousineId
	or @All = 1
	or c.CousineType like '%' + @CousineType + '%'
	order by c.Cousineid, c.CousineType
end
go
/*
exec CousineGet
exec CousineGet @All = 1

exec CousineGet @CousineType = ' ' -- return no results
exec CousineGet @CousineType = 'a'

declare @Id int
select top 1 @id = c.cousineid from cousine c
exec CousineGet @Cousineid = @Id
*/
