create or alter procedure dbo.MeasurementUpdate(
		@MeasurementId int  output,
		@MeasurementName varchar (30),
		@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @MeasurementId = isnull(@Measurementid,0), @MeasurementName = isnull(@MeasurementName, '')
	
	if @MeasurementId = 0
	begin
		insert Measurement(MeasurementName)
		values(@MeasurementName)

		select @MeasurementId= scope_identity()
	end
	else
	begin
		update Measurement
		set
			MeasurementName = @MeasurementName
		where Measurementid = @MeasurementId
	end
	
	return @return
end
go

--select * from Measurement m