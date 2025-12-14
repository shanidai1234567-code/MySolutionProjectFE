using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Model;
using ViewModel;


namespace ICloseToHelp
{
    public class MyApi : InterfaceICloseToHelp
    {
        string uri;
        public HttpClient Client;

        public MyApi()
        {
        
            uri = "https://p0119g06-5062.euw.devtunnels.ms";
            Client = new HttpClient();
            Client.BaseAddress = new Uri(uri);
        }

        public MyApi(HttpClient client, string baseUri)
        {
            uri = baseUri;
            client = new HttpClient();
            this.Client = client ?? throw new ArgumentNullException(nameof(client));
            this.uri = baseUri ?? throw new ArgumentNullException(nameof(baseUri));
        }

        public async Task<AdminList> GetAllAdmins()  // Implementation of GetAdmins method 1
        {
           return await Client.GetFromJsonAsync<AdminList>( uri + "/api/Select/AdminSelector");
        }

        public async Task<CityList> GetAllCities()  // Implementation of GetCities method 2
        {
            return await Client.GetFromJsonAsync<CityList>("/api/Select/CitySelector");
        }

        public async Task<PersonList> GetAllPersons()  // Implementation of GetPersons method 3
        {
           return await Client.GetFromJsonAsync<PersonList>( uri + "/api/Select/PersonSelector");
        }

        public async Task<Help_CategoryList> GetAllHelpCategories()  // Implementation of help_Category method 4
        {
           return await Client.GetFromJsonAsync<Help_CategoryList>( uri + "/api/Select/Help_CategorySelector");
        }
        public async Task<VolunteerList> GetAllVolunteers()  // Implementation of   V method 5
        {
           return await Client.GetFromJsonAsync<VolunteerList>( uri + "/api/Select/VolunteerSelector");
        }

        public async Task<ReportList> GetAllReports()  // Implementation of GetReport method 6
        {
           return await Client.GetFromJsonAsync<ReportList>( uri + "/api/Select/ReportSelector");
        }

        public async Task<PasserByList> GetAllPasserBys()  // Implementation of GetPasserBys method 7
        {
           return await Client.GetFromJsonAsync<PasserByList>( uri + "/api/Select/PasserBySelector");
        }
    
        public async Task<VolunteerRespondList> GetAllVolunteerResponds()  // Implementation of VolunteerRespondList method 8
        {
           return await Client.GetFromJsonAsync<VolunteerRespondList>( uri + "/api/Select/VolunteerRespondSelector");
        }
        public async  Task<StatusList> GetAllStatuses()  // Implementation of GetStatuses method 9
        {
           return await Client.GetFromJsonAsync<StatusList>( uri + "/api/Select/StatusSelector");
        }

       
      
        // Insert all


