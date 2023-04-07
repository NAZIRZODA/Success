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
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private DbSet<Course> _dbSetCourse;
        private readonly EFContext _courseContext;
        public CourseRepository(EFContext context) : base(context)
        {
            _dbSetCourse = context.Set<Course>();
            _courseContext = context;
        }

        public void AddChapter(Course course)
        {
            _dbSetCourse.Update(course);
        }
    }
}
