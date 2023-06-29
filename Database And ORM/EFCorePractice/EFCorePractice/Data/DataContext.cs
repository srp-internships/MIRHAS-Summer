using EFCorePractice.Configurations;
using EFCorePractice.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCorePractice.Data
{
    public class DataContext : DbContext
    {

        public DataContext()
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Intern\\Desktop\\MIRHAS-Summer\\Database And ORM\\EFCorePractice\\EFCorePractice\\Data\\Database\\EFCoreDatas.mdf\";Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
        }
    }
}
