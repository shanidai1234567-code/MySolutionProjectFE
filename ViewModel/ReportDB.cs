using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;


namespace ViewModel
{
    public class ReportDB: BaseDB
    {
        public new ReportList SelectAll()
        {
            command.CommandText = $"SELECT Report.*\r\nFROM Report";
            ReportList pList = new ReportList(base.Select());
            return pList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Report p = entity as Report;

          
            p.Description = reader["Description"].ToString();
            p.Update_Time = Convert.ToDateTime(reader["Update_Time"]);

            p.PasserBy_ID = Convert.ToInt32(reader["PasserBy_ID"]);
            p.Location_X = Convert.ToDouble(reader["Location_X"]);
            p.Location_Y = Convert.ToDouble(reader["Location_Y"]);
          //  p.Photo_Optinal = reader["Photo_Optional"].ToString();
            p.HCategory = Help_CategoryDB.SelectById(Convert.ToInt32(reader["Help_Category"]));
            p.City_Num = CityDB.SelectById((int)reader["City_Num"]);


            base.CreateModel(entity);
            return p;
        }

        public override BaseEntity NewEntity()
        {
            return new Report();
        }
        static private ReportList list = new ReportList();
        public static Report SelectById(int id)
        {
            ReportDB db = new ReportDB();
            list = db.SelectAll();

            Report c = list.Find(item => item.Id == id);
            return c;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Report c = entity as Report;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM Report where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Report c = entity as Report;
            if (c != null)
            {
                string sqlStr = $"Insert INTO  Report (Description) VALUES (@cName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.Description));

            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Report c = entity as Report ;
            if (c != null)
            {
                string sqlStr = $"UPDATE Help_Category  SET Description=@cName WHERE ID=@id";
                //   string sqlStr = $"UPDATE Person  SET FirstName=@cName,lastName=@lName,livingadress=@ladd WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.Description));

                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
    }


}

