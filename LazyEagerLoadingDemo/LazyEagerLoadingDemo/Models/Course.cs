namespace LazyEagerLoadingDemo.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        // Navigation property back to the student
        public virtual Student Student { get; set; }
        public int StudentId { get; set; }
    }
}
