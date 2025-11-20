using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;  

namespace ViewModel
{
    public class VolunteerRespondDB : BaseDB
    {

        public new VolunteerRespondList SelectAll()
        {
            command.CommandText = $"SELECT * FROM VolunteerRespond ";
            VolunteerRespondList pList = new VolunteerRespondList(base.Select());
            return pList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            VolunteerRespond p = entity as VolunteerRespond;
            if (reader["ID_Report"] != DBNull.Value)
            {
                int reportId = Convert.ToInt32(reader["ID_Report"]);
                p.IdReport = ReportDB.SelectById(reportId); 
            }

            if (reader["ID_Volunteer"] != DBNull.Value)
            {
                int volunteerId = Convert.ToInt32(reader["ID_Volunteer"]);
                p.IdVol = VolunteerDB.SelectById(volunteerId); 
            }

            if (reader["Respond_status"] != DBNull.Value)
            {
                int statusId = Convert.ToInt32(reader["Respond_status"]);
                p.Repsond_status = StatusDB.SelectById(statusId); 
            }
            base.CreateModel(p);
            return p;
        }

        public override BaseEntity NewEntity()
        {
            return new VolunteerRespond();
        }
        static private VolunteerRespondList list = new VolunteerRespondList();
        public static VolunteerRespond SelectById(int id)
        {
            VolunteerRespondDB db = new VolunteerRespondDB();
            list = db.SelectAll();

            VolunteerRespond c = list.Find(item => item.Id == id);
            return c;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            VolunteerRespond c = entity as VolunteerRespond;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM VolunteerRespond where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            VolunteerRespond c = entity as VolunteerRespond;
            if (c != null)
            {
                string sqlStr = $"Insert INTO  VolunteerRespond (Description) VALUES (@cName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.IdVol));

            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            VolunteerRespond c = entity as VolunteerRespond;
            if (c != null)
            {
                string sqlStr = $" UPDATE VolunteerRespond  SET ID_Volunteer = @ID_Volunteer,   ID_Report = @ID_Report,   respond_status = @respond_status  WHERE Id = @Id" ;


                cmd.CommandText = sqlStr;

                cmd.Parameters.Add(new OleDbParameter("@ID_Volunteer", c.IdVol.Id));
                cmd.Parameters.Add(new OleDbParameter("@ID_Report", c.IdReport.Id));
                cmd.Parameters.Add(new OleDbParameter("@repsond_status", c.Repsond_status.Id));
                cmd.Parameters.Add(new OleDbParameter("@Id", c.Id));
            }
        }

    }
}

