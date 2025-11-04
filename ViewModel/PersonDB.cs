using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            p.PhoneNumber = reader["Phone_Number"].ToString();
            p.Street = reader["Street"].ToString();
            p.CityNum = CityDB.SelectById((int)reader["City_Num"]);
            p.StreetNumber = Convert.ToInt32(reader["streetNumber"]);
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
                string sqlStr = @"INSERT INTO Person 
            (First_Name, Last_Name, Phone_Number, Pass, Street, streetNumber, City_Num)
            VALUES
            (@cName, @lName, @bName, @hName, @pName, @sName, @snName, @cnName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.FirstName));
                command.Parameters.Add(new OleDbParameter("@lName", c.LastName));
                //command.Parameters.Add(new OleDbParameter("@bName", c.LivingAdress));
                command.Parameters.Add(new OleDbParameter("@hName", c.PhoneNumber));
                command.Parameters.Add(new OleDbParameter("@pName", c.Pass));
                command.Parameters.Add(new OleDbParameter("@sName", c.Street));
                command.Parameters.Add(new OleDbParameter("@snName", c.StreetNumber));
                command.Parameters.Add(new OleDbParameter("@cnName", c.CityNum.Id));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));

            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Person c = entity as Person;
            if (c != null)
            {
                string sqlStr = @"UPDATE Person SET 
                                    First_Name=@cName,
                                    Last_Name=@lName,
                                    Phone_Number=@hName,
                                    Street=@sName,
                                    City_Num=@cnName,
                                    streetNumber=@snName,
                                    Pass=@pName,
                                  WHERE ID=@id";
                
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.FirstName));
                command.Parameters.Add(new OleDbParameter("@lName", c.LastName));
                // command.Parameters.Add(new OleDbParameter("@bName", c.LivingAdress));
                command.Parameters.Add(new OleDbParameter("@hName", c.Phone_Number));
                command.Parameters.Add(new OleDbParameter("@sName", c.Street));
                command.Parameters.Add(new OleDbParameter("@cnName", c.City_Num.Id));
                command.Parameters.Add(new OleDbParameter("@snName", c.StreetNumber));
                command.Parameters.Add(new OleDbParameter("@pName", c.Pass));
                
               
                command.Parameters.Add(new OleDbParameter("@id", c.Id));


            }
        }




    }
}

