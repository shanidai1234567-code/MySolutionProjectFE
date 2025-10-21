using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Help_CategoryList : List<Help_Category>
    {
        public Help_CategoryList() { }

        public Help_CategoryList(IEnumerable<Help_Category> list) : base(list) { }
        public Help_CategoryList(IEnumerable<BaseEntity> list) : base(list.Cast<Help_Category>().ToList()) { }
    }
}
