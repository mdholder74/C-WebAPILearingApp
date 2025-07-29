using LearningLogAPI.Dtos;
using LearningLogAPI.Entities;
using AutoMapper;

namespace LearningLogAPI.Profiles
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            // Maps Entity <-> DTO both ways
            CreateMap<Course, CourseDto>().ReverseMap();

        }
    }

}
