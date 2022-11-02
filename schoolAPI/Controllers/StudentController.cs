using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using schoolAPI.DTO;
using schoolAPI.Services;

namespace schoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [Route("")]
        [HttpPost]
        public async Task<bool> CreateStudent(StudentDTO studentDTO)
        {
            return await _studentService.CreateStudent(studentDTO);
        }
        [Route("")]
        [HttpGet]
        public async Task <StudentDTO> FindStudent(int id)
        {
            return await _studentService.FindStudent(id);
        }
        [Route("")]
        [HttpDelete]
        public async Task <bool> DeleteStudent (int id)
        {
            return await _studentService.DeleteStudent(id);
        }
        [Route("")]
        [HttpPatch]
        public async Task <bool> UpdateStudent(int id, StudentDTO studentDTO)
        {
            return await _studentService.UpdateStudent(id, studentDTO);
        }
    }
}
