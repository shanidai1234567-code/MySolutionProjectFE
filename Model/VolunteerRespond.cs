using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
        public class VolunteerRespond:BaseEntity
    {
        private Volunteer idVol;
        private Report idReport;
        private Status repsond_status;

        public Volunteer IdVol { get => idVol; set => idVol = value; }
        public Report IdReport { get => idReport; set => idReport = value; }
        public Status Repsond_status { get => repsond_status; set => repsond_status = value; }

        public override string ToString()
        {
            return $" Volunteer: {idVol}, Report: {idReport}, Status: {repsond_status}" + base.ToString();
        }
    }
}
