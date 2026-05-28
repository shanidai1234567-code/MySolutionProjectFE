using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    public class ReportDB : BaseDB
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
            p.Location_X = Convert.ToDouble(reader["Location_X"]);
            p.Location_Y = Convert.ToDouble(reader["Location_Y"]);
            p.Update_Time = Convert.ToDateTime(reader["Update_Time"]);
            p.PasserBy_ID = PasserByDB.SelectById(Convert.ToInt32(reader["PasserBy_ID"]));
            p.HCategory = Help_CategoryDB.SelectById(Convert.ToInt32(reader["Help_Category"]));
            p.City_Num = CityDB.SelectById(Convert.ToInt32(reader["City_Num"]));
            p.Photo_Optinal = reader["Photo_Optinal"].ToString();

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
            if (list.Count == 0)
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

                // הוספת הפרמטרים בדיוק לפי סדר הופעתם בשאילתה (קריטי עבור Access)
                command.Parameters.Add(new OleDbParameter("@Description", c.Description ?? ""));
                command.Parameters.Add(new OleDbParameter("@PasserBy_ID", c.PasserBy_ID?.Id ?? 0));
                command.Parameters.Add(new OleDbParameter("@Help_Category", c.HCategory?.Id ?? 0));
                command.Parameters.Add(new OleDbParameter("@City_Num", c.City_Num?.Id ?? 0));
                command.Parameters.Add(new OleDbParameter("@Location_X", c.Location_X));
                command.Parameters.Add(new OleDbParameter("@Location_Y", c.Location_Y));

                OleDbParameter oleDbParameter = new OleDbParameter("@Update_Time", OleDbType.DBDate);
                oleDbParameter.Value = c.Update_Time == DateTime.MinValue ? DateTime.Now : c.Update_Time;
                command.Parameters.Add(oleDbParameter);

                // פרמטר התמונה מופיע פעם אחת בלבד בסוף
                command.Parameters.Add(new OleDbParameter("@Photo_Optinal", c.Photo_Optinal ?? (object)DBNull.Value));
            }
        }

        /// <summary>
        /// תיקון מנגנון העדכון: מעדכן את טבלת Report, כולל תאריך עדכון וסטטוס
        /// </summary>
        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Report c = entity as Report;
            if (c != null)
            {
                // שאילתת עדכון נכונה לטבלת Report
                // משנה את תאריך העדכון לזמן הנוכחי ומעדכן את הסטטוס (בהנחה ששם העמודה ב-Access הוא Help_Category או שיש לך עמודת סטטוס ייעודית)
                string sqlStr = "UPDATE Report SET Description=@Description, Update_Time=@UpdateTime WHERE ID=@id";

                command.CommandText = sqlStr;

                command.Parameters.Add(new OleDbParameter("@Description", c.Description));

                OleDbParameter timeParam = new OleDbParameter("@UpdateTime", OleDbType.DBDate);
                timeParam.Value = DateTime.Now; // מעדכן אוטומטית לתאריך והשעה של עכשיו
                command.Parameters.Add(timeParam);

                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
    }
}