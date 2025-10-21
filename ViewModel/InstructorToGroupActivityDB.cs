using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class InstructorToGroupActivityDB : BaseDB
    {
       
            public ReportList SelectAll()
            {
                command.CommandText = $"SELECT * FROM InstructorToGroupActivity";
            ReportList groupList = new ReportList(base.Select());
                return groupList;
            }

            protected override BaseEntity CreateModel(BaseEntity entity)
            {
            InstructorToGroupActivity ct = entity as InstructorToGroupActivity;
                //ct.InstructorToGroupActivityName = reader["InstructorToGroupActivityName"].ToString();
                base.CreateModel(entity);
                return ct;
            }
            public override BaseEntity NewEntity()
            {
                return new InstructorToGroupActivity();
            }
            static private ReportList list = new ReportList();

            public static InstructorToGroupActivity SelectById(int id)
            {
            InstructorToGroupActivityDB db = new InstructorToGroupActivityDB();
                list = db.SelectAll();

            InstructorToGroupActivity g = list.Find(item => item.Id == id);
                return g;
            }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            InstructorToGroupActivity c = entity as InstructorToGroupActivity;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM InstructorToGroupActivity where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            InstructorToGroupActivity c = entity as InstructorToGroupActivity;
            if (c != null)
            {
                string sqlStr = $"Insert INTO  InstructorToGroupActivity (IdInstructor) VALUES (@cName), (IdGroupActivity) VALUES (@AName)";
                //person name??
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.IdInst.Id));
                command.Parameters.Add(new OleDbParameter("@AName", c.IdClass.Id));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            InstructorToGroupActivity c = entity as InstructorToGroupActivity;
            if (c != null)
            {
                string sqlStr = $"UPDATE InstructorToGroupActivity  SET IdInstructor=@cName , IdGroupActivity=@AName WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.IdInst.Id));
                command.Parameters.Add(new OleDbParameter("@AName", c.IdClass.Id));
                //person name??
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
    }
}
