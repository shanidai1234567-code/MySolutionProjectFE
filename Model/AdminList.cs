using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class AdminList : List<Admin>
    {
        public AdminList() { }
        public AdminList(IEnumerable<Admin> list) : base(list) { }
        public AdminList(IEnumerable<BaseEntity> list) : base(list.Cast<Admin>().ToList()) { }

    }
    
    }

