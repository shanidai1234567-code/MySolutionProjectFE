using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
        public class VolounteerRespond:BaseEntity
    {
        private Volunteer idVol;
        private Report idReport;
        private Status status;

        public Volunteer IdVol { get => idVol; set => idVol = value; }
        public Report IdReport { get => idReport; set => idReport = value; }
        public Status Status1 { get => status; set => status = value; }

        public override string ToString()
        {
            return $" Volunteer: {idVol}, Report: {idReport}, Status: {status}";
        }
    }
}
