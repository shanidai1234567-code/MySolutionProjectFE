using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public class CityDB: BaseDB
    {
        public new CityList SelectAll()
        {
            command.CommandText = $"SELECT * FROM City";
            CityList pList = new CityList(base.Select());
            return pList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            City p = entity as City;
            p.City_Name = reader["City_Name"].ToString();
        

            base.CreateModel(entity);
            return p;
        }
        public override BaseEntity NewEntity()
        {
            return new City();
        }
        static private CityList list = new CityList();
        public static City SelectById(int id)
        {
            CityDB db = new CityDB();
            list = db.SelectAll();

            City c = list.Find(item => item.Id == id);
            return c;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            City c = entity as City;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM City where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            City c = entity as City ;
            if (c != null)
            {
                string sqlStr = $"Insert INTO  City (CityName) VALUES (@cName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.City_Name));
              
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            City c = entity as City;
            if (c != null)
            {
                string sqlStr = $"UPDATE City  SET city_Name=@cName WHERE ID=@id";
                //   string sqlStr = $"UPDATE Person  SET FirstName=@cName,lastName=@lName,livingadress=@ladd WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.City_Name));
           
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }

    }
}
