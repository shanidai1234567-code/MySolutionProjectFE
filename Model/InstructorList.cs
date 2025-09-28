using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class InstructorList: List<Instructor>
    {
        public InstructorList() { }
        public InstructorList(IEnumerable<Instructor> list) : base(list) { }
        public InstructorList(IEnumerable<BaseEntity> list) : base(list.Cast<Instructor>().ToList()) { }
    }
}
