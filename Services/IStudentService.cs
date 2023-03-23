using University.Models.DataModels;

namespace University.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudentsWithCourses();
        IEnumerable<Student> GetStudentsWithNoCourses();
    }
}