        public async Task<int> InsertACity(City city) // Implementation of InsertACity method 1
        {
            var response = await Client.PostAsJsonAsync<City>(uri + "/api/Select/InsertCity", city);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAnAdmin(Admin admin) // Implementation of InsertAnAdmin method 2
        {
            var response = await Client.PostAsJsonAsync<Admin>(uri + "/api/Select/InsertAdmin", admin);
            return response.IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<int> InsertAStatus(Status status) // Implementation of InsertAStatus method 3
        {
            var response = await Client.PostAsJsonAsync<Status>(uri + "/api/Select/InsertStatus", status);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAPerson(Person person) // Implementation of InsertAPerson method 4
        {
            var response = await Client.PostAsJsonAsync<Person>(uri + "/api/Select/InsertPerson", person);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAPasserBy(PasserBy passerBy) // Implementation of InsertAPasserBy method 5
        {
            var response = await Client.PostAsJsonAsync<PasserBy>(uri + "/api/Select/InsertPasserBy", passerBy);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAReport(Report report) // Implementation of InsertAReport method 6
        {
            var response = await Client.PostAsJsonAsync<Report>(uri + "/api/Select/InsertReport", report);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAVolunteer(Volunteer volunteer) // Implementation of InsertAVolunteer method 7
        {
            var response = await Client.PostAsJsonAsync<Volunteer>(uri + "/api/Select/InsertVolunteer", volunteer);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAVolunteerRespond(VolunteerRespond volunteerRespond) // Implementation of InsertAVolunteerRespond method 8
        {
            var response = await Client.PostAsJsonAsync<VolunteerRespond>(uri + "/api/Select/InsertVolunteerRespond", volunteerRespond);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAHelpCategory(Help_Category help_Category) // Implementation of InsertAHelp_Category method 9
        {
            var response = await Client.PostAsJsonAsync<Help_Category>(uri + "/api/Select/InsertHelp_Category", help_Category);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        // update all
        public async Task<int> UpdateACity(City city) // Implementation of UpdateACity method 1
        {
            var response = await Client.PutAsJsonAsync<City>(uri + "/api/Select/UpdateCity", city);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAStatus(Status status) // Implementation of UpdateStatus method 2
        {
            var response = await Client.PutAsJsonAsync<Status>(uri + "/api/Select/UpdateStatus", status);
            return response.IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAnAdmin(Admin admin) // Implementation of UpdateAdmin method 3
        {
            var response = await Client.PutAsJsonAsync<Admin>(uri + "/api/Select/UpdateAdmin", admin);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAPerson(Person person) // Implementation of UpdatePerson method 4
        {
            var response = await Client.PutAsJsonAsync<Person>(uri + "/api/Select/UpdatePerson", person);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAPasserBy(PasserBy passerBy) // Implementation of UpdatePasserBy method 5
        {
            var response = await Client.PutAsJsonAsync<PasserBy>(uri + "/api/Select/UpdatePasserBy", passerBy);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAReport(Report report)   // Implementation of UpdateReport method 6
        {
            var response = await Client.PutAsJsonAsync<Report>(uri + "/api/Select/UpdateReport", report);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAVolunteer(Volunteer volunteer)  // Implementation of UpdateVolunteer method 7
        {
            var response = await Client.PutAsJsonAsync<Volunteer>(uri + "/api/Select/UpdateVolunteer", volunteer);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAVolunteerRespond(VolunteerRespond volunteerRespond) // Implementation of UpdateVolunteerRespond method 8
        {
            var response = await Client.PutAsJsonAsync<VolunteerRespond>(uri + "/api/Select/UpdateVolunteerRespond", volunteerRespond);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAHelpCategory(Help_Category helpCategory) // Implementation of UpdateHelp_Category method 9
        {
            var response = await Client.PutAsJsonAsync<Help_Category>(uri + "/api/Select/UpdateHelp_Category", helpCategory);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        // delete all

        public async Task<int> DeleteACity(int id)  // Implementation of DeleteACity method 1
        {
           var response = await Client.DeleteAsync(uri + "/api/Insert/DeleteCity" + id);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAStatus(int id) // Implementation of DeleteAStatus method 2
        {
            var response = await Client.DeleteAsync(uri + "/api/Insert/DeleteStatus" + id);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAPerson(int id) // implementation of delete APerson method 3
        {
            var response = await Client.DeleteAsync(uri + "/api/Insert/DeleteAPerson" + id);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAnAdmin(int id) // Implementation of DeleteAnAdmin method 4
        {
            var response = await Client.DeleteAsync(uri + "/api/Insert/DeleteAdmin" + id);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAPasserBy(int id) // Implementation of DeleteAPasserBy method 5
        {
            var response = await Client.DeleteAsync(uri + "/api/Insert/DeletePasserBy" + id);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAReport(int id) // Implementation of DeleteAReport method 6
        {
            var response = await Client.DeleteAsync(uri + "/api/Insert/DeleteReport" + id);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAVolunteer(int id) // Implementation of DeleteAVolunteer method 7
        {
            var response = await Client.DeleteAsync(uri + "/api/Insert/DeleteVolunteer" + id);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAVolunteerRespond(int id) // Implementation of DeleteAVolunteerRespond method 8
        {
            var response = await Client.DeleteAsync(uri + "/api/Insert/DeleteVolunteerRespond" + id);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAHelpCategory(int id) // Implementation of DeleteAHelp_Category method 9
        {
            var response = await Client.DeleteAsync(uri + "/api/Insert/DeleteHelp_Category" + id);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        
       
    }
}
