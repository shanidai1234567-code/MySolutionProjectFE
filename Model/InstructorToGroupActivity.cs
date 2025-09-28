using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
        public class InstructorToGroupActivity:BaseEntity
    {
        private Instructor idInst;
        private GroupActivity idClass;

        public Instructor IdInst { get => idInst; set => idInst = value; }
        public GroupActivity IdClass { get => idClass; set => idClass = value; }

        public override string ToString()
        {
            return $" Instructor: {idInst}, GroupActivity: {idClass}";
        }
    }
}
