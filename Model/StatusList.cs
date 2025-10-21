using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StautList : List<Status>
    {
        public StautList() { }
        public StautList(IEnumerable<Status> list) : base(list) { }
        public StautList(IEnumerable<BaseEntity> list) : base(list.Cast<Status>().ToList()) { }
    }
}
