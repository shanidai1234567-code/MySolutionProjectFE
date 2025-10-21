using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PasserBy:Person
    {
        private Help_Category help_Category;
        private DateTime joinDate;

       
        public DateTime JoinDate { get => joinDate; set => joinDate = value; }
        public Help_Category Help_Category { get => help_Category; set => help_Category = value; }

        public override string ToString()
        {
            return $"chose to help in: {help_Category}, Start Date: {joinDate.ToShortDateString()}";
        }
    }
}
