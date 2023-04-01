using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTSuccess.Domain.Models
{
    public class Course : EntityBase
    {
        public string Name { get; set; }
        public List<Chapter> Chapters { get; set; }
        public List<Student> Students { get; set; }
    }
}
