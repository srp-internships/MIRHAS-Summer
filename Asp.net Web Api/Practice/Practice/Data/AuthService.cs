using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Practice.Models.Models;
using Practice.Models.ModelsDto.StudentDtos;
using Practice.Models.ModelsDto.TeacherDtos;
using Practice.Models.Responce;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Practice.Data
{
    public class AuthService : IAuthService
    {
        private PracticeContext context;
        IMapper mapper;
        IConfiguration configuration;
        public AuthService(PracticeContext context, IMapper mapper, IConfiguration configuration)
        {
            this.context = context;
            this.mapper = mapper;
            this.configuration = configuration;
        }

        public async Task<ServiceResponce<string>> SignIn(TeacherSignInDto teacher)
        {
            var responce = new ServiceResponce<string>();
            var t = await TeacherExists(mapper.Map<Teacher>(teacher));
            if (t == null)
            {
                responce.Succes = false;
                responce.Message = "Teacher not found";
            }
            else if (!VerifyPassword(teacher.Password, t.PasswordHash, t.PasswordSalt))
            {
                responce.Succes = false;
                responce.Message = "Wrong password";
            }
            else
            {
                responce.Data = CreateToken(t);
                responce.Message = "Signed in succesfuly";
            }
            return responce;
        }
        public async Task<ServiceResponce<int>> SignUp(TeacherSignUpDto teacher)
        {
            var responce = new ServiceResponce<int>();
            var t = await TeacherExists(mapper.Map<Teacher>(teacher));

            if (t != null)
            {
                responce.Succes = false;
                responce.Message = "Teacher exists in the database";
                return responce;
            }

            var teacher1 = new Teacher();
            teacher1 = mapper.Map<Teacher>(teacher);

            GeneratePassword(teacher.Password, out byte[] passwordHash, out byte[] passwordSalt);
            teacher1.PasswordHash = passwordHash;
            teacher1.PasswordSalt = passwordSalt;

            context.Teachers.Add(teacher1);
            await context.SaveChangesAsync();

            responce.Data = teacher1.Id;
            responce.Message = "User signed up successfuly";

            return responce;
        }
        public async Task<ServiceResponce<List<TeacherGetDto>>> GetAll()
        {
            var responce = new ServiceResponce<List<TeacherGetDto>>();

            var teachers = await context.Teachers.Include(t => t.Students).ToListAsync();
            responce.Data = teachers.Select(t => mapper.Map<TeacherGetDto>(t)).ToList();

            return responce;
        }
        public async Task<Teacher> TeacherExists(Teacher teacher)
        {
            var t = await context.Teachers.FirstOrDefaultAsync(t => t.Name == teacher.Name);
            if (t == null)
            {
                return null;
            }
            else return t;
        }

        private void GeneratePassword(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
        private bool VerifyPassword(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }
        private string CreateToken(Teacher user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Name, user.Name)
            };

            var appSettingsToken = configuration.GetSection("AppSettings:Token").Value;
            if (appSettingsToken is null)
                throw new Exception("AppSettings Token is null!");

            SymmetricSecurityKey key = new SymmetricSecurityKey(System.Text.Encoding.UTF8
                .GetBytes(appSettingsToken));

            SigningCredentials creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
