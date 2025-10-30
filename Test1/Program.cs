using Model;
using ViewModel;
using System;

namespace Test1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //PersonDB pdb = new();
            //PersonList pList = pdb.SelectAll();
            //foreach (Person c in pList)
            //{
            //    Console.WriteLine(c.FirstName);
            //    Console.Write(c.LastName);
            //    Console.Write(c.Phone_Numer);
            //}


            //VolunteerDB V = new();
            //VolunteerList vList = V.SelectAll();

            //foreach (Volunteer volunteer in vList)
            //{
            //    Console.WriteLine($"ID: {volunteer.Id}");
            //    Console.WriteLine($"Help Category: {volunteer.Help_Category}");
            //    Console.WriteLine($"Location X: {volunteer.Location_X}");
            //    Console.WriteLine($"Location Y: {volunteer.Location_Y}");
            //    Console.WriteLine("-----------------------------------");
            //}

            //PasserByDB P = new();
            //PasserByList pList = P.SelectAll();

            //foreach (PasserBy PasserBy in pList)
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
            //    Console.WriteLine($"Update Time: {r.Update_Time1}");
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

            VolunteerRespondDB VR = new();
            VolunteerRespondList vList = VR.SelectAll();
            foreach (VolunteerRespond R in vList)
            {
                Console.WriteLine($"VolunteerRespond: {R.IdVol.Id}");
                Console.WriteLine($"Report ID: {R.IdReport.Id}");
                Console.WriteLine($"Status: {R.Repsond_status.Id}");
                Console.WriteLine("-----------------------------------");

            }
        }
    }
}
