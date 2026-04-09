using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Report : BaseEntity
    {
        private int passerBy_ID;
        private DateTime update_Time;
        private double location_X;
        private double location_Y;
        private Help_Category hCategory;
        private string description;
        private City city_num;
        private string  photo_optinal;

        public int PasserBy_ID { get => passerBy_ID; set => passerBy_ID = value; }
        public DateTime Update_Time { get => update_Time; set => update_Time = value; }
        public double Location_X { get => location_X; set => location_X = value; }
        public double Location_Y { get => location_Y; set => location_Y = value; }
       
        public string Description { get => description; set => description = value; }
        public string Photo_Optinal { get => photo_optinal; set => photo_optinal = value; }
        public City City_Num { get => city_num; set => city_num = value; }
        public Help_Category HCategory { get => hCategory; set => hCategory = value; }

        public override string ToString()
        {
            return $"PasserBy_ID: {passerBy_ID}, Update_Time:{update_Time}, Location_X:{location_X}, Location_Y: {location_Y}" +
                $"Help_Category: {hCategory}, Description: {description}, Photo_Optinal: {photo_optinal}, City_Num: {city_num}." + base.ToString();
        }
    }
}
