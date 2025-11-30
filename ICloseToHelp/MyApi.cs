using System;
using System.Collections.Generic;
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
          //  uri + "http://localhost:5115";
            Client = new HttpClient();
            Client.BaseAddress = new Uri(uri);
        }
        public async Task<AdminList> GetAdmins()  // Implementation of GetAdmins method 1
        {
           return await Client.GetFromJsonAsync<AdminList>( uri +"/api/Insert/AdminSelector");
        }

        public async Task<CityList> GetCities()  // Implementation of GetCities method 2
        {
           return await Client.GetFromJsonAsync<CityList>( uri + "/api/Insert/CitySelector");
        }

        public async Task<PersonList> GetPersons()  // Implementation of GetPersons method 3
        {
           return await Client.GetFromJsonAsync<PersonList>( uri + "/api/Insert/PersonSelector");
        }

        public async Task<Help_CategoryList> GetHelp_Category()  // Implementation of help_Category method 4
        {
           return await Client.GetFromJsonAsync<Help_CategoryList>( uri +"/api/Insert/help_CategorySelector");
        }
        public async Task<VolunteerList> GetVolunteer()  // Implementation of   V method 5
        {
           return await Client.GetFromJsonAsync<VolunteerList>( uri + "/api/Insert/VolunteerSelector");
        }

        public async Task<ReportList> GetReport()  // Implementation of GetReport method 6
        {
           return await Client.GetFromJsonAsync<ReportList>( uri + "/api/Insert/ReportSelector");
        }

        public async Task<PasserByList> GetPasserBys()  // Implementation of GetPasserBys method 7
        {
           return await Client.GetFromJsonAsync<PasserByList>( uri + "/api/Insert/PasserBySelector");
        }
    
        public async Task<VolunteerRespondList> GetVolunteerRespond()  // Implementation of VolunteerRespondList method 8
        {
           return await Client.GetFromJsonAsync<VolunteerRespondList>( uri + "/api/Insert/VolunteerRespondSelector");
        }
        public async  Task<StatusList> GetStatuses()  // Implementation of GetStatuses method 9
        {
           return await Client.GetFromJsonAsync<StatusList>( uri + "/api/Insert/statusesSelector");
        }

       
      
        // Insert all


        public async Task<int> InsertACity(City city) // Implementation of InsertACity method 1
        {
            var response = await Client.PostAsJsonAsync(uri + "/api/Insert/InsertCity", city);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAnAdmin(Admin admin) // Implementation of InsertAnAdmin method 2
        {
            var response = await Client.PostAsJsonAsync(uri + "/api/Insert/InsertAdmin", admin);
            return response.IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<int> InsertAStatus(Status status) // Implementation of InsertAStatus method 3
        {
            var response = await Client.PostAsJsonAsync(uri + "/api/Insert/InsertStatus", status);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAParson(Person person) // Implementation of InsertAPerson method 4
        {
            var response = await Client.PostAsJsonAsync(uri + "/api/Insert/InsertPerson", person);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAPasserBy(PasserBy passerBy) // Implementation of InsertAPasserBy method 5
        {
            var response = await Client.PostAsJsonAsync(uri + "/api/Insert/InsertPasserBy", passerBy);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAReport(Report report) // Implementation of InsertAReport method 6
        {
            var response = await Client.PostAsJsonAsync(uri + "/api/Insert/InsertReport", report);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAVolunteer(Volunteer volunteer) // Implementation of InsertAVolunteer method 7
        {
            var response = await Client.PostAsJsonAsync(uri + "/api/Insert/InsertVolunteer", volunteer);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAVolunteerRespond(VolunteerRespond volunteerRespond) // Implementation of InsertAVolunteerRespond method 8
        {
            var response = await Client.PostAsJsonAsync(uri + "/api/Insert/InsertVolunteerRespond", volunteerRespond);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAHelp_Category(Help_Category help_Category) // Implementation of InsertAHelp_Category method 9
        {
            var response = await Client.PostAsJsonAsync(uri + "/api/Insert/InsertHelp_Category", help_Category);
            return response.IsSuccessStatusCode ? 1 : 0;
        }

        // update all
        public async Task<int> UpdateACity(City city)
        {
            return await Client.PutAsJsonAsync<int>(uri + "/api/Update/UpdateCity", city);
        }

        Task<int> InterfaceICloseToHelp.DeleteACity(City city)
        {
            throw new NotImplementedException();
        }

        Task<CityList> InterfaceICloseToHelp.GetAllCities()
        {
            throw new NotImplementedException();
        }

        Task<StatusList> InterfaceICloseToHelp.GetStatuses()
        {
            throw new NotImplementedException();
        }

        Task<int> InterfaceICloseToHelp.InsertAStatus(Status status)
        {
            throw new NotImplementedException();
        }

        Task<int> InterfaceICloseToHelp.UpdateAStatus(Status status)
        {
            throw new NotImplementedException();
        }

        Task<int> InterfaceICloseToHelp.DeleteAStatus(Status status)
        {
            throw new NotImplementedException();
        }

        Task<StatusList> InterfaceICloseToHelp.GetAllStatuses()
        {
            throw new NotImplementedException();
        }

        Task<AdminList> InterfaceICloseToHelp.GetAdmins()
        {
            throw new NotImplementedException();
        }

        Task<int> InterfaceICloseToHelp.InsertAnAdmin(Admin admin)
        {
            throw new NotImplementedException();
        }

        Task<int> InterfaceICloseToHelp.UpdateAnAdmin(Admin admin)
        {
            throw new NotImplementedException();
        }

        Task<int> InterfaceICloseToHelp.DeleteAnAdmin(Admin admin)
        {
            throw new NotImplementedException();
        }

        Task<AdminList> InterfaceICloseToHelp.GetAllAdmins()
        {
            throw new NotImplementedException();
        }
    }
}
