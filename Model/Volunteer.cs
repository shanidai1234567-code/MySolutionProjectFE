using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Volunteer: Person
    {
        private DateTime storeOpeningTime;
        private DateTime storeClosingTime;
        private DateTime joinDate;
        private double location_X;
        private double location_Y;
        private string help_Category;
        public DateTime StoreOpening { get => StoreOpeningTime; set => StoreOpeningTime = value; }

        public DateTime StoreOpeningTime { get => storeOpeningTime; set => storeOpeningTime = value; }

        public DateTime StoreClosingTime {   get => storeClosingTime;   set => storeClosingTime = value;  }
        public DateTime JoinDate{ get => joinDate; set => joinDate = value;}

        public double Location_X {get => location_X; set => location_X = value; }

        public double Location_Y {get => location_Y; set => location_Y = value; }

        public string HelpCategory{ get => help_Category; set => help_Category = value;}

        public override string ToString()
        {
            return $"storeOpeningTime: {storeOpeningTime},  storeClosingTime: {storeClosingTime},joinDate: {joinDate}, location_X: {location_X}, location_Y: {location_Y}, help_Category: {help_Category}." +base.ToString();
        }
    }
}
