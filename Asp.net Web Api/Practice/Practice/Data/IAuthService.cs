using Practice.Models.Models;
using Practice.Models.ModelsDto.TeacherDtos;
using Practice.Models.Responce;

namespace Practice.Data
{
    public interface IAuthService
    {
        Task<ServiceResponce<int>> SignUp(TeacherSignUpDto teacher);
        Task<ServiceResponce<string>> SignIn(TeacherSignInDto teacher);
        Task<ServiceResponce<List<TeacherGetDto>>> GetAll();
        Task<Teacher> TeacherExists(Teacher teacher);
    }
}
