using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTSuccess.Domain.Models;

namespace WTSuccess.Application.Requests.ChapterRequests
{
    public class ChapterRequestModel : BaseRequest
    {
        public string Name { get; set; }
        public List<Chapter> Chapters { get; set; }
        public List<Student> Students { get; set; }
    }
}
