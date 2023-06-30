using EFCoreSampleProject_ClassLibrary.Models;

namespace EFCoreSampleProject_ClassLibrary.Interfaces
{
    public interface IStudentRepository : IRepository<Student>
    {
        IEnumerable<Student> GetTopTenStudents();
    }
}
