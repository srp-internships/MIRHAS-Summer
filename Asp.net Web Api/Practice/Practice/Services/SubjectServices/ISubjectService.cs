using Practice.Models.ModelsDto.SubjectDtos;
using Practice.Models.Responce;

namespace Practice.Services.SubjectServices
{
    public interface ISubjectService
    {
        Task<ServiceResponce<int>> Add(SubjectAddDto subject);
    }
}
