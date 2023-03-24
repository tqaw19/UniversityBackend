using University.Models.DataModels;

namespace University.Services
{
    public interface ICourseService
    {
        IEnumerable<Course> GetCoursesForCategory();
        IEnumerable<Course> GetCoursesWithNoStudents();
        IEnumerable<Course> GetCoursesWithNoChapters();
        IEnumerable<Course> GetChaptersFromCourse();
        IEnumerable<Course> GetStudentsFromCourse();

    }
}
