using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class InstructorDB: BaseDB
    {
        public InstructorList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Instructor";
            InstructorList groupList = new InstructorList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Instructor Ins = entity as Instructor;
            Ins.Id = int.Parse(reader["Id"].ToString());
            Ins.TeachesGroupActivity = reader["teachesGroupActivity"].ToString();
            Ins.StartDate = DateTime.Parse(reader["StartDate"].ToString());
            base.CreateModel(entity);
            return Ins;
        }
        public override BaseEntity NewEntity()
        {
            return new Instructor();
        }
        static private InstructorList list = new InstructorList();

        public static Instructor SelectById(int id)
        {
            InstructorDB db = new InstructorDB();
            list = db.SelectAll();

            Instructor g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Person c = entity as Person;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM Instructor where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Instructor c = entity as Instructor;
            if (c != null)
            {
                string sqlStr = $"Insert INTO  Instructor (TeachesGroupActivity) VALUES (@cName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.TeachesGroupActivity));
                command.Parameters.Add(new OleDbParameter("@AName", c.StartDate));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Instructor c = entity as Instructor;
            if (c != null)
            {
                string sqlStr = $"UPDATE Instructor  SET TeachesGroupActivity=@cName , StartDate=@AName WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.TeachesGroupActivity));
                command.Parameters.Add(new OleDbParameter("@AName", c.StartDate));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
    }
}
