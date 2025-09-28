using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class InstructorToGroupActivityList: List<InstructorToGroupActivity>
    {
        public InstructorToGroupActivityList(){}
        public InstructorToGroupActivityList(IEnumerable<InstructorToGroupActivity> list) : base(list) { }
        public InstructorToGroupActivityList(IEnumerable<BaseEntity> list) : base(list.Cast<InstructorToGroupActivity>().ToList()) { }
    }
}
