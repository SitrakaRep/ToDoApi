namespace TodoApi.Models
{
    public class Enrollment
    {
        public enum Grade
        {
            A, B, C, D, F
        }
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grades { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}