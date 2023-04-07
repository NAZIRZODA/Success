using Microsoft.AspNetCore.Mvc;
using WTSuccess.Application.Common.Interfaces;
using WTSuccess.Application.Requests.CourseRequests;
using WTSuccess.Application.Responses.CourseRespnses;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WTSuccess.API.Controllers
{
    [Route("Course/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<CourseResponseModel> Get(int pageList, int pageNumber)
        {
            return _courseService.GetAll(pageList, pageNumber);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public CourseResponseModel Get(ulong id)
        {
            return _courseService.Get(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] CreateCourseRequestModel course)
        {
            _courseService.Add(course);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(ulong id, [FromBody] UpdateCourseRequestModel course)
        {
            _courseService.Update(id, course);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(ulong id)
        {
            _courseService.Delete(id);
        }
    }
}
