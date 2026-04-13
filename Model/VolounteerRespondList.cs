using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class VolounteerRespondList : List<VolunteerRespond>
    {
        public VolounteerRespondList() { }
        public VolounteerRespondList(IEnumerable<VolunteerRespond> list) : base(list) { }
        public VolounteerRespondList(IEnumerable<BaseEntity> list) : base(list.Cast<VolunteerRespond>().ToList()) { }

    }
}

