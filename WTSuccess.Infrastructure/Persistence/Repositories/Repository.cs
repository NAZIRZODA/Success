using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTSuccess.Application.Common.Interfaces.Repositories;
using WTSuccess.Domain.Models;
using WTSuccess.Infrastructure.Persistence.DataBases;

namespace WTSuccess.Infrastructure.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        private readonly DbSet<TEntity> _set;
        private readonly EFContext _context;
        public Repository(EFContext context)
        {
            _set = context.Set<TEntity>();
            _context = context;
        }
        public virtual void Add(TEntity entity)
        {
            _set.Add(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            _set.Remove(entity);
        }

        public virtual TEntity FindById(ulong id)
        {
            var foundEntity = _set.Find(id);
            if (foundEntity == null) throw new ArgumentNullException(nameof(TEntity));
            return foundEntity;
        }


        public virtual IQueryable<TEntity> GetAll(int pageList, int pageNumber)
        {
            return _set.Skip<TEntity>(pageList * pageNumber).Take<TEntity>(pageList);
        }

        public virtual int SaveChanges() => _context.SaveChanges();


        public virtual void Update(TEntity entity)
        {
            _set.Update(entity);
        }
    }
}
