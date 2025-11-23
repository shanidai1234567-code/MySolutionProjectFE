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
            command.CommandText = $"SELECT * FROM Report";
            ReportList pList = new ReportList(base.Select());
            return pList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Report p = entity as Report;
            p.Description = reader["Description"].ToString();
            p.Location_X = Convert.ToDouble( reader["Location_X"]);
            p.Location_Y = Convert.ToDouble(reader["Location_Y"]);
            p.Update_Time = Convert.ToDateTime(reader["Update_Time"]);
            p.PasserBy_ID = Convert.ToInt32(reader["PasserBy_ID"]);
            p.HCategory = Help_CategoryDB .SelectById( Convert.ToInt32( reader["Help_Category"]));
            p.City_Num = CityDB.SelectById(Convert.ToInt32(reader["City_Num"]));
            p.Photo_Optinal = reader["Photo_Optinal"].ToString();
            
            //p.Id = reader["ID"].ToString();

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
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand command)
        {
            Report c = entity as Report;
            if (c != null)
            {
                string sqlStr =
                    "INSERT INTO Report " +
                    "       (Description, PasserBy_ID, Help_Category, City_Num, Location_X, Location_Y, Update_Time, Photo_Optinal) " +
                    "VALUES (@Description, @PasserBy_ID, @Help_Category, @City_Num, @Location_X, @Location_Y, @Update_Time, @Photo_Optinal)";

                command.CommandText = sqlStr;

                command.Parameters.Add(new OleDbParameter("@Description", c.Description));
                command.Parameters.Add(new OleDbParameter("@PasserBy_ID", c.PasserBy_ID));
                command.Parameters.Add(new OleDbParameter("@Help_Category", c.HCategory.Id));
                command.Parameters.Add(new OleDbParameter("@City_Num", c.City_Num.Id));
                command.Parameters.Add(new OleDbParameter("@Location_X", c.Location_X));
                command.Parameters.Add(new OleDbParameter("@Location_Y", c.Location_Y));
                command.Parameters.Add(new OleDbParameter("@Update_Time", c.Update_Time));

                // Handle nullable photo field
                command.Parameters.Add(new OleDbParameter("@Photo_Optinal",
                    c.Photo_Optinal ?? (object)DBNull.Value));
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

