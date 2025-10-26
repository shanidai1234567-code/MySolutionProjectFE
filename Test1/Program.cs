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

            AdminDB A = new();
            AdminList aList = A.SelectAll();

            foreach (Admin a in aList)
            {
                Console.WriteLine($"ID: {a.Id}");
                Console.WriteLine($"Pass: {a.Admin_password}");
                Console.WriteLine("-----------------------------------");
            }



        }
    }
}
