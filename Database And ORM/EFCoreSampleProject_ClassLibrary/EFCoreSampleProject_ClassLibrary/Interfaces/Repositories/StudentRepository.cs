using EFCoreSampleProject_ClassLibrary.Data;
using EFCoreSampleProject_ClassLibrary.Models;

namespace EFCoreSampleProject_ClassLibrary.Interfaces.Repositories
{
    internal class StudentRepository : Repository<Student>, IStudentRepository
    {

        public StudentRepository(ProjectContext context) : base(context)
        {

        }

        public IEnumerable<Student> GetTopTenStudents()
        {
            var studnets = context.Students.OrderByDescending(s=>s.GPU).Take(10);
            return studnets;
        }

        public ProjectContext context { get { return new ProjectContext(); } }
    }
}
