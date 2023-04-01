using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTSuccess.Domain.Models
{
    public class Chapter : EntityBase
    {
        public List<Topic> Topics { get; set; }
        public Course Course { get; set; }
        public ulong CourseId { get; set; }
    }
}
