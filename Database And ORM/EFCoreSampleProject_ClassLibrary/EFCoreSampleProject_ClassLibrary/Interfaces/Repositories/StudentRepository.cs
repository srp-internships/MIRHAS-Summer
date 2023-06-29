using EFCoreSampleProject_ClassLibrary.Data;
using EFCoreSampleProject_ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSampleProject_ClassLibrary.Interfaces.Repositories
{
    internal class StudentRepository : Repository<Student>, IStudentRepository
    {

        public StudentRepository(ProjectContext context) : base(context)
        {

        }

        public IEnumerable<Student> GetTopTenStudents()
        {
            var studnets = (from s in context.Students
                            orderby s.GPU descending
                            select s).Take(10);
            return studnets;
        }

        public ProjectContext context { get { return new ProjectContext(); } }
    }
}
