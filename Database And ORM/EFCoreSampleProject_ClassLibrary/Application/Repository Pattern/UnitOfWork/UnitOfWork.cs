using Application.Repository;
using EFCoreSampleProject_ClassLibrary.Data;
using Microsoft.EntityFrameworkCore;

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
