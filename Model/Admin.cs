using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Admin:Person
    {
        private string admin_password;
        public string Admin_password { get => admin_password; set => admin_password = value; }

        public override string ToString()
        {
            return $"Admin: {FirstName} {LastName}, St. {Street} , No. {StreetNumber}, City Code: {CityNum}, Phone: {PhoneNumber}, pass: {admin_password}";
        }
    }
}
