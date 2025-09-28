using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Instructor:Person
    {
        private string teachesGroupActivity;
        private DateTime startDate;

       
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public string TeachesGroupActivity { get => teachesGroupActivity; set => teachesGroupActivity = value; }

        public override string ToString()
        {
            return $"Teaches: {teachesGroupActivity}, Start Date: {StartDate.ToShortDateString()}";
        }
    }
}
