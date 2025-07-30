using AutoMapper;
using LearningLogAPI.DbContexts;
using LearningLogAPI.Dtos;
using LearningLogAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace LearningLogAPI.Services
{
    public class CourseService : ICourseService
    {
        private readonly CourseInfoContext _context;
        private readonly IMapper _mapper;
        public CourseService(CourseInfoContext context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<IEnumerable<CourseDto>> GetAllCoursesAsync()
        {
            var courses = await _context.Courses.ToListAsync();
            return _mapper.Map<IEnumerable<CourseDto>>(courses);
        }
        public async Task<CourseDto?> GetCourseByIdAsync(int courseid)
        {
            var course = await _context.Courses.FindAsync(courseid);
            return course == null ? null : _mapper.Map<CourseDto>(course);
        }
        public async Task<CourseDto> AddCourseAsync(CourseDto newCourse)
        {
            var courseEntity = _mapper.Map<Course>(newCourse);
            _context.Courses.Add(courseEntity);
            await _context.SaveChangesAsync();
            return _mapper.Map<CourseDto>(courseEntity);
        }
    }
}
