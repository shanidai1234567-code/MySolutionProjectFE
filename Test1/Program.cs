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
            //    Console.WriteLine(c.FirstName);

            VolunteerDB V = new();
            VolunteerList vList = V.SelectAll();
            foreach (Volunteer c in vList)
            {
                Console.WriteLine($"{c.Id} | {c.FirstName} {c.LastName} | Help: {c.Help_Category} | Opens: {c.StoreOpeningTime:t} | Closes: {c.StoreClosingTime:t}");


            }




        }
    }
}
