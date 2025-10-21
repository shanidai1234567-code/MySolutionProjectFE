using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class VolunteerList : List<Volunteer>
    {
        public VolunteerList() { }
        public VolunteerList(IEnumerable<Volunteer> list) : base(list) { }
        public VolunteerList(IEnumerable<BaseEntity> list) : base(list.Cast<Volunteer>().ToList()) { }
       
    }
}
