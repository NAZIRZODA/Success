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
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private readonly DbSet<Student> _dbsetStudent;
        private readonly EFContext _context;
        public StudentRepository(EFContext context) : base(context)
        {
            _dbsetStudent = context.Set<Student>();
            _context = context;
        }
        public void AddCourse(Student student)
        {
            _dbsetStudent.Update(student);
        }
    }
}
