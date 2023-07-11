using Microsoft.EntityFrameworkCore;
using Practice.Models.Models;

namespace Practice.Data
{
    public class PracticeContext : DbContext
    {
        public PracticeContext(DbContextOptions<PracticeContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=PracticeDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject>().HasData
                (
                new List<Subject>()
                {
                    new Subject() {Id=1,Name="Maths"},
                    new Subject() {Id=2,Name="Chemistry"},
                    new Subject() {Id=3,Name="physics"}
                }
                );
        }

    }
}
