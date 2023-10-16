create or alter procedure dbo.CoursesGet (@CourseId int = 0, @CourseType varchar (30) = '',  @CourseSequence int = 0, @All bit = 0)
as
begin

	select @CourseType = nullif (@CourseType, '')

	select c.Courseid, c.CourseType, c.CourseSequence
	from Course c
	where c.Courseid = @CourseId
	or c.CourseSequence = @CourseSequence
	or @All = 1
	or c.CourseType like '%' + @CourseType + '%'
	order by c.Courseid, c.CourseSequence, c.CourseType
end
go



--exec CoursesGet @All = 1

