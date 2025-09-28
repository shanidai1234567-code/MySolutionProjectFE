using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Registered: Person
    {
        private string groupActivity;
        private int missedGA;

      
        public int MissedGA { get => missedGA; set => missedGA = value; }
        public string GroupActivity { get => groupActivity; set => groupActivity = value; }

        public override string ToString()
        {
            return $"GroupActivity: {GroupActivity},  missedGA: {missedGA}"+base.ToString();
        }
    }
}
