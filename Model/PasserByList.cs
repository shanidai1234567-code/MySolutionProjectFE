using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PasserByList : List<PasserBy>
    {
        public PasserByList() { }
        public PasserByList(IEnumerable<PasserBy> list) : base(list) { }
        public PasserByList(IEnumerable<BaseEntity> list) : base(list.Cast<PasserBy>().ToList()) { }
    }
}
