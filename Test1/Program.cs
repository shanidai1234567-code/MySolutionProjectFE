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

            //SELECT ALL 

            //VolunteerDB vdb = new VolunteerDB();
            //VolunteerList vlist = vdb.SelectAll();
            //foreach (Volunteer v in vlist)
            //{
            //    Console.WriteLine(v.FirstName);
            //    Console.WriteLine(v.LastName);
            //    Console.WriteLine(v.Id);
            //}
            //Console.WriteLine();

            //    PersonDB pdb = new PersonDB();
            //    PersonList plist = pdb.SelectAll();
            //    foreach (Person p in plist)
            //    {
            //        Console.WriteLine(p.ToString());
            //    }
            //    Console.WriteLine();

            //    AdminDB adb = new AdminDB();
            //    AdminList alist = adb.SelectAll();
            //    foreach (Admin a in alist)
            //    {
            //        Console.WriteLine(a.ToString());
            //    }
            //    Console.WriteLine();

            //    PasserByDB passdb = new PasserByDB();
            //    PasserByList passlist = passdb.SelectAll();
            //    foreach (PasserBy p in passlist)
            //    {
            //        Console.WriteLine(p.ToString());
            //    }

            //    Console.WriteLine();

            //    ReportDB rdb = new ReportDB();
            //    ReportList rlist = rdb.SelectAll();
            //    foreach (Report r in rlist)
            //    {
            //        Console.WriteLine(r.ToString());
            //    }
            //    Console.WriteLine();

            //    VolunteerRespondDB volunteerRespondDB = new VolunteerRespondDB();
            //    VolunteerRespondList volunteerRespondList = volunteerRespondDB.SelectAll();
            //    foreach (VolunteerRespond vr in volunteerRespondList)
            //    {
            //        Console.WriteLine(vr.ToString());
            //    }
            //    Console.WriteLine();

            //    StatusDB statusDB = new StatusDB();
            //    StatusList statusList = statusDB.SelectAll();
            //    foreach (Status s in statusList)
            //    {
            //        Console.WriteLine(s.ToString());
            //    }

            //    Help_CategoryDB help_CategoryDB = new Help_CategoryDB();
            //    Help_CategoryList help_CategoryList = help_CategoryDB.SelectAll();
            //    foreach (Help_Category hc in help_CategoryList)
            //    {
            //        Console.WriteLine(hc.ToString());

            //    }
            //    Console.WriteLine();

            //    CityDB cityDB = new CityDB();
            //    CityList cityList = cityDB.SelectAll();
            //    foreach (City c in cityList)
            //    {
            //        Console.WriteLine(c.ToString());
            //    }
            //    Console.WriteLine();


            //DELETE    ALL

            //Console.WriteLine("\nDelete city");
            //CityDB cdb = new CityDB();
            //CityList cities = new CityList();
            //cities = cdb.SelectAll();
            //City cityToDelete = cities.Last();
            //cdb.Delete(cityToDelete);
            //int cy = cdb.SaveChanges();
            //Console.WriteLine($"{cy} rows were deleted");
            //Console.WriteLine("cities after delete: ");
            //cities = cdb.SelectAll();
            //foreach (City c in cities)
            //    Console.WriteLine(c.City_Name + "  id:" + c.Id );


            //Console.WriteLine("\nDelete status");
            //StatusDB sdb = new StatusDB();
            //StatusList statuses = new StatusList();
            //statuses = sdb.SelectAll();
            //Status statusToDelete = statuses.Last();
            //sdb.Delete(statusToDelete);
            //int sy = sdb.SaveChanges();
            //Console.WriteLine($"{sy} rows were deleted");
            //Console.WriteLine("statuses after delete: ");
            //statuses = sdb.SelectAll();
            //foreach (Status s in statuses)
            //    Console.WriteLine(s.Description + "  id:" + s.Id );

            //Console.WriteLine("\nDelete Volunteer");
            //VolunteerDB volunteerDB = new VolunteerDB();
            //VolunteerList volunteers = new VolunteerList();
            //volunteers = volunteerDB.SelectAll();
            //Volunteer volunteerToDelete = volunteers.Last();
            //volunteerDB.Delete(volunteerToDelete);
            //int vy = volunteerDB.SaveChanges();
            //Console.WriteLine($"{vy} rows were deleted");
            //Console.WriteLine("volunteers after delete: ");
            //volunteers = volunteerDB.SelectAll();
            //foreach (Volunteer v in volunteers)
            //    Console.WriteLine(v.FirstName + "  id:" + v.Id );

            //Console.WriteLine("\nDelete VolunteerRespond");
            //VolunteerRespondDB volunteerRespondDB = new VolunteerRespondDB();
            //VolunteerRespondList volunteerRespondList = new VolunteerRespondList();
            //volunteerRespondList = volunteerRespondDB.SelectAll();
            //VolunteerRespond volunteerRespondToDelete = volunteerRespondList.Last();
            //volunteerRespondDB.Delete(volunteerRespondToDelete);
            //int vry = volunteerRespondDB.SaveChanges();
            //Console.WriteLine($"{vry} rows were deleted");
            //Console.WriteLine("volunteerResponds after delete: ");
            //volunteerRespondList = volunteerRespondDB.SelectAll();
            //foreach (VolunteerRespond vr in volunteerRespondList)
            //    Console.WriteLine("id:" + vr.Id + "  Report id:" + vr.IdReport + " Volunteer id:" + vr.IdVol);

            //Console.WriteLine("\nDelete Admin");
            //AdminDB adb = new AdminDB();
            //AdminList alist = adb.SelectAll();
            //Admin adminToDelete = alist.Last();
            //adb.Delete(adminToDelete);
            //int ay = adb.SaveChanges();
            //Console.WriteLine($"{ay} rows were deleted");
            //Console.WriteLine("admins after delete: ");
            //alist = adb.SelectAll();
            //foreach (Admin a in alist)
            //    Console.WriteLine(a.FirstName + "  id:" + a.Id );


            //Console.WriteLine("\nDelete Volunteer");
            //VolunteerDB volunteerDB = new VolunteerDB();
            //VolunteerList volunteerList = volunteerDB.SelectAll();
            //Volunteer volunteerToDelete = volunteerList[0];
            //volunteerDB.Delete(volunteerToDelete);
            //int rowsAffected = volunteerDB.SaveChanges();
            //Console.WriteLine($"{rowsAffected} rows were deleted");
            //Console.WriteLine("Volunteers after delete: ");
            //volunteerList = volunteerDB.SelectAll();
            //foreach (Volunteer v in volunteerList)
            //    Console.WriteLine(v.FirstName + "  id:" + v.Id);

            //Console.WriteLine("\nDelete Person");
            //PersonDB personDB = new PersonDB();
            //PersonList personList = personDB.SelectAll();
            //Person personToDelete = personList[0];
            //personDB.Delete(personToDelete);
            //int personRowsAffected = personDB.SaveChanges();
            //Console.WriteLine($"{personRowsAffected} rows were deleted");
            //Console.WriteLine("Persons after delete: ");
            //personList = personDB.SelectAll();
            //foreach (Person p in personList)
            //    Console.WriteLine(p.FirstName + "  id:" + p.Id);

            //Console.WriteLine("\nDelete PasserBy");
            //PasserByDB passerByDB = new PasserByDB();
            //PasserByList passerByList = passerByDB.SelectAll();
            //PasserBy passerByToDelete = passerByList[0];
            //passerByDB.Delete(passerByToDelete);
            //int passerByRowsAffected = passerByDB.SaveChanges();
            //Console.WriteLine($"{passerByRowsAffected} rows were deleted");
            //Console.WriteLine("PasserBys after delete: ");
            //passerByList = passerByDB.SelectAll();
            //foreach (PasserBy p in passerByList)
            //    Console.WriteLine(p.FirstName + "  id:" + p.Id);

            //Console.WriteLine("\n delete HelpCategory");
            //Help_CategoryDB help_CategoryDB = new Help_CategoryDB();
            //Help_CategoryList help_CategoryList = help_CategoryDB.SelectAll();
            //Help_Category help_CategoryToDelete = help_CategoryList[0];
            //help_CategoryDB.Delete(help_CategoryToDelete);
            //int helpCategoryRowsAffected = help_CategoryDB.SaveChanges();
            //Console.WriteLine($"{helpCategoryRowsAffected} rows were deleted");
            //Console.WriteLine("HelpCategories after delete: ");
            //help_CategoryList = help_CategoryDB.SelectAll();
            //foreach (Help_Category hc in help_CategoryList)
            //    Console.WriteLine(hc.Description + "  id:" + hc.Id);

            // Console.WriteLine("\n delete Report");
            //ReportDB reportDB = new ReportDB();
            //ReportList reportList = reportDB.SelectAll();
            //Report reportToDelete = reportList[0];
            //reportDB.Delete(reportToDelete);
            //int reportRowsAffected = reportDB.SaveChanges();
            //Console.WriteLine($"{reportRowsAffected} rows were deleted");
            //Console.WriteLine("Reports after delete: ");
            //reportList = reportDB.SelectAll();
            //foreach (Report r in reportList)
            //    Console.WriteLine(r.Description + "  id:" + r.Id);



            //INSERT ALL


            //Console.WriteLine("\nInsert City");
            //CityDB cdb = new CityDB();
            //City newCity = new City
            //{
            //    City_Name = "Kiryat Ekron"
            //};
            //cdb.Insert(newCity);
            //int cy = cdb.SaveChanges();
            //Console.WriteLine($"{cy} rows were inserted");
            //Console.WriteLine("cities after insert: ");
            //CityList cities = cdb.SelectAll();
            //foreach (City c in cities)
            //    Console.WriteLine(c.City_Name + "  id:" + c.Id);


            //Console.WriteLine("\nInsert Status");
            //StatusDB sdb = new StatusDB();
            //Status newStatus = new Status
            //{
            //    Description = "In Progress"
            //};
            //sdb.Insert(newStatus);
            //int sy = sdb.SaveChanges();
            //Console.WriteLine($"{sy} rows were inserted");
            //Console.WriteLine("statuses after insert: ");
            //StatusList statuses = sdb.SelectAll();
            //foreach (Status s in statuses)
            //    Console.WriteLine(s.Description + "  id:" + s.Id );
            //Console.WriteLine("\nInsert Volunteer");

            Console.WriteLine("\nInsert Volunteer");
            VolunteerDB volunteerDB = new VolunteerDB();
            CityDB cityDB = new CityDB();
            CityList Citylist = cityDB.SelectAll();

            Volunteer newVolunteer = new Volunteer
            {
                FirstName = "Ilan",
                LastName = "Cohen",
                PhoneNumber = "0523666689",
                Pass = "677584",
                Street = "Rahoven",
                StreetNumber = 10,
                CityNum = Citylist.Last(),
                StoreOpeningTime = new DateTime(2023, 1, 1, 9, 0, 0),
                StoreClosingTime = new DateTime(2023, 1, 1, 17, 0, 0),
                JoinDate = DateTime.Now,
                Location_X = 34.7818,
                Location_Y = 32.0853,
                Help_Category = Help_CategoryDB.SelectById(1)

            };
            volunteerDB.Insert(newVolunteer);
            int vy = volunteerDB.SaveChanges();
            Console.WriteLine($"{vy} rows were inserted");
            Console.WriteLine("volunteers after insert: ");
            VolunteerList volunteers = volunteerDB.SelectAll();
             foreach (Volunteer v in volunteers)
                 Console.WriteLine(v.FirstName + "  id:" + v.Id );


        }
    }
}
