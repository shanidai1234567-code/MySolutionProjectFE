using Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
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
            this.uri = baseUri ?? throw new ArgumentNullException(nameof(baseUri));
            // Don't do: client = new HttpClient(); 
            this.Client = client ?? new HttpClient();
            this.Client.BaseAddress = new Uri(uri);
        }

        public async Task<AdminList> GetAllAdmins()  // Implementation of GetAdmins method 1
        {
            HttpResponseMessage response = await Client.GetAsync("/api/Select/AdminSelector");
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                throw new Exception($"API returned {(int)response.StatusCode}: {err}");
            }
            string body = await response.Content.ReadAsStringAsync();
            if (string.IsNullOrWhiteSpace(body))
            {
                // return empty list or null depending on your API contract
                return new AdminList();
            }
            return System.Text.Json.JsonSerializer.Deserialize<AdminList>(body, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<CityList> GetAllCities()  // Implementation of GetCities method 2
        {
            HttpResponseMessage response = await Client.GetAsync("/api/Select/CitySelector");
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                throw new Exception($"API returned {(int)response.StatusCode}: {err}");
            }
            string body = await response.Content.ReadAsStringAsync();
            if (string.IsNullOrWhiteSpace(body))
            {
                // return empty list or null depending on your API contract
                return new CityList();
            }
            return System.Text.Json.JsonSerializer.Deserialize<CityList>(body, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        public async Task<PersonList> GetAllPersons()  // Implementation of GetPersons method 3
        {

            HttpResponseMessage response = await Client.GetAsync("/api/Select/PersonSelector");

            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                throw new Exception($"API returned {(int)response.StatusCode}: {err}");
            }

            string body = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrWhiteSpace(body))
            {
                // return empty list or null depending on your API contract
                return new PersonList();
            }

            return System.Text.Json.JsonSerializer.Deserialize<PersonList>(body, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        public async Task<Help_CategoryList> GetAllHelpCategories()  // Implementation of help_Category method 4
        {
            HttpResponseMessage response = await Client.GetAsync("/api/Select/Help_CategorySelector");
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                throw new Exception($"API returned {(int)response.StatusCode}: {err}");
            }
            string body = await response.Content.ReadAsStringAsync();
            if (string.IsNullOrWhiteSpace(body))
            {
                // return empty list or null depending on your API contract
                return new Help_CategoryList();
            }
            return System.Text.Json.JsonSerializer.Deserialize<Help_CategoryList>(body, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
        public async Task<VolunteerList> GetAllVolunteers()  // Implementation of   V method 5
        {
            HttpResponseMessage response = await Client.GetAsync("/api/Select/VolunteerSelector");
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                throw new Exception($"API returned {(int)response.StatusCode}: {err}");
            }
            string body = await response.Content.ReadAsStringAsync();
            if (string.IsNullOrWhiteSpace(body))
            {
                // return empty list or null depending on your API contract
                return new VolunteerList();
            }
            return System.Text.Json.JsonSerializer.Deserialize<VolunteerList>(body, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<ReportList> GetAllReports()  // Implementation of GetReport method 6
        {
            HttpResponseMessage response = await Client.GetAsync("/api/Select/ReportSelector");
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                throw new Exception($"API returned {(int)response.StatusCode}: {err}");
            }
            string body = await response.Content.ReadAsStringAsync();
            if (string.IsNullOrWhiteSpace(body))
            {
                // return empty list or null depending on your API contract
                return new ReportList();
            }
            return System.Text.Json.JsonSerializer.Deserialize<ReportList>(body, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<PasserByList> GetAllPasserBys()  // Implementation of GetPasserBys method 7
        {
            HttpResponseMessage response = await Client.GetAsync("/api/Select/PasserBySelector");
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                throw new Exception($"API returned {(int)response.StatusCode}: {err}");
            }
            string body = await response.Content.ReadAsStringAsync();
            if (string.IsNullOrWhiteSpace(body))
            {
                // return empty list or null depending on your API contract
                return new PasserByList();
            }
            return System.Text.Json.JsonSerializer.Deserialize<PasserByList>(body, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<VolunteerRespondList> GetAllVolunteerResponds()  // Implementation of VolunteerRespondList method 8
        {
            HttpResponseMessage response = await Client.GetAsync("/api/Select/VolunteerRespondSelector");
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                throw new Exception($"API returned {(int)response.StatusCode}: {err}");
            }
            string body = await response.Content.ReadAsStringAsync();
            if (string.IsNullOrWhiteSpace(body))
            {
                // return empty list or null depending on your API contract
                return new VolunteerRespondList();
            }
            return System.Text.Json.JsonSerializer.Deserialize<VolunteerRespondList>(body, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
        public async Task<StatusList> GetAllStatuses()  // Implementation of GetStatuses method 9
        {
            HttpResponseMessage response = await Client.GetAsync("/api/Select/StatusSelector");
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                throw new Exception($"API returned {(int)response.StatusCode}: {err}");
            }
            string body = await response.Content.ReadAsStringAsync();
            if (string.IsNullOrWhiteSpace(body))
            {
                // return empty list or null depending on your API contract
                return new StatusList();
            }
            return System.Text.Json.JsonSerializer.Deserialize<StatusList>(body, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }



        // Insert all


        public async Task<int> InsertACity(City city) //1
        {
            HttpResponseMessage response = await Client.PostAsJsonAsync("/api/Select/InsertCity", city);
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;
        }

        public async Task<int> InsertAnAdmin(Admin admin) //2
        {
            HttpResponseMessage response = await Client.PostAsJsonAsync("/api/Select/InsertAdmin", admin);
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;
        }

        public async Task<int> InsertAStatus(Status status) //3
        {
            HttpResponseMessage response = await Client.PostAsJsonAsync("/api/Select/InsertStatus", status);
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;
        }

        public async Task<int> InsertAPerson(Person person) //4
        {
            HttpResponseMessage response = await Client.PostAsJsonAsync("/api/Select/InsertPerson", person);
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;
        }

        public async Task<int> InsertAPasserBy(PasserBy passerBy) //5
        {
            HttpResponseMessage response = await Client.PostAsJsonAsync("/api/Select/InsertPasserBy", passerBy);
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;
        }

        public async Task<int> InsertAReport(Report report) //6
        {
            HttpResponseMessage response = await Client.PostAsJsonAsync("/api/Select/InsertReport", report);
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;
        }

        public async Task<int> InsertAVolunteer(Volunteer volunteer) //7
        {
            HttpResponseMessage response = await Client.PostAsJsonAsync("/api/Select/InsertVolunteer", volunteer);
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;
        }

        public async Task<int> InsertAVolunteerRespond(VolunteerRespond volunteerRespond) //8
        {
            HttpResponseMessage response = await Client.PostAsJsonAsync("/api/Select/InsertVolunteerRespond", volunteerRespond);
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;
        }

        public async Task<int> InsertAHelpCategory(Help_Category help_Category) ////9
        {
            HttpResponseMessage response = await Client.PostAsJsonAsync("/api/Select/InsertHelp_Category", help_Category);
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;
        }

        // delete all
        public async Task<int> DeleteACity(int id) //1
        {
            HttpResponseMessage response = await Client.DeleteAsync($"/api/Select/DeleteCity/{id}");
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;
        }

        public async Task<int> DeleteAStatus(int id) //2
        {
            HttpResponseMessage response = await Client.DeleteAsync($"/api/Select/DeleteStatus/{id}");
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;
        }

        public async Task<int> DeleteAPerson(int id) //3
        {
            HttpResponseMessage response = await Client.DeleteAsync($"/api/Select/DeleteAPerson/{id}");
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;
        }

        public async Task<int> DeleteAnAdmin(int id) //4
        {
            HttpResponseMessage response = await Client.DeleteAsync($"/api/Select/DeleteAdmin/{id}");
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;
        }

        public async Task<int> DeleteAPasserBy(int id) //5
        {
            HttpResponseMessage response = await Client.DeleteAsync($"/api/Select/DeletePasserBy/{id}");
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;
        }

        public async Task<int> DeleteAReport(int id) //6
        {
            HttpResponseMessage response = await Client.DeleteAsync($"/api/Select/DeleteReport/{id}");
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;
        }

        public async Task<int> DeleteAVolunteer(int id) //7
        {
            HttpResponseMessage response = await Client.DeleteAsync($"/api/Select/DeleteVolunteer/{id}");
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;
        }

        public async Task<int> DeleteAVolunteerRespond(int id) //8
        {
            HttpResponseMessage response = await Client.DeleteAsync($"/api/Select/DeleteVolunteerRespond/{id}");
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;
        }

        public async Task<int> DeleteAHelpCategory(int id) //9
        {
            HttpResponseMessage response = await Client.DeleteAsync($"/api/Select/DeleteHelp_Category/{id}");
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;
        }

        ///UPDATE

        public async Task<int> UpdateACity(City city) //1
        {
            HttpResponseMessage response = await Client.PutAsJsonAsync("/api/Select/UpdateCity", city);
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;

        }

        public async Task<int> UpdateAStatus(Status status) //1
        {
            HttpResponseMessage response = await Client.PutAsJsonAsync("/api/Select/UpdateStatus", status);
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;

        }

        public async Task<int> UpdateAnAdmin(Admin admin) //2
        {
            HttpResponseMessage response = await Client.PutAsJsonAsync("/api/Select/UpdateAdmin", admin);
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;
        }

        public async Task<int> UpdateAPerson(Person person) //3
        {
            HttpResponseMessage response = await Client.PutAsJsonAsync("/api/Select/UpdatePerson", person);
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;
        }

        public async Task<int> UpdateAPasserBy(PasserBy passerBy) //4
        {
            HttpResponseMessage response = await Client.PutAsJsonAsync("/api/Select/UpdatePasserBy", passerBy);
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;
        }



        public async Task<int> UpdateAReport(Report report) //5
        {
            HttpResponseMessage response = await Client.PutAsJsonAsync("/api/Select/UpdateReport", report);
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;

        }

        public async Task<int> UpdateAVolunteer(Volunteer volunteer) //6
        {
            HttpResponseMessage response = await Client.PutAsJsonAsync("/api/Select/UpdateVolunteer", volunteer);
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;

        }

        public async Task<int> UpdateAVolunteerRespond(VolunteerRespond volunteerRespond) //7
        {
            HttpResponseMessage response = await Client.PutAsJsonAsync("/api/Select/UpdateVolunteerRespond", volunteerRespond);
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;
        }

        public async Task<int> UpdateAHelpCategory(Help_Category helpCategory) //8
        {
            HttpResponseMessage response = await Client.PutAsJsonAsync("/api/Select/UpdateHelp_Category", helpCategory);
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;

        }

        public async Task<int> UpdateAHelp_Category(Help_Category help_Category) //9
        {
            HttpResponseMessage response = await Client.PutAsJsonAsync("/api/Select/UpdateHelp_Category", help_Category);
            if (!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"API Error {(int)response.StatusCode}: {err}");
                return 0;
            }
            return 1;
        }







    }






























































































































        }

