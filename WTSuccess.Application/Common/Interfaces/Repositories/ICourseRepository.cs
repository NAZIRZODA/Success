using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTSuccess.Domain.Models;

namespace WTSuccess.Application.Common.Interfaces.Repositories
{
    public interface ICourseRepository : IRepository<Course>
    {
        public void AddChapter(Course course);
    }
}
