using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GroupActivityList : List<GroupActivity>
    {
        public GroupActivityList() { }

        public GroupActivityList(IEnumerable<GroupActivity> list) : base(list) { }
        public GroupActivityList(IEnumerable<BaseEntity> list) : base(list.Cast<GroupActivity>().ToList()) { }
    }
}
