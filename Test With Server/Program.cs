using ICloseToHelp;
using Model;
using System;
using System.Threading.Tasks;
using ViewModel;


namespace Test_With_Server
{
    public class Program
    {


        static async Task Main(string[] args)
        {

            //SELECT ALL+GET__ TEST
            //Console.WriteLine("Hello, World!");
            //MyApi myApi = new MyApi();
            //CityList cl = await myApi.GetAllCities(); // call to the server to get all cities 1
            //if (cl == null)
            //{
            //    Console.WriteLine("Failed to get cities. Check logs or API response.");
            //}
            //else
            //{
            //    foreach (City c in cl) Console.WriteLine(c);
            //}


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

            MyApi myApi2 = new MyApi();

            CityList Citylist; // Used repeatedly to hold fetched cities

            Console.WriteLine("\n🚀 Step 1: Fetch Existing Cities");
            Citylist = await myApi2.GetAllCities();
            if (Citylist == null || !Citylist.Any())
            {
                Console.WriteLine("⚠️ WARNING: City list is empty. Inserting a new city 'Arad'.");
                City newCity = new City { City_Name = "Arad" };
                int cityId = await myApi2.InsertACity(newCity); // Assume this returns the new ID
                Console.WriteLine($"City 'Arad' inserted with ID: {cityId}");
                Citylist = await myApi2.GetAllCities(); // Refetch the list
            }
            City lastCity = Citylist.Last();
            Console.WriteLine($"Using City: {lastCity.City_Name} (ID: {lastCity.Id})");

            //    // --- Status Insert Test ---
            //    Console.WriteLine("\n🚀 Step 2: Insert Status");
            //    Status newStatus = new Status { Description = "In Progress" };
            //    int statusId = await myApi.InsertAStatus(newStatus);
            //    Console.WriteLine($"Status 'In Progress' inserted with ID: {statusId}");

            //    StatusList statuses = await myApi.GetAllStatuses();
            //    Console.WriteLine("Statuses after insert:");
            //    foreach (Status s1 in statuses)
            //        Console.WriteLine($"Description: {s1.Description} | ID: {s1.Id}");

            //    // --- HelpCategory Insert Test ---
            //    Console.WriteLine("\n🚀 Step 3: Insert HelpCategory");
            //    Help_Category newHelpCategory = new Help_Category { Description = "Food Delivery" };
            //    int helpCategoryId = await myApi.InsertAHelpCategory(newHelpCategory);
            //    Console.WriteLine($"HelpCategory 'Food Delivery' inserted with ID: {helpCategoryId}");

            //    Help_CategoryList help_CategoryList = await myApi.GetAllHelpCategories();
            //    Help_Category selectedHelpCategory = help_CategoryList.First(hc => hc.Id == 1); // Assuming 1 exists or use the new ID

            //    Console.WriteLine("HelpCategories after insert:");
            //    foreach (Help_Category hc in help_CategoryList)
            //        Console.WriteLine($"Description: {hc.Description} | ID: {hc.Id}");

            //    // --- Volunteer Insert Test (Requires City and HelpCategory) ---
            //    Console.WriteLine("\n🚀 Step 4: Insert Volunteer");
            //    Volunteer newVolunteer = new Volunteer
            //    {
            //        FirstName = "Ilan",
            //        LastName = "Cohen",
            //        PhoneNumber = "0523666689",
            //        Pass = "677584",
            //        Street = "Rahoven",
            //        StreetNumber = 10,
            //        CityNum = lastCity, // Use fetched City object
            //        StoreOpeningTime = new DateTime(2023, 1, 1, 9, 0, 0),
            //        StoreClosingTime = new DateTime(2023, 1, 1, 17, 0, 0),
            //        JoinDate = DateTime.Now,
            //        Location_X = 34.7818,
            //        Location_Y = 32.0853,
            //        Help_Category = selectedHelpCategory // Use fetched HelpCategory object
            //    };
            //    int volunteerId = await myApi.InsertAVolunteer(newVolunteer);
            //    Console.WriteLine($"Volunteer 'Ilan Cohen' inserted with ID: {volunteerId}");

            //    VolunteerList volunteers = await myApi.GetAllVolunteers();
            //    Volunteer selectedVolunteer = volunteers.First();
            //    Console.WriteLine("Volunteers after insert:");
            //    foreach (Volunteer v in volunteers)
            //        Console.WriteLine($"Name: {v.FirstName} | ID: {v.Id}");

            //    // --- Person Insert Test (Requires City) ---
            //    Console.WriteLine("\n🚀 Step 5: Insert Person");
            //    Person newPerson = new Person
            //    {
            //        FirstName = "David",
            //        LastName = "Levi",
            //        PhoneNumber = "0521234567",
            //        Street = "Herzl",
            //        CityNum = lastCity, // Use fetched City object
            //        StreetNumber = 5,
            //        Pass = "123456"
            //    };
            //    int personId = await myApi.InsertAPerson(newPerson);
            //    Console.WriteLine($"Person 'David Levi' inserted with ID: {personId}");

            //    PersonList personList = await myApi.GetAllPersons();
            //    Console.WriteLine("Persons after insert:");
            //    foreach (Person p in personList)
            //        Console.WriteLine($"Name: {p.FirstName} | ID: {p.Id}");

            //    // --- PasserBy Insert Test (Requires City and HelpCategory) ---
            //    Console.WriteLine("\n🚀 Step 6: Insert PasserBy");
            //    PasserBy newPasserBy = new PasserBy
            //    {
            //        FirstName = "Sara",
            //        LastName = "Levi",
            //        PhoneNumber = "0529876543",
            //        Street = "Ben Gurion",
            //        CityNum = lastCity, // Use fetched City object
            //        StreetNumber = 12,
            //        Pass = "654321",
            //        Help_Category = selectedHelpCategory, // Use fetched HelpCategory object
            //        JoinDate = DateTime.Now
            //    };
            //    int passerById = await myApi.InsertAPasserBy(newPasserBy);
            //    Console.WriteLine($"PasserBy 'Sara Levi' inserted with ID: {passerById}");

            //    PasserByList passerByList = await myApi.GetAllPasserBys();
            //    PasserBy selectedPasserBy = passerByList.First(p => p.Id == passerById);
            //    Console.WriteLine("PasserBys after insert:");
            //    foreach (PasserBy p in passerByList)
            //        Console.WriteLine($"Name: {p.FirstName} | ID: {p.Id}");

            //    // --- Report Insert Test (Requires PasserBy, City, HelpCategory) ---
            //    Console.WriteLine("\n🚀 Step 7: Insert Report");
            //    Report newReport = new Report
            //    {
            //        Description = "Need help with groceries",
            //        Location_X = 34.7818,
            //        Location_Y = 32.0853,
            //        Update_Time = DateTime.Now,
            //        PasserBy_ID = selectedPasserBy.Id, // Use the ID from the fetched object
            //        HCategory = selectedHelpCategory,
            //        City_Num = lastCity,
            //        Photo_Optinal = "photo1.jpg"
            //    };
            //    int reportId = await myApi.InsertAReport(newReport);
            //    Console.WriteLine($"Report inserted with ID: {reportId}");

            //    ReportList reportList = await myApi.GetAllReports();
            //    Report selectedReport = reportList.First(r => r.Id == reportId);
            //    Console.WriteLine("Reports after insert:");
            //    foreach (Report r in reportList)
            //        Console.WriteLine($"Description: {r.Description} | ID: {r.Id}");

            //    // --- VolunteerRespond Insert Test (Requires Report, Volunteer, Status) ---
            //    Console.WriteLine("\n🚀 Step 8: Insert VolunteerRespond");
            //    VolunteerRespond newVolunteerRespond = new VolunteerRespond
            //    {
            //        IdReport = selectedReport,
            //        IdVol = selectedVolunteer,
            //        Repsond_status = statuses.First(s => s.Id == statusId) // Use the newly inserted status
            //    };
            //    int vrId = await myApi.InsertAVolunteerRespond(newVolunteerRespond);
            //    Console.WriteLine($"VolunteerRespond inserted with ID: {vrId}");

            //    VolunteerRespondList volunteerRespondList = await myApi.GetAllVolunteerResponds();
            //    Console.WriteLine("VolunteerResponds after insert:");
            //    foreach (VolunteerRespond vr in volunteerRespondList)
            //        Console.WriteLine($"ID: {vr.Id} | Report ID: {vr.IdReport.Id} | Volunteer ID: {vr.IdVol.Id} | Status: {vr.Repsond_status.Description}");

            //    Console.WriteLine("\n--- API Integration Tests Complete ---");


            //delete test

            MyApi myApi3 = new MyApi();


            Console.WriteLine("test delete");
            // 1. Delete VolunteerRespond
            Console.WriteLine("\n🚀 Step 1: Delete VolunteerRespond");
            VolunteerRespondList volunteerRespondList = await myApi3.GetAllVolunteerResponds();
            if (volunteerRespondList != null && volunteerRespondList.Any())
            {
                VolunteerRespond vrToDelete = volunteerRespondList.Last();
                int vry = await myApi3.DeleteAVolunteerRespond(vrToDelete.Id);
                Console.WriteLine($"{vry} VolunteerRespond rows were deleted (ID: {vrToDelete.Id})");

                volunteerRespondList = await myApi3.GetAllVolunteerResponds();
                Console.WriteLine($"VolunteerResponds remaining: {volunteerRespondList.Count}");
            }
            else { Console.WriteLine("No VolunteerResponds to delete."); }


            // 2. Delete Report
            Console.WriteLine("\n🚀 Step 2: Delete Report");
            ReportList reportList = await myApi3.GetAllReports();
            if (reportList != null && reportList.Any())
            {
                Report reportToDelete = reportList.Last();
                int reportRowsAffected = await myApi3.DeleteAReport(reportToDelete.Id);
                Console.WriteLine($"{reportRowsAffected} Report rows were deleted (ID: {reportToDelete.Id})");

                reportList = await myApi3.GetAllReports();
                Console.WriteLine($"Reports remaining: {reportList.Count}");
            }
            else { Console.WriteLine("No Reports to delete."); }


            // 3. Delete Volunteer (Using Last())
            Console.WriteLine("\n🚀 Step 3: Delete Volunteer");
            VolunteerList volunteerList = await myApi3.GetAllVolunteers();
            if (volunteerList != null && volunteerList.Any())
            {
                Volunteer volunteerToDelete = volunteerList.Last();
                int vy = await myApi3.DeleteAVolunteer(volunteerToDelete.Id);
                Console.WriteLine($"{vy} Volunteer rows were deleted (ID: {volunteerToDelete.Id})");

                volunteerList = await myApi3.GetAllVolunteers();
                Console.WriteLine($"Volunteers remaining: {volunteerList.Count}");
            }
            else { Console.WriteLine("No Volunteers to delete."); }



            // 4. Delete PasserBy
            Console.WriteLine("\n🚀 Step 4: Delete PasserBy");
            PasserByList passerByList = await myApi3.GetAllPasserBys();
            if (passerByList != null && passerByList.Any())
            {
                PasserBy passerByToDelete = passerByList.Last();
                int passerByRowsAffected = await myApi3.DeleteAPasserBy(passerByToDelete.Id);
                Console.WriteLine($"{passerByRowsAffected} PasserBy rows were deleted (ID: {passerByToDelete.Id})");

                passerByList = await myApi3.GetAllPasserBys();
                Console.WriteLine($"PasserBys remaining: {passerByList.Count}");
            }
            else { Console.WriteLine("No PasserBys to delete."); }


            // 5. Delete Person
            Console.WriteLine("\n🚀 Step 5: Delete Person");
            PersonList personList = await myApi3.GetAllPersons();
            if (personList != null && personList.Any())
            {
                Person personToDelete = personList.Last();
                int personRowsAffected = await myApi2.DeleteAPerson(personToDelete.Id);
                Console.WriteLine($"{personRowsAffected} Person rows were deleted (ID: {personToDelete.Id})");

                personList = await myApi3.GetAllPersons();
                Console.WriteLine($"Persons remaining: {personList.Count}");
            }
            else { Console.WriteLine("No Persons to delete."); }


            // 6. Delete Admin
            Console.WriteLine("\n🚀 Step 6: Delete Admin");
            AdminList alist = await myApi3.GetAllAdmins();
            if (alist != null && alist.Any())
            {
                Admin adminToDelete = alist.Last();
                int ay = await myApi3.DeleteAnAdmin(adminToDelete.Id);
                Console.WriteLine($"{ay} Admin rows were deleted (ID: {adminToDelete.Id})");

                alist = await myApi3.GetAllAdmins();
                Console.WriteLine($"Admins remaining: {alist.Count}");
            }
            else { Console.WriteLine("No Admins to delete."); }


            // 7. Delete HelpCategory
            Console.WriteLine("\n🚀 Step 7: Delete HelpCategory");
            Help_CategoryList help_CategoryList = await myApi3.GetAllHelpCategories();
            if (help_CategoryList != null && help_CategoryList.Any())
            {
                Help_Category help_CategoryToDelete = help_CategoryList.Last();
                int helpCategoryRowsAffected = await myApi3.DeleteAHelpCategory(help_CategoryToDelete.Id);
                Console.WriteLine($"{helpCategoryRowsAffected} HelpCategory rows were deleted (ID: {help_CategoryToDelete.Id})");

                help_CategoryList = await myApi3.GetAllHelpCategories();
                Console.WriteLine($"HelpCategories remaining: {help_CategoryList.Count}");
            }
            else { Console.WriteLine("No HelpCategories to delete."); }


            // 8. Delete Status
            Console.WriteLine("\n🚀 Step 8: Delete Status");
            StatusList statuses = await myApi3.GetAllStatuses();
            if (statuses != null && statuses.Any())
            {
                Status statusToDelete = statuses.Last();
                int sy = await myApi3.DeleteAStatus(statusToDelete.Id);
                Console.WriteLine($"{sy} Status rows were deleted (ID: {statusToDelete.Id})");

                statuses = await myApi3.GetAllStatuses();
                Console.WriteLine($"Statuses remaining: {statuses.Count}");
            }
            else { Console.WriteLine("No Statuses to delete."); }


            // 9. Delete City (Must be last, as many entities depend on it)
            Console.WriteLine("\n🚀 Step 9: Delete City");
            CityList cities = await myApi3.GetAllCities();
            if (cities != null && cities.Any())
            {
                City cityToDelete = cities.Last();
                int cy = await myApi3.DeleteACity(cityToDelete.Id);
                Console.WriteLine($"{cy} City rows were deleted (ID: {cityToDelete.Id})");

                cities = await myApi3.GetAllCities();
                Console.WriteLine($"Cities remaining: {cities.Count}");
            }
            else { Console.WriteLine("No Cities to delete."); }

            Console.WriteLine("\n--- API DELETE Integration Tests Complete ---");
        }

