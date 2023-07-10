using AutoMapper;
using Practice.Models.Models;
using Practice.Models.ModelsDto.StudentDtos;
using Practice.Models.ModelsDto.TeacherDtos;

namespace Practice
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<StudentAddDto, Student>();
            CreateMap<Student, StudentGetDto>();
            CreateMap<StudentUpdateDto, Student>();
            CreateMap<TeacherSignInDto, Teacher>();
            CreateMap<TeacherSignUpDto, Teacher>();
            CreateMap<Teacher, TeacherGetDto>()
                .ForMember(t => t.Students, options => options.MapFrom(t => t.Students));
        }
    }
}
