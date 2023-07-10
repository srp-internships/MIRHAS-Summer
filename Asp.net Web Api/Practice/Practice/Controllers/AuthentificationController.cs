using Microsoft.AspNetCore.Mvc;
using Practice.Data;
using Practice.Models.Models;
using Practice.Models.ModelsDto.TeacherDtos;
using Practice.Models.Responce;

namespace Practice.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class AuthentificationController : ControllerBase
    {
        private IAuthService service;
        public AuthentificationController(IAuthService service)
        {
            this.service = service;
        }
        [HttpPost("SignUp")]
        public async Task<ActionResult<ServiceResponce<int>>> SignUp(TeacherSignUpDto teacher)
        {
            var responce = await service.SignUp(teacher);
            if (responce.Succes)
            {
                return Ok(responce);
            }
            return BadRequest(responce);
        }
        [HttpPost("SignIn")]
        public async Task<ActionResult<ServiceResponce<int>>> SignUp(TeacherSignInDto teacher)
        {
            var responce = await service.SignIn(teacher);
            if (responce.Succes)
            {
                return Ok(responce);
            }
            return BadRequest(responce);
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponce<List<TeacherGetDto>>>> GetAll()
        {
            return Ok(await service.GetAll());
        }

    }
}
