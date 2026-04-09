using Model;    
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
            command.CommandText = $"SELECT Admin.Admin_Pass, Admin.ID, Person.FirstName, Person.LastName, Person.PhoneNumber, Person.Street, Person.CityNum, Person.Pass, Person.StreetNumber\r\nFROM (Admin INNER JOIN\r\n  Person ON Admin.ID = Person.ID)";
            AdminList pList = new AdminList(base.Select());
            return pList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Admin p = entity as Admin;
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
                string sqlStr = $"Insert INTO  Admin (Admin_Pass) VALUES (@cName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.Admin_password));
           
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Admin c = entity as Admin;
            if (c != null)
            {
                string sqlStr = $"UPDATE Admin  SET Admin_password=@cName WHERE ID=@id";
                //   string sqlStr = $"UPDATE Person  SET FirstName=@cName,lastName=@lName,livingadress=@ladd WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.Admin_password));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));

            }
        }

        public override void Update(BaseEntity entity)
        {
            Admin Admin = entity as Admin;
            if (Admin != null)
            {
                updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }

        public virtual void Delete(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                deleted.Add(new ChangeEntity(this.CreateDeletedSQL, entity));
                deleted.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }

        public override void Insert(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                inserted.Add(new ChangeEntity(base.CreateInsertdSQL, entity));
                inserted.Add(new ChangeEntity(this.CreateInsertdSQL, entity));
            }
        }

    }
}