        //UPDATE TEST

        // 1. Update City ////fix here!!


        //              CityList cities7 = await myApi.GetAllCitiesAsync();
        //              if (cities7 != null && cities7.Any())
        //          {
        //           City cityToUpdate = cities7.Last();
        //        string originalName = cityToUpdate.City_Name;
        //        cityToUpdate.City_Name = "Updated City Name";

        //        int cy7 = await myApi.UpdateCityAsync(cityToUpdate);
        //        Console.WriteLine($"{cy7} rows were updated (City ID: {cityToUpdate.Id})");

        //        cities7 = await myApi.GetAllCitiesAsync();
        //        Console.WriteLine($"City Name: {originalName} -> {cities7.Last().City_Name}");
        //    }
        //    else { Console.WriteLine("No Cities found to update."); }


        //// 2. Update Status
        //Console.WriteLine("\n--- Update Status ---");
        //StatusList sl = await myApi.GetAllStatusesAsync();
        //if (sl != null && sl.Any())
        //{
        //    Status statusToUpdate = sl.Last();
        //    string originalDesc = statusToUpdate.Description;
        //    statusToUpdate.Description = "Updated Status Description";

        //    int sy1 = await myApi.UpdateStatusAsync(statusToUpdate);
        //    Console.WriteLine($"{sy1} rows were updated (Status ID: {statusToUpdate.Id})");

