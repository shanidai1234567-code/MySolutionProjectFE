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
            p.FirstName = reader["FirstName"].ToString();
            p.LastName = reader["LastName"].ToString();
            p.PhoneNumber = reader["PhoneNumber"].ToString();
            p.Street = reader["Street"].ToString();
            p.CityNum = CityDB.SelectById((int)reader["CityNum"]);
            p.StreetNumber = Convert.ToInt32(reader["StreetNumber"]);
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
                string sqlStr = "DELETE FROM Person WHERE ID=@pid";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@pid", c.Id));
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
            (@cName, @lName, @hName, @pName, @sName, @snName, @cnName)";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@cName", c.FirstName));
                cmd.Parameters.Add(new OleDbParameter("@lName", c.LastName));
                cmd.Parameters.Add(new OleDbParameter("@hName", c.PhoneNumber));
                cmd.Parameters.Add(new OleDbParameter("@pName", c.Pass));
                cmd.Parameters.Add(new OleDbParameter("@sName", c.Street));
                cmd.Parameters.Add(new OleDbParameter("@snName", c.StreetNumber));
                cmd.Parameters.Add(new OleDbParameter("@cnName", c.CityNum.Id));
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
                            Pass=@pName
                          WHERE ID=@id";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@cName", c.FirstName));
                cmd.Parameters.Add(new OleDbParameter("@lName", c.LastName));
                cmd.Parameters.Add(new OleDbParameter("@hName", c.PhoneNumber));
                cmd.Parameters.Add(new OleDbParameter("@sName", c.Street));
                cmd.Parameters.Add(new OleDbParameter("@cnName", c.CityNum.Id));
                cmd.Parameters.Add(new OleDbParameter("@snName", c.StreetNumber));
                cmd.Parameters.Add(new OleDbParameter("@pName", c.Pass));
                cmd.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }





    }
}

