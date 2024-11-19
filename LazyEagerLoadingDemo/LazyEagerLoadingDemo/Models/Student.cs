namespace LazyEagerLoadingDemo.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        // Navigation property for related courses
        public virtual List<Course> Courses { get; set; }
    }
}
