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
    public class VolunteerDB: PersonDB
    {
 
        public new VolunteerList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Volunteer";
            VolunteerList pList = new VolunteerList(base.Select());
            return pList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Volunteer p = entity as Volunteer;
            p.FirstName = reader["FirstName"].ToString();
            p.LastName = reader["LastName"].ToString();
            p.Phone_Numer = reader["telephone num"].ToString();
            p.LivingAdress = reader["LivingAdress"].ToString();

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