        //    sl = await myApi.GetAllStatusesAsync();
        //    Console.WriteLine($"Status Description: {originalDesc} -> {sl.Last().Description}");
        //}
        //else { Console.WriteLine("No Statuses found to update."); }


        //// 3. Update HelpCategory
        //Console.WriteLine("\n--- Update HelpCategory ---");
        //Help_CategoryList help_CategoryList2 = await myApi.GetAllHelpCategoriesAsync();
        //if (help_CategoryList2 != null && help_CategoryList2.Any())
        //{
        //    Help_Category help_CategoryToUpdate = help_CategoryList2.Last();
        //    string originalDesc = help_CategoryToUpdate.Description;
        //    help_CategoryToUpdate.Description = "Updated Help Category Description";

        //    int helpCategoryRowsAffected4 = await myApi.UpdateHelpCategoryAsync(help_CategoryToUpdate);
        //    Console.WriteLine($"{helpCategoryRowsAffected4} rows were updated (HC ID: {help_CategoryToUpdate.Id})");

        //    help_CategoryList2 = await myApi.GetAllHelpCategoriesAsync();
        //    Console.WriteLine($"HC Description: {originalDesc} -> {help_CategoryList2.Last().Description}");
        //}
        //else { Console.WriteLine("No HelpCategories found to update."); }


