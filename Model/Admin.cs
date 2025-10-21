using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Admin:Person
    {
        private string password;
        public override string ToString()
        {
            return $"Admin: {FirstName} {LastName}, Address: {LivingAdress}, {Street} St., No. {StreetNumber}, City Code: {CityNumber}, Phone: {Phone_Numer}, pass: {password}";
        }
    }
}
