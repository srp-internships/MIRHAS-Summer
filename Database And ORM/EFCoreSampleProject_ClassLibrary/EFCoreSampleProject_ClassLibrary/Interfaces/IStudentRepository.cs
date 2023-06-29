using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreSampleProject_ClassLibrary.Models;

namespace EFCoreSampleProject_ClassLibrary.Interfaces
{
    public interface IStudentRepository : IRepository<Student>
    {
        IEnumerable<Student> GetTopTenStudents();
    }
}
