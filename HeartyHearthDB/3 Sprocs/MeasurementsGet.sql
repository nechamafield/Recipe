create or alter procedure dbo.MeasurementsGet (@MeasurementId int = 0, @Measurementname varchar (30) = '',  @All bit = 0)
as
begin

	select @Measurementname = nullif (@Measurementname, '')

	select m.Measurementid, m.Measurementname
	from Measurement m
	where m.Measurementid = @MeasurementId
	or @All = 1
	or m.Measurementname like '%' + @Measurementname + '%'
	order by m.Measurementid, m.Measurementname
end
go


--exec MeasurementsGet @All = 1

select * from Measurement