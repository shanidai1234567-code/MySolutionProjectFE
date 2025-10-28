using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    public class StatusDB :BaseDB
    {
        public new StatusList SelectAll()
        {
            command.CommandText = $"SELECT Status.*\r\nFROM Status";
            StatusList pList = new StatusList(base.Select());
            return pList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Status p = entity as Status;
            p.Description = reader["Description"].ToString();
       
            //p.Id = reader["ID"].ToString();

            base.CreateModel(entity);
            return p;
        }
        public override BaseEntity NewEntity()
        {
            return new Status();
        }
        static private StatusList list = new StatusList();
        public static Status SelectById(int id)
        {
            StatusDB db = new StatusDB();
            list = db.SelectAll();

            Status c = list.Find(item => item.Id == id);
            return c;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Status c = entity as Status;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM Status where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Status c = entity as Status;
            if (c != null)
            {
                string sqlStr = $"Insert INTO  Status (Description) VALUES (@cName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.Description));

            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Status c = entity as Status;
            if (c != null)
            {
                string sqlStr = $"UPDATE Status  SET Description=@cName WHERE ID=@id";
                //   string sqlStr = $"UPDATE Person  SET FirstName=@cName,lastName=@lName,livingadress=@ladd WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.Description));

                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
    }
}