        //// 4. Update Admin
        //Console.WriteLine("\n--- Update Admin ---");
        //AdminList alist = await myApi.GetAllAdminsAsync();
        //if (alist != null && alist.Any())
        //{
        //    Admin adminToUpdate = alist.Last();
        //    string originalName = adminToUpdate.FirstName;
        //    adminToUpdate.FirstName = "UpdatedFirstName";

        //    int ay = await myApi.UpdateAdminAsync(adminToUpdate);
        //    Console.WriteLine($"{ay} rows were updated (Admin ID: {adminToUpdate.Id})");

        //    alist = await myApi.GetAllAdminsAsync();
        //    Console.WriteLine($"Admin Name: {originalName} -> {alist.Last().FirstName}");
        //}
        //else { Console.WriteLine("No Admins found to update."); }


        //// 5. Update Volunteer
        //Console.WriteLine("\n--- Update Volunteer ---");
        //VolunteerList volunteerList1 = await myApi.GetAllVolunteersAsync();
        //if (volunteerList1 != null && volunteerList1.Any())
        //{
        //    Volunteer volunteerToUpdate = volunteerList1.Last();
        //    string originalName = volunteerToUpdate.FirstName;
        //    volunteerToUpdate.FirstName = "UpdatedFirstName";

        //    int vy1 = await myApi.UpdateVolunteerAsync(volunteerToUpdate);
        //    Console.WriteLine($"{vy1} rows were updated (Volunteer ID: {volunteerToUpdate.Id})");

