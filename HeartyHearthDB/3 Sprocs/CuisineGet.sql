create or alter procedure dbo.CuisineGet (@CuisineId int = 0, @CuisineType varchar (30) = '',  @All bit = 0)
as
begin

	select @CuisineType = nullif (@CuisineType, '')

	select c.CuisineId, c.CuisineType
	from Cuisine c
	where c.CuisineId = @CuisineId
	or @All = 1
	or c.CuisineType like '%' + @CuisineType + '%'
	order by c.CuisineId, c.CuisineType
end
go
/*
exec CuisineGet
exec CuisineGet @All = 1

exec CuisineGet @CuisineType = ' ' -- return no results
exec CuisineGet @CuisineType = 'a'

declare @Id int
select top 1 @id = c.CuisineId from Cuisine c
exec CuisineGet @CuisineId = @Id
*/
