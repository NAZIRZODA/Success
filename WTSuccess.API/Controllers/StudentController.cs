using Microsoft.AspNetCore.Mvc;
using WTSuccess.Application.Common.Interfaces;
using WTSuccess.Application.Requests.StudentRequests;
using WTSuccess.Application.Responses.StudentRespones;
using WTSuccess.Domain.Models;

namespace WTSuccess.API.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("id")]
        public StudentResponseModel GetById(ulong id)
        {
            return _studentService.Get(id);
        }

        [HttpPost]
        public void Add(CreateStudentRequestModel student)
        {
            _studentService.Add(student);
        }

        [HttpPut("id")]
        public void Update(ulong id, StudentRequestModel student)
        {
            _studentService.Update(id, student);
        }

        [HttpDelete("id")]
        public void DeleteById(ulong id)
        {
            _studentService.Delete(id);
        }

        [HttpGet("GetAll")]
        public IEnumerable<StudentResponseModel> GetAll(int pageList, int pageNumber)
        {
            return _studentService.GetAll(pageList, pageNumber);
        }
    }
}