        //    volunteerList1 = await myApi.GetAllVolunteersAsync();
        //    Console.WriteLine($"Volunteer Name: {originalName} -> {volunteerList1.Last().FirstName}");
        //}
        //else { Console.WriteLine("No Volunteers found to update."); }


        //// 6. Update Person
        //Console.WriteLine("\n--- Update Person ---");
        //PersonList personList = await myApi.GetAllPersonsAsync();
        //if (personList != null && personList.Any())
        //{
        //    Person personToUpdate = personList.Last();
        //    string originalName = personToUpdate.FirstName;
        //    personToUpdate.FirstName = "UpdatedFirstName";

        //    int personRowsAffected5 = await myApi.UpdatePersonAsync(personToUpdate);
        //    Console.WriteLine($"{personRowsAffected5} rows were updated (Person ID: {personToUpdate.Id})");

        //    personList = await myApi.GetAllPersonsAsync();
        //    Console.WriteLine($"Person Name: {originalName} -> {personList.Last().FirstName}");
        //}
        //else { Console.WriteLine("No Persons found to update."); }


        //// 7. Update PasserBy
        //Console.WriteLine("\n--- Update PasserBy (1) ---");
        //PasserByList passerByList = await myApi.GetAllPasserBysAsync();
        //if (passerByList != null && passerByList.Any())
        //{
        //    PasserBy passerByToUpdate = passerByList.Last();
        //    string originalName = passerByToUpdate.FirstName;
        //    passerByToUpdate.FirstName = "UpdatedFirstName";

