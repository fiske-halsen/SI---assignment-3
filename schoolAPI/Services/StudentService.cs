using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using schoolAPI.DTO;
using schoolAPI.Models;
using schoolAPI.Repository;

namespace schoolAPI.Services
{   
    public interface IStudentService
    {
        public Task<bool> CreateStudent(StudentDTO student);
        public Task<bool> UpdateStudent(int id, StudentDTO student);
        public Task<bool> DeleteStudent(int id);
        public Task<StudentDTO> FindStudent(int id);
    }
    public class StudentService : IStudentService
    {
        
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<bool> CreateStudent(StudentDTO student)
        {
            try
            {
                return await _studentRepository.CreateStudent(new Student
                {
                    Name = student.Name
                ,
                    Email = student.Email
                }
            );
                
            }
            catch (Exception)
            {
                return false;
            }
            
            
        }

        public async Task<bool> DeleteStudent(int id)
        {
            return await _studentRepository.DeleteStudent(id);
        }

        public async Task<StudentDTO> FindStudent(int id)
        {
            try
            {
                Student student = await _studentRepository.FindStudent(id);
                return  new StudentDTO { Name= student.Name, Email = student.Email };
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public async Task<bool> UpdateStudent(int id, StudentDTO student)
        {
            try
            {
                return await _studentRepository.UpdateStudent(id, new Student { Name = student.Name, Email = student.Email });
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
