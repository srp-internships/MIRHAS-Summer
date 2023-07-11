using Practice.Models.ModelsDto.StudentDtos;
using Practice.Models.Responce;

namespace Practice.Services.StudentServices
{
    public interface IStudentService
    {
        Task<ServiceResponce<List<StudentGetDto>>> GetAll();
        Task<ServiceResponce<StudentGetDto>> GetStudentWithId(int id);
        Task<ServiceResponce> AddStudent(StudentAddDto student);
        Task<ServiceResponce> UpdateStudent(StudentUpdateDto student);
        Task<ServiceResponce> RemoveStudent(int id);
        Task<ServiceResponce> AddStudentSubjects(AddStudentSubjectDto dto);
    }
}