        //    int passerByRowsAffected3 = await myApi.UpdatePasserByAsync(passerByToUpdate);
        //    Console.WriteLine($"{passerByRowsAffected3} rows were updated (PasserBy ID: {passerByToUpdate.Id})");

        //    passerByList = await myApi.GetAllPasserBysAsync();
        //    Console.WriteLine($"PasserBy Name: {originalName} -> {passerByList.Last().FirstName}");
        //}
        //else { Console.WriteLine("No PasserBys found to update."); }


        //// 8. Update Report
        //Console.WriteLine("\n--- Update Report ---");
        //ReportList reportList = await myApi.GetAllReportsAsync();
        //if (reportList != null && reportList.Any())
        //{
        //    Report reportToUpdate = reportList.Last();
        //    string originalDesc = reportToUpdate.Description;
        //    reportToUpdate.Description = "Updated Report Description";

        //    int reportRowsAffected2 = await myApi.UpdateReportAsync(reportToUpdate);
        //    Console.WriteLine($"{reportRowsAffected2} rows were updated (Report ID: {reportToUpdate.Id})");

        //    reportList = await myApi.GetAllReportsAsync();
        //    Console.WriteLine($"Report Description: {originalDesc} -> {reportList.Last().Description}");
        //}
        //else { Console.WriteLine("No Reports found to update."); }


        //// 9. Update VolunteerRespond
        //Console.WriteLine("\n--- Update VolunteerRespond ---");
        //VolunteerRespondList volunteerRespondList1 = await myApi.GetAllVolunteerRespondsAsync();
        //if (volunteerRespondList1 != null && volunteerRespondList1.Any())
        //{
        //    VolunteerRespond vrToUpdate = volunteerRespondList1.Last();

        //    // Find a different status for the update test
        //    StatusList currentStatuses = await myApi.GetAllStatusesAsync();
        //    Status newStatus = currentStatuses.Count > 1 ? currentStatuses.ElementAt(currentStatuses.Count - 2) : currentStatuses.First();

        //    string originalStatus = vrToUpdate.Repsond_status.Description;
        //    vrToUpdate.Repsond_status = newStatus;

        //    int vry = await myApi.UpdateVolunteerRespondAsync(vrToUpdate);
        //    Console.WriteLine($"{vry} rows were updated (VR ID: {vrToUpdate.Id})");

        //    volunteerRespondList1 = await myApi.GetAllVolunteerRespondsAsync();
        //    VolunteerRespond updatedVr = volunteerRespondList1.FirstOrDefault(vr => vr.Id == vrToUpdate.Id);

        //    if (updatedVr != null)
        //    {
        //        Console.WriteLine($"VR {updatedVr.Id} Status updated: {originalStatus} -> {updatedVr.Repsond_status.Description}");
        //    }
        //}
        //else { Console.WriteLine("No VolunteerResponds found to update."); }


        //// 10. Update PasserBy (2)
        //Console.WriteLine("\n--- Update PasserBy (2) ---");
        //passerByList = await myApi.GetAllPasserBysAsync();
        //if (passerByList != null && passerByList.Any())
        //{
        //    PasserBy passerByToUpdate = passerByList.Last();
        //    string originalName = passerByToUpdate.FirstName;
        //    passerByToUpdate.FirstName = "AnotherUpdatedFirstName";

        //    int passerByRowsAffected = await myApi.UpdatePasserByAsync(passerByToUpdate);
        //    Console.WriteLine($"{passerByRowsAffected} rows were updated (PasserBy ID: {passerByToUpdate.Id})");

        //    passerByList = await myApi.GetAllPasserBysAsync();
        //    Console.WriteLine($"PasserBy Name: {originalName} -> {passerByList.Last().FirstName}");
        //}
        //else { Console.WriteLine("No PasserBys found to update."); }

    }
}
    



    
    

