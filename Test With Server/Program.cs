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

            //select tests:
            //Console.WriteLine("Hello, World!");
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

            PersonList pS = await myApi.GetAllPersons(); // call to the server to get all persons 2
            foreach (Person p in pS)
            {
                Console.WriteLine($"{p}");
            }

            AdminList aS = await myApi.GetAllAdmins(); // call to the server to get all admins 3
            foreach (Admin a in aS)
            {
                Console.WriteLine($"{a}");
            }

            Help_CategoryList hCS = await myApi.GetAllHelpCategories(); // call to the server to get all help categories 4
            foreach (Help_Category hC in hCS)
            {
                Console.WriteLine($"{hC}");
            }

            PasserByList pbS = await myApi.GetAllPasserBys(); // call to the server to get all passerbys 5
            foreach (PasserBy pb in pbS)
            {
                Console.WriteLine($"{pb}");
            }

            ReportList rS = await myApi.GetAllReports(); // call to the server to get all reports 6
            foreach (Report r in rS)
            {
                Console.WriteLine($"{r}");
            }

            StatusList sS = await myApi.GetAllStatuses(); // call to the server to get all statuses 7   
            foreach (Status s in sS)
            {
                Console.WriteLine($"{s}");
            }

            VolunteerList vS = await myApi.GetAllVolunteers(); // call to the server to get all volunteers 8
            foreach (Volunteer v in vS)
            {
                Console.WriteLine($"{v}");
            }

            VolunteerRespondList vrS = await myApi.GetAllVolunteerResponds(); // call to the server to get all volunteer responds 9
            foreach (VolunteerRespond vr in vrS)
            {
                Console.WriteLine($"{vr}");
            }

            //// insert tests:


            //Console.WriteLine("\nInsert City"); // 1
            //City newCity3 = new City { City_Name = "Kiryat Ekron" };
            //int cy = await myApi.InsertACity(newCity3); // Calls PostAsJsonAsync logic
            //Console.WriteLine($"{cy} rows were inserted");

            //Console.WriteLine("cities after insert: ");
            //CityList cities = await myApi.GetAllCities(); // Assuming you have this GetAll method
            //foreach (City c in cities)
            //    Console.WriteLine(c.City_Name + "  id:" + c.Id);


            //// --- Insert Status ---
            //Console.WriteLine("\nInsert Status"); // 2
            //Status newStatus = new Status { Description = "In Progress" };
            //int sy = await myApi.InsertAStatus(newStatus);
            //Console.WriteLine($"{sy} rows were inserted");

            //Console.WriteLine("statuses after insert: ");
            //StatusList statuses = await myApi.GetAllStatuses();
            //foreach (Status s1 in statuses)
            //    Console.WriteLine(s1.Description + "  id:" + s1.Id);


            //// --- Insert Volunteer ---
            //Console.WriteLine("\nInsert Volunteer"); // 3
            //CityList cityList = await myApi.GetAllCities();
            //Help_CategoryList categories = await myApi.GetAllHelpCategories();

            //Volunteer newVolunteer = new Volunteer
            //{
            //    FirstName = "Ilan",
            //    LastName = "Cohen",
            //    PhoneNumber = "0523666689",
            //    Pass = "677584",
            //    Street = "Rahoven",
            //    StreetNumber = 10,
            //    CityNum = cityList.Last(),
            //    StoreOpeningTime = new DateTime(2023, 1, 1, 9, 0, 0),
            //    StoreClosingTime = new DateTime(2023, 1, 1, 17, 0, 0),
            //    JoinDate = DateTime.Now,
            //    Location_X = 34.7818,
            //    Location_Y = 32.0853,
            //    Help_Category = categories.FirstOrDefault(x => x.Id == 1)
            //};
            //int vy = await myApi.InsertAVolunteer(newVolunteer);
            //Console.WriteLine($"{vy} rows were inserted");


            //// --- Insert Person ---
            //Console.WriteLine("\nInsert Person"); // 4
            //Person newPerson = new Person
            //{
            //    FirstName = "David",
            //    LastName = "Levi",
            //    PhoneNumber = "0521234567",
            //    Street = "Herzl",
            //    CityNum = cityList.Last(),
            //    StreetNumber = 5,
            //    Pass = "123456"
            //};
            //int personRowsAffected = await myApi.InsertAPerson(newPerson);
            //Console.WriteLine($"{personRowsAffected} rows were inserted");


            //// --- Insert PasserBy ---
            //Console.WriteLine("\nInsert PasserBy"); // 5
            //PasserBy newPasserBy = new PasserBy
            //{
            //    FirstName = "Sara",
            //    LastName = "Levi",
            //    PhoneNumber = "0529876543",
            //    Street = "Ben Gurion",
            //    CityNum = cityList.Last(),
            //    StreetNumber = 12,
            //    Pass = "654321",
            //    Help_Category = categories.FirstOrDefault(x => x.Id == 2),
            //    JoinDate = DateTime.Now
            //};
            //int passerByRowsAffected = await myApi.InsertAPasserBy(newPasserBy);
            //Console.WriteLine($"{passerByRowsAffected} rows were inserted");


            //// --- Insert Report ---
            //Console.WriteLine("\n insert Report");  // 6
            //PasserByList passers = await myApi.GetAllPasserBys();
            //Report newReport = new Report
            //{
            //    Description = "Need help with groceries",
            //    Location_X = 34.7818,
            //    Location_Y = 32.0853,
            //    Update_Time = DateTime.Now,
            //    PasserBy_ID = passers.FirstOrDefault()?.Id ?? 0,
            //    HCategory = categories.FirstOrDefault(x => x.Id == 1),
            //    City_Num = cityList.Last(),
            //    Photo_Optinal = "photo1.jpg"
            //};
            //int reportRowsAffected6 = await myApi.InsertAReport(newReport);
            //Console.WriteLine($"{reportRowsAffected6} rows were inserted");


            //// --- Volunteer Respond ---
            //Console.WriteLine("\n volunteer Respond");  // 7
            //ReportList reports = await myApi.GetAllReports();
            //VolunteerList volunteers = await myApi.GetAllVolunteers();
            //StatusList statusList = await myApi.GetAllStatuses();

            //VolunteerRespond newVolunteerRespond = new VolunteerRespond
            //{
            //    IdReport = reports.FirstOrDefault(),
            //    IdVol = volunteers.FirstOrDefault(),
            //    Repsond_status = statusList.FirstOrDefault()
            //};
            //int vrRows = await myApi.InsertAVolunteerRespond(newVolunteerRespond);
            //Console.WriteLine($"{vrRows} rows were inserted");

            //Console.WriteLine("\n admin ");  // 8
            //Admin newAdmin = new Admin
            //{
            //    FirstName = "AdminFirst",
            //    LastName = "AdminLast",
            //    PhoneNumber = "0520001111",
            //    Street = "AdminStreet",
            //    CityNum = cityList.Last(),
            //    StreetNumber = 1,
            //    Pass = "adminpass"
            //};
            //int adminRows = await myApi.InsertAnAdmin(newAdmin);
            //Console.WriteLine($"{adminRows} rows were inserted");

            //Console.WriteLine("\n  help category");  //9
            //Help_CategoryList helpCategories = await myApi.GetAllHelpCategories();
            //Help_Category newHelpCategory = new Help_Category
            //{
            //    Description = "Medical Assistance"
            //};
            //int helpCategoryRows = await myApi.InsertAHelpCategory(newHelpCategory);
            //Console.WriteLine($"{helpCategoryRows} rows were inserted");
            //Console.ReadLine();


            // --- Update Tests:



            //// --- Update City --- 1
            //Console.WriteLine("\nUpdate City");
            //CityList cities7 = await myApi.GetAllCities();
            //if (cities7.Any())
            //{
            //    City cityToUpdate = cities7.Last();
            //    cityToUpdate.City_Name = "Updated City Name";
            //    int cy7 = await myApi.UpdateACity(cityToUpdate);
            //    Console.WriteLine($"{cy7} rows were updated");

            //    Console.WriteLine("cities after update: ");
            //    cities7 = await myApi.GetAllCities();
            //    foreach (City c in cities7)
            //        Console.WriteLine(c.City_Name + "  id:" + c.Id);
            //}

            //// --- Update Status ---2
            //Console.WriteLine("\nUpdate Status");
            //StatusList sl = await myApi.GetAllStatuses();
            //if (sl.Any())
            //{
            //    Status statusToUpdate = sl.Last();
            //    statusToUpdate.Description = "Updated Status Description";
            //    int sy1 = await myApi.UpdateAStatus(statusToUpdate);
            //    Console.WriteLine($"{sy1} rows were updated");

            //    Console.WriteLine("statuses after update: ");
            //    sl = await myApi.GetAllStatuses();
            //    foreach (Status st in sl)
            //        Console.WriteLine(st.Description + "  id:" + st.Id);
            //}

            //// --- Update Volunteer ---3
            //Console.WriteLine("\nUpdate Volunteer");
            //VolunteerList volunteerList1 = await myApi.GetAllVolunteers();
            //if (volunteerList1.Any())
            //{
            //    var volunteerToUpdate = volunteerList1.Last();
            //    volunteerToUpdate.FirstName = "UpdatedFirstName";
            //    int vy1 = await myApi.UpdateAVolunteer(volunteerToUpdate);
            //    Console.WriteLine($"{vy1} rows were updated");

            //    Console.WriteLine("volunteers after update: ");
            //    volunteerList1 = await myApi.GetAllVolunteers();
            //    foreach (Volunteer v in volunteerList1)
            //        Console.WriteLine(v.FirstName + "  id:" + v.Id);
            //}

            //// --- Update VolunteerRespond ---4
            //Console.WriteLine("\nUpdate VolunteerRespond");
            //VolunteerRespondList volunteerRespondList1 = await myApi.GetAllVolunteerResponds();
            //if (volunteerRespondList1.Any())
            //{
            //    var vrToUpdate = volunteerRespondList1.Last();
            //    // Assuming you want to update the status of the response
            //    int vry = await myApi.UpdateAVolunteerRespond(vrToUpdate);
            //    Console.WriteLine($"{vry} rows were updated");

            //    Console.WriteLine("volunteerResponds after update: ");
            //    volunteerRespondList1 = await myApi.GetAllVolunteerResponds();
            //    foreach (VolunteerRespond vr in volunteerRespondList1)
            //        Console.WriteLine("id:" + vr.Id + " Report id:" + vr.IdReport?.Id + " Volunteer id:" + vr.IdVol?.Id);
            //}

            //// --- Update Admin ---5
            //Console.WriteLine("\nUpdate Admin");
            //AdminList adminList1 = await myApi.GetAllAdmins();
            //if (adminList1.Any())
            //{
            //    var adminToUpdate = adminList1.Last();
            //    adminToUpdate.FirstName = "UpdatedAdminFirstName";
            //    int ay1 = await myApi.UpdateAnAdmin(adminToUpdate);
            //    Console.WriteLine($"{ay1} rows were updated");
            //    Console.WriteLine("admins after update: ");
            //    adminList1 = await myApi.GetAllAdmins();
            //    foreach (Admin a in adminList1)
            //        Console.WriteLine(a.FirstName + "  id:" + a.Id);

            //}

            //Console.WriteLine("\n update ");


            //delete tests:

            // --- Delete City ---1
            //Console.WriteLine("\nDelete City");
            //CityList cities1 = await myApi.GetAllCities();
            //if (cities1.Any())
            //{
            //    City cityToDelete = cities1.Last();
            //    int cy1 = await myApi.DeleteACity(cityToDelete.Id);
            //    Console.WriteLine($"{cy1} rows were deleted");
            //    Console.WriteLine("cities after delete: ");
            //    cities1 = await myApi.GetAllCities();
            //    foreach (City c in cities1)
            //        Console.WriteLine(c.City_Name + "  id:" + c.Id);

            //}

            //Console.WriteLine("\nDelete Status");
            //// --- Delete Status ---2
            //StatusList statuses1 = await myApi.GetAllStatuses();
            //if (statuses1.Any())
            //{
            //    Status statusToDelete = statuses1.Last();
            //    int sy2 = await myApi.DeleteAStatus(statusToDelete.Id);
            //    Console.WriteLine($"{sy2} rows were deleted");
            //    Console.WriteLine("statuses after delete: ");
            //    statuses1 = await myApi.GetAllStatuses();
            //    foreach (Status s1 in statuses1)
            //        Console.WriteLine(s1.Description + "  id:" + s1.Id);
            //}

            //Console.WriteLine("\nDelete Admin");
            //// --- Delete Admin ---3
            //AdminList admins1 = await myApi.GetAllAdmins();
            //if (admins1.Any())
            //{
            //    Admin adminToDelete = admins1.Last();
            //    int ay2 = await myApi.DeleteAnAdmin(adminToDelete.Id);
            //    Console.WriteLine($"{ay2} rows were deleted");
            //    Console.WriteLine("admins after delete: ");
            //    admins1 = await myApi.GetAllAdmins();
            //    foreach (Admin a in admins1)
            //        Console.WriteLine(a.FirstName + "  id:" + a.Id);
            //}

            //Console.WriteLine("\nDelete PasserBy");
            //// --- Delete PasserBy ---4
            //PasserByList passerBys1 = await myApi.GetAllPasserBys();
            //if (passerBys1.Any())
            //{
            //    PasserBy passerByToDelete = passerBys1.Last();
            //    int pby2 = await myApi.DeleteAPasserBy(passerByToDelete.Id);
            //    Console.WriteLine($"{pby2} rows were deleted");
            //    Console.WriteLine("passerBys after delete: ");
            //    passerBys1 = await myApi.GetAllPasserBys();
            //    foreach (PasserBy pb in passerBys1)
            //        Console.WriteLine(pb.FirstName + "  id:" + pb.Id);
            //}

            //Console.WriteLine("\nDelete Help Category");
            //// --- Delete Help Category ---5
            //Help_CategoryList helpCategories1 = await myApi.GetAllHelpCategories();
            //if (helpCategories1.Any())
            //{
            //    Help_Category helpCategoryToDelete = helpCategories1.Last();
            //    int hcy2 = await myApi.DeleteAHelpCategory(helpCategoryToDelete.Id);
            //    Console.WriteLine($"{hcy2} rows were deleted");
            //    Console.WriteLine("help categories after delete: ");
            //    helpCategories1 = await myApi.GetAllHelpCategories();
            //    foreach (Help_Category hc in helpCategories1)
            //        Console.WriteLine(hc.Description + "  id:" + hc.Id);
            //}

            //Console.WriteLine("\nDelete Volunteer");
            //// --- Delete Volunteer ---6
            //VolunteerList volunteers1 = await myApi.GetAllVolunteers();
            //if (volunteers1.Any())
            //{
            //    Volunteer volunteerToDelete = volunteers1.Last();
            //    int vy2 = await myApi.DeleteAVolunteer(volunteerToDelete.Id);
            //    Console.WriteLine($"{vy2} rows were deleted");
            //    Console.WriteLine("volunteers after delete: ");
            //    volunteers1 = await myApi.GetAllVolunteers();
            //    foreach (Volunteer v in volunteers1)
            //        Console.WriteLine(v.FirstName + "  id:" + v.Id);
            //}

            //Console.WriteLine("\nDelete Person");
            //// --- Delete Person ---7
            //PersonList persons1 = await myApi.GetAllPersons();  //**
            //if (persons1.Any())
            //{
            //    Person personToDelete = persons1.Last();
            //    int py2 = await myApi.DeleteAPerson(personToDelete.Id);
            //    Console.WriteLine($"{py2} rows were deleted");
            //    Console.WriteLine("persons after delete: ");
            //    persons1 = await myApi.GetAllPersons();
            //    foreach (Person p in persons1)
            //        Console.WriteLine(p.FirstName + "  id:" + p.Id);
            //}

            //Console.WriteLine("\nDelete Report");
            //// --- Delete Report ---8
            //ReportList reports1 = await myApi.GetAllReports();
            //if (reports1.Any())
            //{
            //    Report personToDelete = reports1.Last();
            //    int ry2 = await myApi.DeleteAReport(personToDelete.Id);
            //    Console.WriteLine($"{ry2} rows were deleted");
            //    Console.WriteLine("reports after delete: ");
            //    reports1 = await myApi.GetAllReports();
            //    foreach (Report r in reports1)
            //        Console.WriteLine(r.Description + "  id:" + r.Id);
            //}

            //Console.WriteLine("\nDelete Volunteer Respond");
            //// --- Delete Volunteer Respond ---9
            //VolunteerRespondList volunteerResponds1 = await myApi.GetAllVolunteerResponds();
            //if (volunteerResponds1.Any())
            //{
            //    VolunteerRespond vrToDelete = volunteerResponds1.Last();
            //    int vry2 = await myApi.DeleteAVolunteerRespond(vrToDelete.Id);
            //    Console.WriteLine($"{vry2} rows were deleted");
            //    Console.WriteLine("volunteer responds after delete: ");
            //    volunteerResponds1 = await myApi.GetAllVolunteerResponds();
            //    foreach (VolunteerRespond vr in volunteerResponds1)
            //        Console.WriteLine("id:" + vr.Id + " Report id:" + vr.IdReport?.Id + " Volunteer id:" + vr.IdVol?.Id);
            //}

            Console.ReadLine();
            Console.WriteLine("End of tests.");


        }


    }
}
