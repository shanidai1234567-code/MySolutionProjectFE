﻿using Model;    
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class AdminDB: PersonDB
    {

        public new AdminList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Admin";
            AdminList pList = new AdminList(base.Select());
            return pList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Admin p = entity as Admin;
            p.FirstName = reader["FirstName"].ToString();
            p.LastName = reader["LastName"].ToString();
            p.Phone_Numer = reader["telephone num"].ToString();
            p.LivingAdress = reader["LivingAdress"].ToString();
            p.Street = reader["street"].ToString();
            p.StreetNumber = Convert.ToInt32(reader["streetNumber"]);
            p.City_Num = CityDB.SelectById((int)reader["CityNumber"]);
            p.Admin_password = reader["pass"].ToString();

            base.CreateModel(entity);
            return p;
        }
        public override BaseEntity NewEntity()
        {
            return new Admin();
        }
        static private AdminList list = new AdminList();
        public static Admin SelectById(int id)
        {
            AdminDB db = new AdminDB();
            list = db.SelectAll();

            Admin c = list.Find(item => item.Id == id);
            return c;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Admin c = entity as Admin;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM Admin where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Admin c = entity as Admin;
            if (c != null)
            {
                string sqlStr = $"Insert INTO  Admin (FirstName) VALUES (@cName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.FirstName));
                command.Parameters.Add(new OleDbParameter("@lName", c.LastName));
                command.Parameters.Add(new OleDbParameter("@bName", c.LivingAdress));
                command.Parameters.Add(new OleDbParameter("@hName", c.Phone_Numer));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Admin c = entity as Admin;
            if (c != null)
            {
                string sqlStr = $"UPDATE Volunteer  SET FirstName=@cName , LastName=@lName, Livingadress= @bName , [ Phone_Numer] = @hName WHERE ID=@id";
                //   string sqlStr = $"UPDATE Person  SET FirstName=@cName,lastName=@lName,livingadress=@ladd WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.FirstName));
                command.Parameters.Add(new OleDbParameter("@lName", c.LastName));
                command.Parameters.Add(new OleDbParameter("@bName", c.LivingAdress));
                command.Parameters.Add(new OleDbParameter("@hName", c.Phone_Numer));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));

                //p.FirstName = reader["FirstName"].ToString();
                //p.LastName = reader["LastName"].ToString();
                //p.Phone_Numer = reader["telephone num"].ToString();
                //p.LivingAdress = reader["LivingAdress"].ToString();
                //p.Street = reader["street"].ToString();
                //p.StreetNumber = Convert.ToInt32(reader["streetNumber"]);
                //p.City_Num = CityDB.SelectById((int)reader["CityNumber"]);
                //p.Admin_password = reader["pass"].ToString();

            }
        }

    }
}

