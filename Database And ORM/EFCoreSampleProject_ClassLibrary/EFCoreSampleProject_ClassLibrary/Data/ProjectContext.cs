using EFCoreSampleProject_ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSampleProject_ClassLibrary.Data
{
    public class ProjectContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Intern\\Desktop\\MIRHAS-Summer\\Database And ORM\\EFCoreSampleProject_ClassLibrary\\EFCoreSampleProject_ClassLibrary\\Data\\Database\\SampleProjDB.mdf\";Integrated Security=True");
        }
    }
}
