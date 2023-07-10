using Practice.Models.Models;
using Practice.Models.ModelsDto.StudentDtos;

namespace Practice.Models.ModelsDto.TeacherDtos
{
    public class TeacherGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<StudentGetDto>? Students { get; set; }
    }
}
