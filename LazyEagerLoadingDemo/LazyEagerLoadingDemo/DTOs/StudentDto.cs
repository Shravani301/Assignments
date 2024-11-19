namespace LazyEagerLoadingDemo.DTOs
{
    public class StudentDto
    {
        public int StudentId { get; set; } // Maps to StudentId in Student entity
        public string Name { get; set; } // Maps to Name in Student entity
        public List<CourseDto> Courses { get; set; } // Maps to the Courses navigation property

    }
}
