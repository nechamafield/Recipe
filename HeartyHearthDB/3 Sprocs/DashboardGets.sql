create or alter proc dbo.DashboardGet(
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select DashboardType = 'Recipe', DashboardText = count(*) from recipe r
	union
	select DashboardType = 'Meal', DashboardText = count(*) from Meal m
	union
	select DashboardType = 'Cookbook', DashboardText = count(*) from CookBook c

	return @return
end
go
exec DashboardGet

