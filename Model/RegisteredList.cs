using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RegisteredList : List<Registered>
    {
        public RegisteredList() { }
        public RegisteredList(IEnumerable<Registered> list) : base(list) { }
        public RegisteredList(IEnumerable<BaseEntity> list) : base(list.Cast<Registered>().ToList()) { }
       
    }
}
