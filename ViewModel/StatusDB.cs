using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;

namespace ViewModel
{
    public class StatusDB/*: BaseDB*/
    {
        //public new StatusList SelectAll()
        //{
        //    command.CommandText = $"SELECT * FROM Status";
        //    StatusList pList = new StatusList(base.Select());
        //    return pList;
        //}

        //protected override BaseEntity CreateModel(BaseEntity entity)
        //{
        //    Help_Category p = entity as Help_Category;
        //    p.Description = reader["Description"].ToString();
        //    //p.Id = reader["ID"].ToString();

        //    base.CreateModel(entity);
        //    return p;
        //}
        //public override BaseEntity NewEntity()
        //{
        //    return new Help_Category();
        //}
        //static private StatusList list = new StatusList();
        //public static Help_Category SelectById(int id)
        //{
        //    Help_CategoryDB db = new Help_CategoryDB();
        //    list = db.SelectAll();

        //    Help_Category c = list.Find(item => item.Id == id);
        //    return c;
        //}

        //protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        //{
        //    Help_Category c = entity as Help_Category;
        //    if (c != null)
        //    {
        //        string sqlStr = $"DELETE FROM Help_Category where id=@pid";

        //        command.CommandText = sqlStr;
        //        command.Parameters.Add(new OleDbParameter("@pid", c.Id));
        //    }
        //}
        //protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        //{
        //    Help_Category c = entity as Help_Category;
        //    if (c != null)
        //    {
        //        string sqlStr = $"Insert INTO  Help_Category (Description) VALUES (@cName)";

        //        command.CommandText = sqlStr;
        //        command.Parameters.Add(new OleDbParameter("@cName", c.Description));

        //    }
        //}

        //protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        //{
        //    Help_Category c = entity as Help_Category;
        //    if (c != null)
        //    {
        //        string sqlStr = $"UPDATE Help_Category  SET Description=@cName WHERE ID=@id";
        //        //   string sqlStr = $"UPDATE Person  SET FirstName=@cName,lastName=@lName,livingadress=@ladd WHERE ID=@id";

        //        command.CommandText = sqlStr;
        //        command.Parameters.Add(new OleDbParameter("@cName", c.Description));

        //        command.Parameters.Add(new OleDbParameter("@id", c.Id));
        //    }
        //}
    }
}
