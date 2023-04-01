using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTSuccess.Application.Requests.ChapterRequests;
using WTSuccess.Application.Requests.StudentRequests;
using WTSuccess.Application.Responses.ChapterRespones;
using WTSuccess.Application.Responses.StudentRespones;
using WTSuccess.Domain.Models;
namespace WTSuccess.Application.Common.Interfaces
{
    public interface IStudentService : IBaseService<Student, StudentResponseModel, StudentRequestModel>
    {
    }
}
