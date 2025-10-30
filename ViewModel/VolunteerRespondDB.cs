using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    public class VolunteerRespondDB: BaseDB
    {
        public new VolunteerRespondList SelectAll()
        {
            command.CommandText = $"SELECT Person.ID, Person.First_Name, Person.Last_Name, Person.";
            pList = new VolunteerRespondList(base.Select());
            return pList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Volunteer p = entity as Volunteer;

            //p.FirstName = reader["FirstName"].ToString();
            //p.LastName = reader["LastName"].ToString();
            //p.Phone_Numer = reader["telephone num"].ToString();
            //p.LivingAdress = reader["LivingAdress"].ToString();
            //p.Street = reader["street"].ToString();
            //p.StreetNumber = Convert.ToInt32(reader["streetNumber"]);
            //p.City_Num = CityDB.SelectById((int)reader["CityNumber"]);
            //p.Pass = reader["pass"].ToString();

            p.StoreOpeningTime = Convert.ToDateTime(reader["StoreOpeningTime"]);
            p.StoreClosingTime = Convert.ToDateTime(reader["StoreClosingTime"]);
            p.JoinDate = Convert.ToDateTime(reader["JoinDate"]);
            p.Location_X = Convert.ToDouble(reader["Location_X"]);
            p.Location_Y = Convert.ToDouble(reader["Location_Y"]);
            p.Help_Category = Help_CategoryDB.SelectById(Convert.ToInt32(reader["ID"]));

            base.CreateModel(entity);
            return p;
        }
        public override BaseEntity NewEntity()
        {
            return new Volunteer();
        }
        static private VolunteerList list = new VolunteerList();
        public static Volunteer SelectById(int id)
        {
            VolunteerDB db = new VolunteerDB();
            list = db.SelectAll();

            Volunteer c = list.Find(item => item.Id == id);
            return c;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Volunteer c = entity as Volunteer;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM Volunteer where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Volunteer c = entity as Volunteer;
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
            Volunteer c = entity as Volunteer;
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
            }
        }

    }
}

