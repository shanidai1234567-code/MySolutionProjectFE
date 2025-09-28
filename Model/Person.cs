using System;
using System.Collections.Generic;
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
        private string telNum;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string LivingAdress { get => livingAdress; set => livingAdress = value; }
        public string TelNum { get => telNum; set => telNum = value; }

        public override string ToString()
        {
            return $"{firstName} {lastName}, livingAdress: {livingAdress} , telNum: {telNum}";
        }
    }
}
