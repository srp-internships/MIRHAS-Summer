using EFCoreSampleProject_ClassLibrary.Data;
using EFCoreSampleProject_ClassLibrary.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSampleProject_ClassLibrary.Interfaces.Work
{
    public class UnitOfWork : IUnitOfWork
    {
        public IStudentRepository Students { get; set; }
        DbContext context;

        public UnitOfWork(ProjectContext context)
        {
            this.context = context;

            Students = new StudentRepository(context);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
