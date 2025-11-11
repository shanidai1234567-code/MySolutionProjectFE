using Model;
using ViewModel;
using System;
using System.Collections.Generic;

namespace Test1
{
    public class Program
    {
      
        static void Main(string[] args)
        {



            VolunteerRespondDB VR = new();
            VolunteerRespondList VList = VR.SelectAll();
            //foreach (VolunteerRespond vr in VList)
            //{
            //    Console.WriteLine($"VolunteerRespond: {vr.IdVol.Id}");
            //    Console.WriteLine($"Report ID: {vr.IdReport.Id}");
            //    Console.WriteLine($"Status: {vr.Repsond_status.Id}");
            //    Console.WriteLine("-----------------------------------");

            //}

            VolunteerRespond volunteerRespondtoupdate = VList[0];
            volunteerRespondtoupdate.Repsond_status = new Status { Id = 2 }; // Update status to ID 2
            VR.Update(volunteerRespondtoupdate);
            VR.SaveChanges();
            Console.WriteLine("After Update:");
            VList = VR.SelectAll();
            foreach (VolunteerRespond vr in VList)
            {
                Console.WriteLine($"VolunteerRespond: {vr.IdVol.Id}");
                Console.WriteLine($"Report ID: {vr.IdReport.Id}");
                Console.WriteLine($"Status: {vr.Repsond_status.Id}");
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
