using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTSuccess.Application.Common.Interfaces;
using WTSuccess.Application.Common.Interfaces.Repositories;
using WTSuccess.Application.Requests;
using WTSuccess.Application.Responses;
using WTSuccess.Domain.Models;

namespace WTSuccess.Application.Services
{
    public abstract class BaseService<TEntity, TResponseModel, TRequestModel> : IBaseService<TEntity, TResponseModel, TRequestModel>
        where TEntity : EntityBase
        where TResponseModel : BaseResponse
        where TRequestModel : BaseRequest
    {
        private readonly IRepository<TEntity> _repository;
        private readonly IMapper _mapper;
        public BaseService(IRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public virtual void Add(TRequestModel request)
        {
            throw new NotImplementedException();
        }

        public virtual bool Delete(ulong id)
        {
            throw new NotImplementedException();
        }

        public virtual TResponseModel Get(ulong id)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<TResponseModel> GetAll(int pageList, int pageNumber)
        {
            throw new NotImplementedException();
        }

        public virtual TResponseModel Update(ulong id, TRequestModel request)
        {
            throw new NotImplementedException();
        }
    }
}
