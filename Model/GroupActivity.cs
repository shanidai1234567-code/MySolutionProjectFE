using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GroupActivity:BaseEntity
    {
        private string nameOfTheGroupActivity;

        public string NameOfTheGroupActivity { get => nameOfTheGroupActivity; set => nameOfTheGroupActivity = value; }

        public override string ToString()
        {
            return $"Group Activity: {nameOfTheGroupActivity}";
        }
    }
}
