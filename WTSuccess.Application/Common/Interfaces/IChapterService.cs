using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTSuccess.Application.Requests.ChapterRequests;
using WTSuccess.Application.Responses.ChapterRespones;
using WTSuccess.Domain.Models;

namespace WTSuccess.Application.Common.Interfaces
{
    public interface IChapterService : IBaseService<Chapter, ChapterResponseModel, ChapterRequestModel>
    {

    }
}
