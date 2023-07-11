using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Practice.Models.ModelsDto.StudentDtos;
using Practice.Models.Responce;
using Practice.Services.StudentServices;

namespace Practice.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        IStudentService service;
        public StudentController(IStudentService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponce<List<StudentGetDto>>>> GetAll()
        {
            return await service.GetAll();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponce<StudentGetDto>>> Get(int id)
        {
            return Ok(await service.GetStudentWithId(id));
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponce<List<StudentGetDto>>>> AddNewStudent(StudentAddDto student)
        {
            return Ok(await service.AddStudent(student));
        }
        [HttpPut]
        public async Task<ActionResult<ServiceResponce<StudentGetDto>>> UpdateStudent(StudentUpdateDto student)
        {
            ServiceResponce responce = await service.UpdateStudent(student);

            if (responce.Succes)
            {
                return Ok(responce);
            }
            else return NotFound(responce);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponce<List<StudentGetDto>>>> RemoveStudent(int id)
        {
            ServiceResponce responce = await service.RemoveStudent(id);

            if (responce.Succes)
            {
                return Ok(responce);
            }
            else return NotFound(responce);
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponce>> AddStudentSubject(AddStudentSubjectDto dto)
        {
            var responce = await service.AddStudentSubjects(dto);
            if (responce.Succes)
            {
                return Ok(responce);
            }
            else return BadRequest(responce);
        }
    }
}
