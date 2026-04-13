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
            p.FirstName = reader["FirstName"].ToString(); // Fixed
            p.LastName = reader["LastName"].ToString();   
            p.PhoneNumber = reader["PhoneNumber"].ToString(); 
            p.Street = reader["Street"].ToString();
            p.StreetNumber = Convert.ToInt32(reader["StreetNumber"]); 
            p.CityNum = CityDB.SelectById((int)reader["CityNum"]); 
            p.Pass = reader["Pass"].ToString();
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
                // SQL string must match the column names in your image
                string sqlStr = "INSERT INTO Person (FirstName, LastName, PhoneNumber, Street, CityNum, Pass, StreetNumber) " +
                                "VALUES (@fName, @lName, @phone, @street, @city, @pass, @sNum)";

                cmd.CommandText = sqlStr;
                // Order matters for OleDb!
                cmd.Parameters.Add(new OleDbParameter("@fName", c.FirstName));
                cmd.Parameters.Add(new OleDbParameter("@lName", c.LastName));
                cmd.Parameters.Add(new OleDbParameter("@phone", c.PhoneNumber));
                cmd.Parameters.Add(new OleDbParameter("@street", c.Street));
                cmd.Parameters.Add(new OleDbParameter("@city", c.CityNum.Id));
                cmd.Parameters.Add(new OleDbParameter("@pass", c.Pass));
                cmd.Parameters.Add(new OleDbParameter("@sNum", c.StreetNumber));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Person c = entity as Person;
            if (c != null)
            {
                // Corrected column names: FirstName, LastName, PhoneNumber, etc.
                string sqlStr = "UPDATE Person SET FirstName=@fName, LastName=@lName, PhoneNumber=@phone, " +
                                "Street=@street, CityNum=@city, Pass=@pass, StreetNumber=@sNum WHERE ID=@id";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@fName", c.FirstName));
                cmd.Parameters.Add(new OleDbParameter("@lName", c.LastName));
                cmd.Parameters.Add(new OleDbParameter("@phone", c.PhoneNumber));
                cmd.Parameters.Add(new OleDbParameter("@street", c.Street));
                cmd.Parameters.Add(new OleDbParameter("@city", c.CityNum.Id));
                cmd.Parameters.Add(new OleDbParameter("@pass", c.Pass));
                cmd.Parameters.Add(new OleDbParameter("@sNum", c.StreetNumber));
                cmd.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
    }
}
