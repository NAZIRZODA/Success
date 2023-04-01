using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using WTSuccess.Application.Common.Interfaces;
using WTSuccess.Application.Requests.ChapterRequests;
using WTSuccess.Application.Responses.ChapterRespones;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WTSuccess.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChapterController : ControllerBase
    {
        private readonly IChapterService _chapterService;
        public ChapterController(IChapterService chapterService)
        {
            _chapterService = chapterService;
        }
        // GET: api/<ChapterController>
        [HttpGet]
        public IEnumerable<ChapterResponseModel> Get(int pageList, int pageNumber)
        {
            return _chapterService.GetAll(pageList, pageNumber);
        }

        // GET api/<ChapterController>/5
        [HttpGet("{id}")]
        public ChapterResponseModel Get(ulong id)
        {
            return _chapterService.Get(id);
        }

        // POST api/<ChapterController>
        [HttpPost]
        public void Post([FromBody] ChapterRequestModel chapter)
        {
            _chapterService.Add(chapter);
        }

        // PUT api/<ChapterController>/5
        [HttpPut("{id}")]
        public void Put(ulong id, [FromBody] ChapterRequestModel chapter)
        {
            _chapterService.Update(id, chapter);
        }

        // DELETE api/<ChapterController>/5
        [HttpDelete("{id}")]
        public void Delete(ulong id)
        {
            _chapterService.Delete(id);
        }
    }
}
