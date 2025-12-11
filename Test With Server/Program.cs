using ICloseToHelp;
using Model;
using System.Threading.Tasks;
using System;


namespace Test_With_Server
{
    public class Program
    {

 
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MyApi myApi = new MyApi();
            CityList cl = await myApi.GetAllCities(); // call to the server to get all cities 1
            if (cl == null)
            {
                Console.WriteLine("Failed to get cities. Check logs or API response.");
            }
            else
            {
                foreach (City c in cl) Console.WriteLine(c);
            }

            //PersonList pS = await myApi.GetAllPersons(); // call to the server to get all persons 2
            //foreach (Person p in pS)
            //{
            //    Console.WriteLine($"{p}");
            //}

            //AdminList aS = await myApi.GetAllAdmins(); // call to the server to get all admins 3
            //foreach (Admin a in aS)
            //{
            //    Console.WriteLine($"{a}");
            //}

            //Help_CategoryList hCS = await myApi.GetAllHelpCategories(); // call to the server to get all help categories 4
            //foreach (Help_Category hC in hCS)
            //{
            //    Console.WriteLine($"{hC}");
            //}

            //PasserByList pbS = await myApi.GetAllPasserBys(); // call to the server to get all passerbys 5
            //foreach (PasserBy pb in pbS)
            //{
            //    Console.WriteLine($"{pb}");
            //}

            //ReportList rS = await myApi.GetAllReports(); // call to the server to get all reports 6
            //foreach (Report r in rS)
            //{
            //    Console.WriteLine($"{r}");
            //}

            //StatusList sS = await myApi.GetAllStatuses(); // call to the server to get all statuses 7   
            //foreach (Status s in sS)
            //{
            //    Console.WriteLine($"{s}");
            //}

            //VolunteerList vS = await myApi.GetAllVolunteers(); // call to the server to get all volunteers 8
            //foreach (Volunteer v in vS)
            //{
            //    Console.WriteLine($"{v}");
            //}

            //VolunteerRespondList vrS = await myApi.GetAllVolunteerResponds(); // call to the server to get all volunteer responds 9
            //foreach (VolunteerRespond vr in vrS)
            //{
            //    Console.WriteLine($"{vr}");
            //}

            //// insert tests:

            //    MyApi myApi2 = new MyApi();
            //    City newCity = new City   //// Now, let's add a new City to the server
            //    {
            //        City_Name= "Arad",

            //    };

            //    int result = await myApi2.InsertACity(newCity);
            //    Console.WriteLine($"Inserted City with result: {result}");
        }
    }
}
