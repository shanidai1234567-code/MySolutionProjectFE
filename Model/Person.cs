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
      
        private string phoneNumber;

        private string street;
        private City cityNum;
        private int streetNumber;
        private string pass;
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

       

        public string Street {  get => street;  set => street = value; }

        
        public int StreetNumber{ get => streetNumber; set => streetNumber = value; }

        public string Pass  { get => pass; set => pass = value;}
       
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public City CityNum { get => cityNum; set => cityNum = value; }

        public override string ToString()
        {
            return base.ToString() + $"{FirstName} {LastName}, St.{Street} , No. {StreetNumber}, City Code: {cityNum}, Phone: {phoneNumber}, pass: {pass}";
        }

    }
}
