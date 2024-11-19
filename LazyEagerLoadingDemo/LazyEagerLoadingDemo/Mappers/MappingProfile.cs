using AutoMapper;
using LazyEagerLoadingDemo.DTOs;
using LazyEagerLoadingDemo.Models;

namespace LazyEagerLoadingDemo.Mappers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            // Mapping for Student to StudentDto
            CreateMap<Student, StudentDto>()
                .ForMember(dest => dest.Courses, opt => opt.MapFrom(src => src.Courses));

            // Mapping for Course to CourseDto
            CreateMap<Course, CourseDto>();
        }
    }
}
