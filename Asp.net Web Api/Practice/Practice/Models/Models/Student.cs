using System.ComponentModel.DataAnnotations;

namespace Practice.Models.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; } = null!;
        public List<Subject>? Subjects { get; set; }
    }
}
