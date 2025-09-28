using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using ViewModel;
using System.Data.OleDb;

namespace ViewModel
{
    public class RegisteredDB : PersonDB
    {
     
        public RegisteredList SelectAll()
        {
            command.CommandText = $"SELECT Person.*, Registered.GroupActivity, Registered.MissedGA FROM  (Registered INNER JOIN   Person ON Registered.id = Person.Id)";
            RegisteredList pList = new RegisteredList(base.Select());
            return pList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Registered p = entity as Registered;
            p.GroupActivity = reader["GroupActivity"].ToString();
            p.Id = int.Parse(reader["id"].ToString());
            p.MissedGA = int.Parse(reader["MissedGA"].ToString());

          
            base.CreateModel(entity);
            return p;
        }
        public override BaseEntity NewEntity()
        {
            return new Registered();
        }
        static private RegisteredList list = new RegisteredList();
        public static Registered SelectById(int id)
        {
            RegisteredDB db = new RegisteredDB();
            list = db.SelectAll();

            Registered g = list.Find(item => item.Id == id);      
            return g;
        }

  
        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Registered c = entity as Registered;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM Registered where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Registered c = entity as Registered;
            if (c != null)
            {
                string sqlStr = $"Insert INTO  Registered (MissedGA) VALUES (@cName) " +
                    $"(GroupActivity) VALUES (@AName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.MissedGA));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Registered c = entity as Registered;
            if (c != null)
            {
                string sqlStr = $"UPDATE Registered  SET MissedGA = @cName, GroupActivity = @AName WHERE ID = @id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.MissedGA));
                command.Parameters.Add(new OleDbParameter("@AName", c.GroupActivity));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }

        public override void Update(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));

            }
        }
    }
}
