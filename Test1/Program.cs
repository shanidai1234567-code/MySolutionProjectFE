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

            //PersonDB pdb = new PersonDB();
            //PersonList pList = pdb.SelectAll();

            //Console.WriteLine(pList[1]);


            //Person personToUpdate = pList[1];
            //personToUpdate.FirstName = "Tal";
            //personToUpdate.LastName = "Varsnichkov";
            //personToUpdate.PhoneNumber = "0504762884";
            //personToUpdate.Street = "Tnohot hanoer";
            //personToUpdate.StreetNumber = 9;
            //personToUpdate.Pass = "12345";
            //personToUpdate.CityNum = CityDB.SelectById(4);

            //pdb.Update(personToUpdate);
            //Console.WriteLine($"{pdb.SaveChanges()}");

            //Console.WriteLine("\n=== After Update ===");
            //Person updated = PersonDB.SelectById(personToUpdate.Id);
            //Console.WriteLine(updated);
            //עדכון אנשים והדפסתם 1

            //VolunteerDB V = new VolunteerDB();
            //VolunteerList vList = V.SelectAll();

            //Volunteer vv = vList[0];
            //vv.Help_Category = Help_CategoryDB.SelectById(2);
            //vv.LastName= "Cohen";
            //V.Update(vv);
            //Console.WriteLine($"{V.SaveChanges()}");


           
           //עדכון מתנדבים והדפסתם 2
            //PasserByDB P = new();
            //PasserByList PList = P.SelectAll();

            //foreach (PasserBy PasserBy in PList)
            //{
            //    Console.WriteLine($"ID: {PasserBy.Id}");
            //    Console.WriteLine($"Help Category: {PasserBy.Help_Category}");
            //    Console.WriteLine($"JoinDate: {PasserBy.JoinDate}");
            //    Console.WriteLine("-----------------------------------");
            //}

            //AdminDB A = new();
            //AdminList aList = A.SelectAll();

            //foreach (Admin a in aList)
            //{
            //    Console.WriteLine($"ID: {a.Id}");
            //    Console.WriteLine($"Pass: {a.Admin_password}");
            //    Console.WriteLine("-----------------------------------");
            //}

            //Admin adminToUpdate = aList[0];
            //adminToUpdate.FirstName = "yyyyyy";
            //adminToUpdate.LastName = "yyyyyy";
            //adminToUpdate.PhoneNumber = "yyyyyyyy";
            //adminToUpdate.Street = "yyyyyyyyyy";
            //adminToUpdate.StreetNumber = 2;
            //adminToUpdate.Pass = "yyyyyy";
            //adminToUpdate.Admin_password = "yyyyyy";
            //adminToUpdate.CityNum = CityDB.SelectById(3);
            //A.Update(adminToUpdate);
            //Console.WriteLine($"{A.SaveChanges()}");
            //Console.WriteLine("\n=== After Update ===");
            //Admin updated = AdminDB.SelectById(adminToUpdate.Id);
            //Console.WriteLine(updated);


            //CityDB C = new();
            //CityList cList = C.SelectAll();

            //foreach (City c in cList)
            //{
            //    Console.WriteLine($"ID: {c.Id}");
            //    Console.WriteLine($"City: {c.City_Name}");
            //    Console.WriteLine("-----------------------------------");
            //}

            //Help_CategoryDB H = new();
            //Help_CategoryList hList = H.SelectAll();
            //foreach (Help_Category h in hList)
            //{
            //    Console.WriteLine($"ID: {h.Id}");
            //    Console.WriteLine($"Description: {h.Description}");
            //    Console.WriteLine("-----------------------------------");

            //}

            //ReportDB R = new();
            //ReportList rList = R.SelectAll();
            //foreach (Report r in rList)
            //{
            //    Console.WriteLine($"ID: {r.Id}");
            //    Console.WriteLine($"passer ID: {r.PasserBy_ID}");
            //    Console.WriteLine($"Description: {r.Description}");
            //    Console.WriteLine($"Location x: {r.Location_X}");
            //    Console.WriteLine($"Location y: {r.Location_Y}");
            //    Console.WriteLine($"help in: {r.HCategory}");
            //    Console.WriteLine($"City: {r.City_Num}");
            //    Console.WriteLine($"Update Time: {r.Update_Time}");
            //    Console.WriteLine("-----------------------------------");
            //}

            //StatusDB S = new();
            //StatusList sList = S.SelectAll();
            //foreach (Status s in sList)
            //{
            //    Console.WriteLine($"ID: {s.Id}");
            //    Console.WriteLine($"Description: {s.Description}");
            //    Console.WriteLine("-----------------------------------");
            //}

            //VolunteerRespondDB VR = new();
            //VolunteerRespondList VList = VR.SelectAll();
            //foreach (VolunteerRespond vr in VList)
            //{
            //    Console.WriteLine($"VolunteerRespond: {vr.IdVol.Id}");
            //    Console.WriteLine($"Report ID: {vr.IdReport.Id}");
            //    Console.WriteLine($"Status: {vr.Repsond_status.Id}");
            //    Console.WriteLine("-----------------------------------");

            //}
        }
    }
}
