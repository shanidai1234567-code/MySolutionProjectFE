using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class City: BaseEntity
    {
        private string city_Name;

        public string City_Name { get => city_Name; set => city_Name = value; }
        public override string ToString()
        {
            return $"City Name: {city_Name}";
        }
    }
}
