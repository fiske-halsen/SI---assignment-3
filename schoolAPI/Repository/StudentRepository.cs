using schoolAPI.Contexts;
using schoolAPI.Models;

namespace schoolAPI.Repository
{
    public interface IStudentRepository
    {
        public Task<bool> CreateStudent(Student student);
        public Task<bool> UpdateStudent(int id, Student student);
        public Task<bool> DeleteStudent(int id);
        public Task<Student> FindStudent(int id);

    }
    public class StudentRepository : IStudentRepository
    {
        private readonly DbApplicationContext _context;
        public StudentRepository(DbApplicationContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateStudent(Student student)
        {
            try
            {
                await _context.Students.AddAsync(student);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;


            }
            
        }

        public async Task<bool> DeleteStudent(int id)
        {
            try
            {
                Student student = await _context.Students.FindAsync(id);
                  _context.Remove(student);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public async Task<Student> FindStudent(int id)
        {
            try
            {
                Student student = await _context.Students.FindAsync(id);
                return student;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                throw;
            }
            
        }

        public async Task<bool> UpdateStudent(int id, Student student)
        {
            try
            {
                
                Student studentToBeUpdated = await _context.Students.FindAsync(id);
                studentToBeUpdated.Name = student.Name;
                studentToBeUpdated.Email = student.Email;
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
    }
}
