
namespace EFCorePractice.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Des { get; set; }
        public string? Link { get; set; }
        public Author Author { get; set; } = null!;
    }
}
