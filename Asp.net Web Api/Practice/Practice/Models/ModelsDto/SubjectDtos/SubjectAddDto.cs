using Practice.Models.Models;

namespace Practice.Models.ModelsDto.SubjectDtos
{
    public class SubjectAddDto
    {
        public string? Name { get; set; }
        public Teacher? Teacher { get; set; }
        public List<Student>? Students { get; set; }
    }
}
