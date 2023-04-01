using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTSuccess.Application.Requests;
using WTSuccess.Application.Responses;
using WTSuccess.Domain.Models;

namespace WTSuccess.Application.Common.Interfaces
{
    public interface IBaseService<TEntity, TResponseModel, TRequestModel>
        where TEntity : EntityBase
        where TRequestModel : BaseRequest
        where TResponseModel : BaseResponse
    {
        IEnumerable<TResponseModel> GetAll(int pageList, int pageNumber);
        TResponseModel Get(ulong id);
        void Add(TRequestModel request);
        TResponseModel Update(ulong id, TRequestModel request);
        bool Delete(ulong id);
    }
}
