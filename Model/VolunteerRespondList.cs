using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Collections.ObjectModel;

namespace Model
{
    public class VolunteerRespondList : List<VolunteerRespond>
    {
        public VolunteerRespondList() { }
        public VolunteerRespondList(IEnumerable<VolunteerRespond> list) : base(list) { }
        public VolunteerRespondList(IEnumerable<BaseEntity> list) : base(list.Cast<VolunteerRespond>().ToList()) { }

    }
}
