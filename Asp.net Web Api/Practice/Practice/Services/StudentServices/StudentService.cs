using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Practice.Data;
using Practice.Models.Models;
using Practice.Models.ModelsDto.StudentDtos;
using Practice.Models.Responce;
using System.Security.Claims;

namespace Practice.Services.StudentServices
{
    public class StudentService : IStudentService
    {
        PracticeContext context;
        IMapper mapper;
        IHttpContextAccessor accessor;

        public StudentService(IMapper mapper, PracticeContext context, IHttpContextAccessor accessor)
        {
            this.mapper = mapper;
            this.context = context;
            this.accessor = accessor;
        }

        private int GetTeacherId() => int.Parse(accessor.HttpContext!.User.FindFirstValue(ClaimTypes.NameIdentifier)!);

        public async Task<ServiceResponce> AddStudent(StudentAddDto student)
        {
            var s = mapper.Map<Student>(student);
            s.TeacherId = GetTeacherId();
            await context.Students.AddAsync(s);
            await context.SaveChangesAsync();

            var responce = new ServiceResponce();
            responce.Message = "Student added succesfully";
            return responce;
        }
        public async Task<ServiceResponce<List<StudentGetDto>>> GetAll()
        {
            var responce = new ServiceResponce<List<StudentGetDto>>();

            var students = await context.Students.ToListAsync();
            responce.Data = students.Where(s => s.TeacherId == GetTeacherId()).Select(s => mapper.Map<StudentGetDto>(s)).ToList();

            return responce;
        }
        public async Task<ServiceResponce<StudentGetDto>> GetStudentWithId(int id)
        {
            var responce = new ServiceResponce<StudentGetDto>();

            var teacher = await context.Teachers.Include(t => t.Students).FirstOrDefaultAsync(t => t.Id == GetTeacherId());

            var student = (from s in teacher!.Students
                           where s.Id == id
                           select s).FirstOrDefault();

            responce.Data = mapper.Map<StudentGetDto>(student);

            return responce;
        }
        public async Task<ServiceResponce> RemoveStudent(int id)
        {
            var responce = new ServiceResponce();
            try
            {
                var teacher = await context.Teachers.Include(t => t.Students).FirstOrDefaultAsync(t => t.Id == GetTeacherId());
                var student = (from s in teacher!.Students
                               where s.Id == id
                               select s).First();


                context.Remove(student);
                await context.SaveChangesAsync();

                responce.Message = "Student removed succesfully";
                return responce;
            }
            catch (Exception)
            {
                responce.Succes = false;
                responce.Message = "Student not found";
                return responce;
            }
        }
        public async Task<ServiceResponce> UpdateStudent(StudentUpdateDto student)
        {
            var responce = new ServiceResponce();
            try
            {
                var teacher = await context.Teachers.Include(t => t.Students).FirstAsync(t => t.Id == GetTeacherId());

                var old = (from s in teacher!.Students
                           where s.Id == student.Id
                           select s).First();


                old.Name = student.Name;
                old.Surname = student.Surname;
                old.TeacherId = student.TeacherId;

                await context.SaveChangesAsync();

                responce.Message = "Student updated succesfully";
                return responce;
            }
            catch (Exception)
            {
                responce.Succes = false;
                responce.Message = "Student not found";
                return responce;
            }
        }
        public async Task<ServiceResponce> AddStudentSubjects(AddStudentSubjectDto dto)
        {
            var responce = new ServiceResponce();
            try
            {
                var students = await context.Students.ToListAsync();
                var student = (from s in students
                               where s.Id == dto.StudentId
                               select s).FirstOrDefault();

                if (student is null)
                {
                    responce.Succes = false;
                    responce.Message = "Student not found";
                }
                var subjects = await context.Subjects.ToListAsync();
                var subject = (from s in subjects
                               where s.Id == dto.SubjectId
                               select s).FirstOrDefault();

                if (subject is null)
                {
                    responce.Succes = false;
                    responce.Message = "Subject not found";
                }

                student!.Subjects!.Add(subject!);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                responce.Succes = false;
                responce.Message = ex.Message;
            }
            return responce;
        }
    }
}
