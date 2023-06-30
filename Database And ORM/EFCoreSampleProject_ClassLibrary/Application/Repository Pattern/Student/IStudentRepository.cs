using Domain.Models;

namespace Application.Repository
{
    public interface IStudentRepository : IRepository<Student>
    {
        IEnumerable<Student> GetTopTenStudents();
    }
}
