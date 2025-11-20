using Model;
using ViewModel;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Test1
{
    public class Program
    {
      
        static void Main(string[] args)
        {

            CityDB cityDB = new CityDB();
            CityList cities = cityDB.SelectAll();

            PersonDB personDB = new PersonDB();
            //Person person = new Person() { FirstName="zzz", LastName="xxx", CityNum = cities[0], Pass="aaa", PhoneNumber="222222", Street="tnhot ", StreetNumber=99 };
            //personDB.Insert(person);
            //int x=personDB.SaveChanges();
            //Console.WriteLine($"{x} rows inserted");
            Person p1=personDB.SelectAll().Last();
            personDB.Delete(p1);
            int x=personDB.SaveChanges();
            Console.WriteLine($"{x} rows deleted");
            //StatusDB statusDB = new StatusDB();
            //StatusList statuses = statusDB.SelectAll();

            //VolunteerRespondDB VR = new();
            //VolunteerRespondList VList = VR.SelectAll();

            //VolunteerRespond volunteerRespondtoupdate = VList[0];
            //volunteerRespondtoupdate.Repsond_status = statuses[2]; // Update status to ID 2
            //VR.Update(volunteerRespondtoupdate);
            //VR.SaveChanges();

            //Console.WriteLine("After Update:");
            //VList = VR.SelectAll();
            //foreach (VolunteerRespond vr in VList)
            //{
            //    Console.WriteLine($"VolunteerRespond: {vr.IdVol}");
            //    Console.WriteLine($"Report ID: {vr.IdReport}");
            //    Console.WriteLine($"Status: {vr.Repsond_status}");
            //    Console.WriteLine("-----------------------------------");
        }
        
    }
}
