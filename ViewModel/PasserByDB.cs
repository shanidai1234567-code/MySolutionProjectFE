using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class PasserByDB : PersonDB
    {
        public new PasserByList SelectAll()
        {
            command.CommandText = $"SELECT PasserBy.ID, PasserBy.Help_Category, PasserBy.JoinDate, Person.FirstName, Person.LastName, Person.PhoneNumber, Person.Street, Person.CityNum, Person.Pass, Person.StreetNumber\r\nFROM (PasserBy INNER JOIN\r\n Person ON PasserBy.ID = Person.ID)";
            PasserByList pList = new PasserByList(base.Select());
            return pList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            PasserBy p = entity as PasserBy;
            p.JoinDate = Convert.ToDateTime(reader["JoinDate"]);
            p.Help_Category = Help_CategoryDB.SelectById((int)reader["Help_Category"]);

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

        public override void Insert(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                inserted.Add(new ChangeEntity(base.CreateInsertdSQL, entity));
                inserted.Add(new ChangeEntity(this.CreateInsertdSQL, entity));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            PasserBy c = entity as PasserBy;
            if (c != null)
            {
                string sqlStr = $"Insert INTO  PasserBy (id, Help_Category, JoinDate) VALUES (@id, @cName,  @JoinDate)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
                command.Parameters.Add(new OleDbParameter("@cName", c.Help_Category.Id));

                OleDbParameter oleDbParameter = new OleDbParameter("@JoinDate", OleDbType.DBDate);
                oleDbParameter.Value = c.JoinDate;
                command.Parameters.Add(oleDbParameter);

               


            }
        }

        

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            PasserBy c = entity as PasserBy;
            if (c != null)
            {
                string sqlStr = $"UPDATE PasserBy  SET Help_Category=@cName , JoinDate=@lName WHERE ID=@id";
                //   string sqlStr = $"UPDATE Person  SET FirstName=@cName,lastName=@lName,livingadress=@ladd WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.Help_Category.Id));
                command.Parameters.Add(new OleDbParameter("@lName", c.JoinDate));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
        public override void Update(BaseEntity entity)
        {
            PasserBy PasserBy = entity as PasserBy;
            if (PasserBy != null)
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


 
    }
}
