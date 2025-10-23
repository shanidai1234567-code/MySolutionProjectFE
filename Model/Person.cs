using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Person : BaseEntity
    {
        private string firstName;
        private string lastName;
        private string livingAdress;
        private string phone_Numer;

        private string street;
        private City city_Num;
        private int streetNumber;
        private string pass;
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string LivingAdress { get => livingAdress; set => livingAdress = value; }
        public string Phone_Numer { get => phone_Numer; set => phone_Numer = value; }

        public string Street {  get => street;  set => street = value; }

        
        public int StreetNumber{ get => streetNumber; set => streetNumber = value; }

        public string Pass  { get => pass; set => pass = value;}
        public City City_Num { get => city_Num; set => city_Num = value; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, Address: {livingAdress}, {Street} St., No. {StreetNumber}, City Code: {city_Num}, Phone: {phone_Numer}, pass: {pass}";
        }
    }
}
