using LearningLogAPI.Dtos;

namespace LearningLogAPI.Services
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseDto>> GetAllCoursesAsync();
        Task<CourseDto?> GetCourseByIdAsync(int courseid);
        Task<CourseDto> AddCourseAsync(CourseDto newCourse);
    }
}
