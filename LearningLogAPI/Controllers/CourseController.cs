using LearningLogAPI.Dtos;
using LearningLogAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace LearningLogAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        // GET: api/courses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseDto>>> GetCourses()
        {
            try
            {
                var courses = await _courseService.GetAllCoursesAsync();
                return Ok(courses);
            }
            catch (Exception ex)
            {
                // TODO: Log the exception
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // GET: api/courses/{courseId}
        [HttpGet("{courseId}")]
        public async Task<ActionResult<CourseDto>> GetCourseById(int courseId)
        {
            try
            {
                var course = await _courseService.GetCourseByIdAsync(courseId);

                if (course == null)
                {
                    return NotFound();
                }

                return Ok(course);
            }
            catch (Exception ex)
            {
                // TODO: Log the exception
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // POST: api/courses
        [HttpPost]
        public async Task<ActionResult<CourseDto>> CreateCourse([FromBody] CourseDto courseDto)
        {
            try
            {
                var createdCourse = await _courseService.AddCourseAsync(courseDto);
                return CreatedAtAction(nameof(GetCourseById), new { courseId = createdCourse.Id }, createdCourse);
            }
            catch (Exception ex)
            {
                // TODO: Log the exception
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
