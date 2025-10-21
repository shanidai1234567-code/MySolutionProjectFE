using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Help_Category:BaseEntity
    {
        private string Description;

        public string NameOfTheHelp_Category { get => Description; set => Description = value; }

        public override string ToString()
        {
            return $"Group Activity: {Description}";
        }
    }
}
