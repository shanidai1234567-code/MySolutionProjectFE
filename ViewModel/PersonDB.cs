using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public class PersonDB : BaseDB
    {
        public PersonList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Person";
            PersonList pList = new PersonList(base.Select());
            return pList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Person p = entity as Person;
            p.FirstName = reader["First_Name"].ToString();
            p.LastName = reader["Last_Name"].ToString();
            p.Phone_Numer = reader["Phone_Number"].ToString();
            p.Street = reader["Street"].ToString();
            p.StreetNumber = Convert.ToInt32(reader["streetNumber"]);
            p.City_Num = CityDB.SelectById((int)reader["City_Num"]);
            p.Pass = reader["pass"].ToString();


            base.CreateModel(entity);
            return p;
        }
        public override BaseEntity NewEntity()
        {
            return new Person();
        }
        static private PersonList list = new PersonList();
        public static Person SelectById(int id)
        {
            PersonDB db = new PersonDB();
            list = db.SelectAll();

            Person g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Person c = entity as Person;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM Person where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Person c = entity as Person;
            if (c != null)
            {
                string sqlStr = $"Insert INTO  Person (FirstName) VALUES (@cName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.FirstName));
                command.Parameters.Add(new OleDbParameter("@lName", c.LastName));
                command.Parameters.Add(new OleDbParameter("@bName", c.LivingAdress));
                command.Parameters.Add(new OleDbParameter("@hName", c.Phone_Numer));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Person c = entity as Person;
            if (c != null)
            {
                string sqlStr = $"UPDATE Person SET FirstName=@cName, LastName=@lName, LivingAdress=@bName, Phone_Numer=@hName WHERE ID=@id";
                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@cName", c.FirstName));
                cmd.Parameters.Add(new OleDbParameter("@lName", c.LastName));
                cmd.Parameters.Add(new OleDbParameter("@bName", c.LivingAdress));
                cmd.Parameters.Add(new OleDbParameter("@hName", c.Phone_Numer));
                cmd.Parameters.Add(new OleDbParameter("@id", c.Id));

            }
        }
    }
}
