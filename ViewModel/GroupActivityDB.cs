using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class GroupActivityDB: BaseDB
    {
        public GroupActivityList SelectAll()
        {
            command.CommandText = $"SELECT *FROM GroupActivity";

            GroupActivityList GroupActivityList = new GroupActivityList(base.Select());
            return GroupActivityList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            GroupActivity c = entity as GroupActivity;
            c.NameOfTheGroupActivity = reader["NameOfTheGroupActivity"].ToString();
            base.CreateModel(entity);
            return entity;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            GroupActivity c = entity as GroupActivity;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM GroupActivity where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            GroupActivity c = entity as GroupActivity;
            if (c != null)
            {
                string sqlStr = $"Insert INTO  GroupActivity (NameOfTheGroupActivity) VALUES (@cName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.NameOfTheGroupActivity));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            GroupActivity c = entity as GroupActivity;
            if (c != null)
            {
                string sqlStr = $"UPDATE GroupActivity  SET NameOfTheGroupActivity=@cName  WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.NameOfTheGroupActivity));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }

        public override BaseEntity NewEntity()
        {
            return new GroupActivity();
        }
    }
}
