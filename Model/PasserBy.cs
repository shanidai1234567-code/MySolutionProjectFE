using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PasserBy:Person
    {
        private string Help_Category;
        private DateTime JoinDate;

       
        public DateTime StartDate { get => JoinDate; set => JoinDate = value; }
        public string TeachesGroupActivity { get => Help_Category; set => Help_Category = value; }

        public override string ToString()
        {
            return $"chose to help in: {Help_Category}, Start Date: {JoinDate.ToShortDateString()}";
        }
    }
}
