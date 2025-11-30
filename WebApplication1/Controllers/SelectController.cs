using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;
using ViewModel;



   
namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SelectController : ControllerBase
    {

        //select all 
        [HttpGet]
        [ActionName("CitySelector")] //1            


        public CityList SelectAllCities()
        {
            CityDB db = new CityDB();
            CityList cities = db.SelectAll();
            return cities;

        }

        [HttpGet]
        [ActionName("StatusSelector")] //2

        public StatusList SelectAllStatuses()
        {
            StatusDB db = new StatusDB();
            StatusList statuses = db.SelectAll();
            return statuses;
        }

        [HttpGet]
        [ActionName("AdminSelector")]  //3

        public AdminList SelectAllAdmins()
        {
            AdminDB db = new AdminDB();
            AdminList admins = db.SelectAll();
            return admins;
        }

        [HttpGet]
        [ActionName("Help_CategorySelector")]  //4

        public Help_CategoryList SelectAllHelpCategories()
        {
            Help_CategoryDB db = new Help_CategoryDB();
            Help_CategoryList helpCategories = db.SelectAll();
            return helpCategories;
        }

        [HttpGet]
        [ActionName("PasserBySelector")]  //5

        public PasserByList SelectAllPasserBys()
        {
            PasserByDB db = new PasserByDB();
            PasserByList passerBys = db.SelectAll();
            return passerBys;
        }

        [HttpGet]
        [ActionName("VolunteerSelector")]  //6
        public VolunteerList SelectAllVolunteers()
        {
            VolunteerDB db = new VolunteerDB();
            VolunteerList volunteers = db.SelectAll();
            return volunteers;
        }

        [HttpGet]
        [ActionName("PersonSelector")]  //7
        public PersonList SelectAllPersons()
        {
            PersonDB db = new PersonDB();
            PersonList persons = db.SelectAll();
            return persons;
        }

        [HttpGet]
        [ActionName("ReportSelector")]   //8
        public ReportList SelectAllReports()
        {
            ReportDB db = new ReportDB();
            ReportList reports = db.SelectAll();
            return reports;
        }

        [HttpGet]
        [ActionName("VolunteerRespondSelector")] //9

        public VolunteerRespondList SelectAllVolunteerResponds()
        {
            VolunteerRespondDB db = new VolunteerRespondDB();
            VolunteerRespondList volunteerResponds = db.SelectAll();
            return volunteerResponds;
        }



        //insert all

        [HttpGet]
        [ActionName("InsertCity")] //1

        public int InsertCity(City c)
        {
            CityDB db = new CityDB();
            db.Insert(c);
            int x = db.SaveChanges();
            return x;

        }

        [HttpGet]
        [ActionName("InsertStatus")] //2

        public int InsertStatus(Status s)
        {
            StatusDB db = new StatusDB();
            db.Insert(s);
            int x = db.SaveChanges();
            return x;
        }


        [HttpGet]
        [ActionName("InsertHelp_Category")] //3
        public int InsertHelp_Category(Help_Category h)
        {
            Help_CategoryDB db = new Help_CategoryDB();
            db.Insert(h);
            int x = db.SaveChanges();
            return x;
        }

        [HttpGet]
        [ActionName("InsertAdmin")] //4
        public int InsertAdmin(Admin a)
        {
            AdminDB db = new AdminDB();
            db.Insert(a);
            int x = db.SaveChanges();
            return x;


        }

        [HttpGet]
        [ActionName("InsertPasserBy")] //5
        public int InsertPasserBy(PasserBy p)
        {
            PasserByDB db = new PasserByDB();
            db.Insert(p);
            int x = db.SaveChanges();
            return x;
        }

        [HttpGet]
        [ActionName("InsertVolunteer")] //6
        public int InsertVolunteer(Volunteer v)
        {
            VolunteerDB db = new VolunteerDB();
            db.Insert(v);
            int x = db.SaveChanges();
            return x;
        }

        [HttpGet]
        [ActionName("InsertPerson")] //7
        public int InsertPerson(Person p)
        {
            PersonDB db = new PersonDB();
            db.Insert(p);
            int x = db.SaveChanges();
            return x;
        }

        [HttpGet]
        [ActionName("InsertReport")] //8
        public int InsertReport(Report r)
        {
            ReportDB db = new ReportDB();
            db.Insert(r);
            int x = db.SaveChanges();
            return x;
        }



        [HttpGet]
        [ActionName("InsertVolunteerRespond")] //9
        public int InsertVolunteerRespond(VolunteerRespond vr)
        {
            VolunteerRespondDB db = new VolunteerRespondDB();
            db.Insert(vr);
            int x = db.SaveChanges();
            return x;
        }



        //update all
        [HttpGet]
        [ActionName("UpdateCity")] //1
        public void UpdateCity(City c)
        {
            CityDB db = new CityDB();
            db.Update(c);
            int x = db.SaveChanges();


        }

        [HttpGet]
        [ActionName("UpdateStatus")] //2
        public void UpdateStatus(Status s)
        {
            StatusDB db = new StatusDB();
            db.Update(s);
            int x = db.SaveChanges();

        }

        [HttpGet]
        [ActionName("UpdateAdmin")] //3
        public void UpdateAdmin(Admin a)
        {
            AdminDB db = new AdminDB();
            db.Update(a);
            int x = db.SaveChanges();
        }

        [HttpGet]
        [ActionName("UpdateHelp_Category")] //4
        public void UpdateHelp_Category(Help_Category h)
        {
            Help_CategoryDB db = new Help_CategoryDB();
            db.Update(h);
            int x = db.SaveChanges();
        }

        [HttpGet]
        [ActionName("UpdatePasserBy")] //5
        public void UpdatePasserBy(PasserBy p)
        {
            PasserByDB db = new PasserByDB();
            db.Update(p);
            int x = db.SaveChanges();
        }

        [HttpGet]
        [ActionName("UpdateVolunteer")] //6
        public void UpdateVolunteer(Volunteer v)
        {
            VolunteerDB db = new VolunteerDB();
            db.Update(v);
            int x = db.SaveChanges();
        }

        [HttpGet]
        [ActionName("UpdatePerson")] //7
        public void UpdatePerson(Person p)
        {
            PersonDB db = new PersonDB();
            db.Update(p);
            int x = db.SaveChanges();
        }

        [HttpGet]
        [ActionName("UpdateReport")] //8
        public void UpdateReport(Report r)
        {
            ReportDB db = new ReportDB();
            db.Update(r);
            int x = db.SaveChanges();
        }

        [HttpGet]
        [ActionName("UpdateVolunteerRespond")] //9
        public void UpdateVolunteerRespond(VolunteerRespond vr)
        {
            VolunteerRespondDB db = new VolunteerRespondDB();
            db.Update(vr);
            int x = db.SaveChanges();
        }


        //delete all

        [HttpGet]
        [ActionName("DeleteCity")]

        public void DeleteCity(int id) //1
        {
            CityDB db = new CityDB();
            City city = CityDB.SelectById(id);
            db.Delete(city);
            int x = db.SaveChanges();

        }

        [HttpGet]
        [ActionName("DeleteStatus")]
        public void DeleteStatus(int id) //2
        {
            StatusDB db = new StatusDB();
            Status status = StatusDB.SelectById(id);
            db.Delete(status);
            int x = db.SaveChanges();
        }

        [HttpGet]
        [ActionName("DeleteAdmin")]
        public void DeleteAdmin(int id) //3
        {
            AdminDB db = new AdminDB();
            Admin admin = AdminDB.SelectById(
                id);
            db.Delete(admin);
            int x = db.SaveChanges();
        }

        [HttpGet]
        [ActionName("DeleteHelp_Category")]
        public void DeleteHelp_Category(int id) //4
        {
            Help_CategoryDB db = new Help_CategoryDB();
            Help_Category helpCategory = Help_CategoryDB.SelectById(id);
            db.Delete(helpCategory);
            int x = db.SaveChanges();
        }

        [HttpGet]
        [ActionName("DeletePasserBy")]
        public void DeletePasserBy(int id) //5
        {
            PasserByDB db = new PasserByDB();
            PasserBy passerBy = PasserByDB.SelectById(id);
            db.Delete(passerBy);
            int x = db.SaveChanges();
        }

        [HttpGet]
        [ActionName("DeleteVolunteer")]
        public void DeleteVolunteer(int id) //6
        {
            VolunteerDB db = new VolunteerDB();
            Volunteer volunteer = VolunteerDB.SelectById(id);
            db.Delete(volunteer);
            int x = db.SaveChanges();
        }

        [HttpGet]
        [ActionName("DeletePerson")]
        public void DeletePerson(int id) //7
        {
            PersonDB db = new PersonDB();
            Person person = PersonDB.SelectById(id);
            db.Delete(person);
            int x = db.SaveChanges();
        }

        [HttpGet]
        [ActionName("DeleteReport")]
        public void DeleteReport(int id) //8
        {
            ReportDB db = new ReportDB();
            Report report = ReportDB.SelectById(id);
            db.Delete(report);
            int x = db.SaveChanges();
        }

        [HttpGet]
        [ActionName("DeleteVolunteerRespond")]
        public void DeleteVolunteerRespond(int id) //9
        {
            VolunteerRespondDB db = new VolunteerRespondDB();
            VolunteerRespond volunteerRespond = VolunteerRespondDB.SelectById(id);
            db.Delete(volunteerRespond);
            int x = db.SaveChanges();
        }

    }
    }
