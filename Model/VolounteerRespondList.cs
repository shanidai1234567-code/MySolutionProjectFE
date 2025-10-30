using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class VolunteerRespondList : List<VolounteerRespond>
    {
        public VolunteerRespondList() { }
        public VolunteerRespondList(IEnumerable<VolounteerRespond> list) : base(list) { }
        public VolunteerRespondList(IEnumerable<BaseEntity> list) : base(list.Cast<VolounteerRespond>().ToList()) { }

    }
}

