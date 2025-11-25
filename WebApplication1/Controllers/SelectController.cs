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



        //delete all

        //update all
        [HttpGet]
        [ActionName("UpdateCity")] //1
        public void UpdateCity(City c)
        {
            CityDB db = new CityDB();
            db.Update(c);
            int x = db.SaveChanges();

          
        }
    }

}
