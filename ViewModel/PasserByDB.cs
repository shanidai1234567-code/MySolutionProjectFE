using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class PasserByDB: PersonDB
    {
        public new PasserByList SelectAll()
        {
            command.CommandText = $"SELECT * FROM PasserBy";
            PasserByList pList = new PasserByList(base.Select());
            return pList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            PasserBy p = entity as PasserBy;
            p.FirstName = reader["FirstName"].ToString();
            p.LastName = reader["LastName"].ToString();
            p.Phone_Numer = reader["telephone num"].ToString();
            p.LivingAdress = reader["LivingAdress"].ToString();

            base.CreateModel(entity);
            return p;
        }
        public override BaseEntity NewEntity()
        {
            return new PasserBy();
        }
        static private PasserByList list = new PasserByList();
        public static PasserBy SelectById(int id)
        {
            PasserByDB db = new PasserByDB();
            list = db.SelectAll();

            PasserBy c = list.Find(item => item.Id == id);
            return c;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            PasserBy c = entity as PasserBy;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM Person where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            PasserBy c = entity as PasserBy;
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
            PasserBy c = entity as PasserBy;
            if (c != null)
            {
                string sqlStr = $"UPDATE PasserBy  SET FirstName=@cName , LastName=@lName, Livingadress= @bName , [ Phone_Numer] = @hName WHERE ID=@id";
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
