using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTSuccess.Domain.Models;

namespace WTSuccess.Application.Common.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {
        TEntity FindById(ulong id);
        IQueryable<TEntity> GetAll(int pageList, int pageNumber);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        int SaveChanges();
    }
}
