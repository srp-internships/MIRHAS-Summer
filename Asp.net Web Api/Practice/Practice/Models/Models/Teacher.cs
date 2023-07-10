namespace Practice.Models.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public byte[] PasswordHash { get; set; } = null!;
        public byte[] PasswordSalt { get; set; } = null!;
        public List<Student>? Students { get; set; }
    }
}
