using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTSuccess.Domain.Models;

namespace WTSuccess.Application.Requests.ChapterRequests
{
    public abstract class ChapterRequestModel : BaseRequest
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        //Chapter Chapter { get; set; }
        //public ulong CourseId { get; set; }
    }
}
