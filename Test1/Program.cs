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
            //    Console.WriteLine(c.City_Name + "  id:" + c.Id);


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
            //    Console.WriteLine(s.Description + "  id:" + s.Id);

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
            //    Console.WriteLine(v.FirstName + "  id:" + v.Id);

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
            //    Console.WriteLine(a.FirstName + "  id:" + a.Id);


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

            //Console.WriteLine("\n delete Report");
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
            //CityDB cdb3 = new CityDB();
            //City newCity3 = new City
            //{
            //    City_Name = "Kiryat Ekron"
            //};
            //cdb3.Insert(newCity3);
            //int cy = cdb3.SaveChanges();
            //Console.WriteLine($"{cy} rows were inserted");
            //Console.WriteLine("cities after insert: ");
            //CityList cities = cdb3.SelectAll();
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
            //foreach (Status s1 in statuses)
            //    Console.WriteLine(s1.Description + "  id:" + s1.Id);


            //Console.WriteLine("\nInsert Volunteer");
            //VolunteerDB volunteerDB = new VolunteerDB();
            //CityDB cityDB = new CityDB();
            //CityList Citylist = cityDB.SelectAll();

            //Volunteer newVolunteer = new Volunteer
            //{
            //    FirstName = "Ilan",
            //    LastName = "Cohen",
            //    PhoneNumber = "0523666689",
            //    Pass = "677584",
            //    Street = "Rahoven",
            //    StreetNumber = 10,
            //    CityNum = Citylist.Last(),
            //    StoreOpeningTime = new DateTime(2023, 1, 1, 9, 0, 0),
            //    StoreClosingTime = new DateTime(2023, 1, 1, 17, 0, 0),
            //    JoinDate = DateTime.Now,
            //    Location_X = 34.7818,
            //    Location_Y = 32.0853,
            //    Help_Category = Help_CategoryDB.SelectById(1)

            //};
            //volunteerDB.Insert(newVolunteer);
            //int vy = volunteerDB.SaveChanges();
            //Console.WriteLine($"{vy} rows were inserted");
            //Console.WriteLine("volunteers after insert: ");
            //VolunteerList volunteers = volunteerDB.SelectAll();
            //foreach (Volunteer v in volunteers)
            //    Console.WriteLine(v.FirstName + "  id:" + v.Id);


            //Console.WriteLine("\nInsert Person");
            //PersonDB personDB5 = new PersonDB();
            //CityDB cityDB5 = new CityDB();
            //CityList Citylist5 = cityDB5.SelectAll();
            //Person newPerson = new Person
            //{
            //    FirstName = "David",
            //    LastName = "Levi",
            //    PhoneNumber = "0521234567",
            //    Street = "Herzl",
            //    CityNum = Citylist5.Last(),
            //    StreetNumber = 5,
            //    Pass = "123456"
            //};
            //personDB5.Insert(newPerson);
            //int personRowsAffected = personDB5.SaveChanges();
            //Console.WriteLine($"{personRowsAffected} rows were inserted");
            //Console.WriteLine("persons after insert: ");
            //PersonList personList = personDB5.SelectAll();
            //foreach (Person p in personList)
            //    Console.WriteLine(p.FirstName + "  id:" + p.Id);


            Console.WriteLine("\nInsert PasserBy");
            PasserByDB passerByDB1 = new PasserByDB();
            CityDB cityDB2 = new CityDB();
            CityList Citylist2 = cityDB2.SelectAll();
            PasserBy newPasserBy = new PasserBy
            {
                FirstName = "Sara",
                LastName = "Levi",
                PhoneNumber = "0529876543",
                Street = "Ben Gurion",
                CityNum = Citylist2.Last(),
                StreetNumber = 12,
                Pass = "654321",
                Help_Category = Help_CategoryDB.SelectById(2),
                JoinDate = DateTime.Now
            };
            passerByDB1.Insert(newPasserBy);
            int passerByRowsAffected = passerByDB1.SaveChanges();
            Console.WriteLine($"{passerByRowsAffected} rows were inserted");
            Console.WriteLine("passerBys after insert: ");
            PasserByList passerByList = passerByDB1.SelectAll();
            foreach (PasserBy p in passerByList)
                Console.WriteLine(p.FirstName + "  id:" + p.Id);

            //Console.WriteLine("\n insert HelpCategory");
            //Help_CategoryDB help_CategoryDB = new Help_CategoryDB();
            //Help_Category newHelpCategory = new Help_Category
            //{
            //    Description = "גישה לתשתיות העסק"
            //};
            //help_CategoryDB.Insert(newHelpCategory);
            //int helpCategoryRowsAffected = help_CategoryDB.SaveChanges();
            //Console.WriteLine($"{helpCategoryRowsAffected} rows were inserted");
            //Console.WriteLine("HelpCategories after insert: ");
            //Help_CategoryList help_CategoryList = help_CategoryDB.SelectAll();
            //foreach (Help_Category hc in help_CategoryList)
            //    Console.WriteLine(hc.Description + "  id:" + hc.Id);


            //Console.WriteLine("\n insert Report");
            //ReportDB reportDB1 = new ReportDB();
            //CityDB cityDB6 = new CityDB();
            //CityList Citylist6 = cityDB6.SelectAll();
            //Report newReport = new Report
            //{
            //    Description = "",
            //    Location_X = 34.7818,
            //    Location_Y = 32.0853,
            //    Update_Time = DateTime.Now,
            //    PasserBy_ID = PasserByDB.SelectById(1).Id,
            //    HCategory = Help_CategoryDB.SelectById(1),
            //    City_Num = Citylist6.Last(),
            //    Photo_Optinal = "photo1.jpg"
            //};
            //reportDB1.Insert(newReport);
            //int reportRowsAffected6 = reportDB1.SaveChanges();
            //Console.WriteLine($"{reportRowsAffected6} rows were inserted");
            //Console.WriteLine("Reports after insert: ");
            //ReportList reportList = reportDB1.SelectAll();
            //foreach (Report r in reportList)
            //    Console.WriteLine(r.Description + "  id:" + r.Id);


            Console.WriteLine("\n Reseting and Inserting Real-World Reports...");

            // אתחול מחלקות ה-DB
            ReportDB reportDB = new ReportDB();
            CityDB cityDB = new CityDB();
            Help_CategoryDB hCatDB = new Help_CategoryDB();
            CityList cities = cityDB.SelectAll();

            // רשימת נתונים להזנה
            var reportsToInsert = new[]
            {
    new {
        Desc = "אדם מבוגר יושב על ספסל, נראה תשוש מאוד וזקוק לאוכל חם",
        Lat = 32.0560, Lon = 34.7790, // דרום תל אביב (ליד התחנה המרכזית)
        CatId = 11 // תרומת אוכל
    },
    new {
        Desc = "צעיר ללא מחסה בגשם, מחפש מקום לינה ללילה הקרוב",
        Lat = 32.8090, Lon = 34.9850, // חיפה (אזור העיר התחתית)
        CatId = 10 // מציאת מקום לינה
    },
    new {
        Desc = "פצוע בכף הרגל, זקוק לחבישה נקייה ועזרה רפואית ראשונית",
        Lat = 31.7870, Lon = 35.2150, // ירושלים (ליד כיכר ציון)
        CatId = 12 // עזרה רפואית
    },
    new {
        Desc = "בעל עסק באזור מציע הטענת טלפונים וגישה למים קרים",
        Lat = 32.0840, Lon = 34.8870, // בני ברק (אזור ז'בוטינסקי)
        CatId = 13 // גישה לתשתיות העסק
    },
    new {
        Desc = "אישה זקוקה למקום בטוח לשמור בו את הציוד שלה לכמה שעות",
        Lat = 31.8920, Lon = 34.8110, // רחובות (ליד תחנת הרכבת)
        CatId = 14 // מרחב בטוח ושמירת חפצים
    }
};

            foreach (var item in reportsToInsert)
            {
                Report r = new Report
                {
                    Description = item.Desc,
                    Location_X = item.Lon, // X הוא בד"כ אורך (Longitude)
                    Location_Y = item.Lat, // Y הוא בד"כ רוחב (Latitude)
                    Update_Time = DateTime.Now,
                    PasserBy_ID = 1, // מניח שיש משתמש עם ID 1
                    HCategory = Help_CategoryDB.SelectById(item.CatId),
                    City_Num = cities.FirstOrDefault() ?? new City { Id = 1 }, // ברירת מחדל לעיר הראשונה
                    Photo_Optinal = "default_report.jpg"
                };

                reportDB.Insert(r);
            }

            int rows = reportDB.SaveChanges();
            Console.WriteLine($"{rows} reports were successfully restored to the database.");





















            //Console.WriteLine("\n     volunteer Respond");
            //VolunteerRespondDB volunteerRespondDB = new VolunteerRespondDB();
            //VolunteerRespond newVolunteerRespond = new VolunteerRespond
            //{
            //    IdReport = ReportDB.SelectById(1),
            //    IdVol = VolunteerDB.SelectById(1),
            //    Repsond_status = StatusDB.SelectById(1)
            //};
            //volunteerRespondDB.Insert(newVolunteerRespond);
            //int volunteerRespondRowsAffected = volunteerRespondDB.SaveChanges();
            //Console.WriteLine($"{volunteerRespondRowsAffected} rows were inserted");
            //Console.WriteLine("VolunteerResponds after insert: ");
            //VolunteerRespondList volunteerRespondList = volunteerRespondDB.SelectAll();
            //foreach (VolunteerRespond vr in volunteerRespondList)
            //    Console.WriteLine("id:" + vr.Id + "  Report id:" + vr.IdReport + " Volunteer id:" + vr.IdVol);


            ////UPDATE ALL    

            //Console.WriteLine("\nUpdate City");
            //CityDB cdb = new CityDB();
            //CityList cities7 = new CityList();
            //cities7 = cdb.SelectAll();
            //City cityToUpdate = cities7.Last();
            //cityToUpdate.City_Name = "Updated City Name";
            //cdb.Update(cityToUpdate);
            //int cy7 = cdb.SaveChanges();
            //Console.WriteLine($"{cy7} rows were updated");
            //Console.WriteLine("cities after update: ");
            //   cities7 = cdb.SelectAll();
            //foreach (City c in cities7)
            //    Console.WriteLine(c.City_Name + "  id:" + c.Id);


            //Console.WriteLine("\nUpdate Status");
            //StatusDB s = new StatusDB();
            //StatusList sl = new StatusList();
            //sl = s.SelectAll();
            //Status statusToUpdate = sl.Last();
            //statusToUpdate.Description = "Updated Status Description";
            //s.Update(statusToUpdate);
            //int sy1 = s.SaveChanges();
            //Console.WriteLine($"{sy1} rows were updated");
            //Console.WriteLine("statuses after update: ");
            //sl = s.SelectAll();
            //foreach (Status st in sl)
            //    Console.WriteLine(st.Description + "  id:" + st.Id);




            //Console.WriteLine("\nUpdate Volunteer");
            //VolunteerDB volunteerDB1 = new VolunteerDB();
            //VolunteerList volunteerList1 = new VolunteerList();
            //volunteerList1 = volunteerDB1.SelectAll();
            //var volunteerToUpdate = volunteerList1.Last();
            //volunteerToUpdate.FirstName = "UpdatedFirstName";
            //volunteerDB1.Update(volunteerToUpdate);
            //int vy1 = volunteerDB1.SaveChanges();
            //Console.WriteLine($"{vy1} rows were updated");
            //Console.WriteLine("volunteers after update: ");
            //volunteerList1 = volunteerDB1.SelectAll();
            //foreach (Volunteer v in volunteerList1)
            //    Console.WriteLine(v.FirstName + "  id:" + v.Id );


            //Console.WriteLine("\nUpdate VolunteerRespond");
            //VolunteerRespondDB volunteerRespondDB1 = new VolunteerRespondDB();
            //VolunteerRespondList volunteerRespondList1 = new VolunteerRespondList();
            //volunteerRespondList1 = volunteerRespondDB1.SelectAll();
            //volunteerDB.Update(volunteerToUpdate);
            //int vry = volunteerRespondDB1.SaveChanges();
            //Console.WriteLine($"{vry} rows were updated");
            //Console.WriteLine("volunteerResponds after update: ");
            //volunteerRespondList1 = volunteerRespondDB1.SelectAll();
            //foreach (VolunteerRespond vr in volunteerRespondList1)
            //    Console.WriteLine("id:" + vr.Id + "  Report id:" + vr.IdReport + " Volunteer id:" + vr.IdVol);


            //Console.WriteLine("\nUpdate Admin");
            //AdminDB adb = new AdminDB();
            //AdminList alist = adb.SelectAll();
            //Admin adminToUpdate = alist.Last();
            //adminToUpdate.FirstName = "UpdatedFirstName";
            //adb.Update(adminToUpdate);
            //int ay = adb.SaveChanges();
            //Console.WriteLine($"{ay} rows were updated");
            //Console.WriteLine("admins after update: ");
            //alist = adb.SelectAll();
            //foreach (Admin a in alist)
            //    Console.WriteLine(a.FirstName + "  id:" + a.Id);


            //Console.WriteLine("\nUpdate Person");
            //PersonDB personDB = new PersonDB();
            //PersonList personList1 = personDB.SelectAll();
            //Person personToUpdate = personList.Last();
            //personToUpdate.FirstName = "UpdatedFirstName";
            //personDB.Update(personToUpdate);
            //int personRowsAffected5 = personDB.SaveChanges();
            //Console.WriteLine($"{personRowsAffected5} rows were updated");
            //Console.WriteLine("Persons after update: ");
            //personList = personDB.SelectAll();
            //foreach (Person p in personList)
            //    Console.WriteLine(p.FirstName + "  id:" + p.Id);


            //Console.WriteLine("\nUpdate PasserBy");
            //PasserByDB passerByDB = new PasserByDB();
            //PasserByList passerByList3 = passerByDB.SelectAll();
            //PasserBy passerByToUpdate = passerByList.Last();
            //passerByToUpdate.FirstName = "UpdatedFirstName";
            //passerByDB.Update(passerByToUpdate);
            //int passerByRowsAffected3 = passerByDB.SaveChanges();
            //Console.WriteLine($"{passerByRowsAffected} rows were updated");
            //Console.WriteLine("PasserBys after update: ");
            //passerByList = passerByDB.SelectAll();
            //foreach (PasserBy p in passerByList)
            //    Console.WriteLine(p.FirstName + "  id:" + p.Id);

            //Console.WriteLine("\n update HelpCategory");
            //Help_CategoryDB help_CategoryDB2 = new Help_CategoryDB();
            //Help_CategoryList help_CategoryList2 = help_CategoryDB.SelectAll();
            //Help_Category help_CategoryToUpdate = help_CategoryList.Last();
            //help_CategoryToUpdate.Description = "Updated Help Category Description";
            //help_CategoryDB.Update(help_CategoryToUpdate);
            //int helpCategoryRowsAffected4 = help_CategoryDB.SaveChanges();
            //Console.WriteLine($"{helpCategoryRowsAffected4} rows were updated");
            //Console.WriteLine("HelpCategories after update: ");
            //help_CategoryList = help_CategoryDB.SelectAll();
            //foreach (Help_Category hc in help_CategoryList)
            //    Console.WriteLine(hc.Description + "  id:" + hc.Id);


            //Console.WriteLine("\n update Report");
            //ReportDB reportDB2 = new ReportDB();
            //ReportList reportList2 = reportDB2.SelectAll();
            //Report reportToUpdate = reportList.Last();
            //reportToUpdate.Description = "Updated Report Description";
            //reportDB2.Update(reportToUpdate);
            //int reportRowsAffected2 = reportDB2.SaveChanges();
            //Console.WriteLine($"{reportRowsAffected2} rows were updated");
            //Console.WriteLine("Reports after update: ");
            //reportList = reportDB2.SelectAll();
            //foreach (Report r in reportList)
            //    Console.WriteLine(r.Description + "  id:" + r.Id);


            //Console.WriteLine("\n update passerBy");
            //passerByDB = new PasserByDB();
            //passerByList = passerByDB.SelectAll();
            //passerByToUpdate = passerByList.Last();
            //passerByToUpdate.FirstName = "AnotherUpdatedFirstName";
            //passerByDB.Update(passerByToUpdate);
            //passerByRowsAffected = passerByDB.SaveChanges();
            //Console.WriteLine($"{passerByRowsAffected} rows were updated");
            //Console.WriteLine("PasserBys after update: ");
            //passerByList = passerByDB.SelectAll();
            //foreach (PasserBy p in passerByList)
            //    Console.WriteLine(p.FirstName + "  id:" + p.Id);




        }
    }
}
