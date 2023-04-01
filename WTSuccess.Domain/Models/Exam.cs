using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTSuccess.Domain.Models
{
    public class Exam : EntityBase
    {
        public int ExamResult { get; set; }
        public ulong ChapterId { get; set; }
        public ulong StudentId { get; set; }
    }

}
