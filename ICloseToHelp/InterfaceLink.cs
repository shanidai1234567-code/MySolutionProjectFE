 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using ViewModel;



namespace ICloseToHelp
{
    public interface InterfaceLink
    {
        //public  Task<CityList> GetCities(); // Retrieve all cities 1
        public Task<int> InsertACity( City city);
        public Task<int> UpdateACity(City city);
        public Task<int> DeleteACity(int id);
        public Task<CityList> GetAllCities();

        //public Task<StatusList> GetStatuses(); // Retrieve all statuses 2
        public Task<int> InsertAStatus(Status status);
        public Task<int> UpdateAStatus(Status status);
        public Task<int> DeleteAStatus(int id);
        public Task<StatusList> GetAllStatuses();


       //public Task<AdminList> GetAdmins();  // Retrieve all admins 3
        public Task<int> InsertAnAdmin(Admin admin);
        public Task<int> UpdateAnAdmin(Admin admin);
        public Task<int> DeleteAnAdmin(int id);
        public Task<AdminList> GetAllAdmins();

       // public Task<PasserByList> GetPasserBys(); // Retrieve all passerbys 4
        public Task<int> InsertAPasserBy(PasserBy passerBy);
        public Task<int> UpdateAPasserBy(PasserBy passerBy);
        public Task<int> DeleteAPasserBy(int id);
        public Task<PasserByList> GetAllPasserBys();

        //public Task<Help_CategoryList> GetHelpCategories(); // Retrieve all help categories 5
        public Task<int> InsertAHelpCategory(Help_Category helpCategory);
        public Task<int> UpdateAHelpCategory(Help_Category helpCategory);
        public Task<int> DeleteAHelpCategory(int id);
        public Task<Help_CategoryList> GetAllHelpCategories();

       // public Task<VolunteerList> GetVolunteer(); // Retrieve all volunteers 6
        public Task<int> InsertAVolunteer(Volunteer volunteer);
        public Task<int> UpdateAVolunteer(Volunteer volunteer);
        public Task<int> DeleteAVolunteer(int id);
        public Task<VolunteerList> GetAllVolunteers();

       // public Task<PersonList> GetPerson(); // Retrieve all persons 7
        public Task<int> InsertAPerson(Person person);
        public Task<int> UpdateAPerson(Person person);
        public Task<int> DeleteAPerson(int id);
        public Task<PersonList> GetAllPersons();

       // public Task<ReportList> GetReport(); // Retrieve all reports 8
        public Task<int> InsertAReport(Report report);
        public Task<int> UpdateAReport(Report report);
        public Task<int> DeleteAReport(int id);
        public Task<ReportList> GetAllReports();

      //  public Task<VolunteerRespondList> GetVolunteerRespond(); // Retrieve all volunteer responds 9
        public Task<int> InsertAVolunteerRespond(VolunteerRespond volunteerRespond);
        public Task<int> UpdateAVolunteerRespond(VolunteerRespond volunteerRespond);
        public Task<int> DeleteAVolunteerRespond(int id);
        public Task<VolunteerRespondList> GetAllVolunteerResponds();

    }
}
