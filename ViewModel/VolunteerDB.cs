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
    public class VolunteerDB: PersonDB
    {
 
        public new VolunteerList SelectAll()
        {
            command.CommandText = $"SELECT Person.ID, Person.FirstName, Person.LastName, Person.PhoneNumber, Person.CityNum," +
                $" Person.Street, Person.Pass, Person.StreetNumber, Volunteer.StoreOpeningTime," +
                $" Volunteer.JoinDate, Volunteer.StoreClosingTime, \r\n Volunteer.Location_X," +
                $" Volunteer.Location_Y, Volunteer.Help_Category\r\nFROM (Person INNER JOIN\r\n " +
                $"Volunteer ON Person.ID = Volunteer.ID)";
            VolunteerList pList = new VolunteerList(base.Select());
            return pList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Volunteer p = entity as Volunteer;

            //p.FirstName = reader["FirstName"].ToString();
            //p.LastName = reader["LastName"].ToString();
            //p.Phone_Numer = reader["telephone num"].ToString();
            //p.LivingAdress = reader["LivingAdress"].ToString();
            //p.Street = reader["street"].ToString();
            //p.StreetNumber = Convert.ToInt32(reader["streetNumber"]);
            //p.City_Num = CityDB.SelectById((int)reader["CityNumber"]);
            //p.Pass = reader["pass"].ToString();

            p.StoreOpeningTime = Convert.ToDateTime(reader["StoreOpeningTime"]);
            p.StoreClosingTime = Convert.ToDateTime(reader["StoreClosingTime"]);
            p.JoinDate = Convert.ToDateTime(reader["JoinDate"]);
            p.Location_X = Convert.ToDouble(reader["Location_X"]);
            p.Location_Y = Convert.ToDouble(reader["Location_Y"]);
            p.Help_Category = Help_CategoryDB.SelectById(Convert.ToInt32(reader["Help_Category"].ToString()));
          

            base.CreateModel(entity);
            return p;
        }
        public override BaseEntity NewEntity()
        {
            return new Volunteer();
        }
        static private VolunteerList list = new VolunteerList();
        public static Volunteer SelectById(int id)
        {
            VolunteerDB db = new VolunteerDB();
            list = db.SelectAll();

            Volunteer c = list.Find(item => item.Id == id);
            return c;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Volunteer c = entity as Volunteer;
            if (c != null)
            {
                string sqlStr = $"DELETE FROM Volunteer where id=@pid";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Volunteer c = entity as Volunteer;
            if (c != null)
            {
                string sqlStr = $"Insert INTO  Volunteer (StoreClosingTime, StoreOpeningTime, JoinDate, HelpCategory,LocationX, LocationY) VALUES (@cName)";

                command.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@StoreClosingTime", c.StoreClosingTime));
                cmd.Parameters.Add(new OleDbParameter("@StoreOpeningTime", c.StoreOpeningTime));
                cmd.Parameters.Add(new OleDbParameter("@JoinDate", c.JoinDate));
                cmd.Parameters.Add(new OleDbParameter("@HelpCategory", c.Help_Category));
                cmd.Parameters.Add(new OleDbParameter("@LocationX", c.Location_X));
                cmd.Parameters.Add(new OleDbParameter("@LocationY", c.Location_Y));

            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Volunteer c = entity as Volunteer;
            if (c != null)
            {
                string sqlStr = @"UPDATE Volunteer 
                          SET StoreClosingTime = @StoreClosingTime, 
                              StoreOpeningTime = @StoreOpeningTime, 
                              JoinDate = @JoinDate, 
                              Help_Category = @HelpCategory, 
                              Location_X = @LocationX, 
                              Location_Y = @LocationY 
                          WHERE ID = @Id";

                cmd.CommandText = sqlStr;

                cmd.Parameters.Add(new OleDbParameter("@StoreClosingTime", c.StoreClosingTime));
                cmd.Parameters.Add(new OleDbParameter("@StoreOpeningTime", c.StoreOpeningTime));
                cmd.Parameters.Add(new OleDbParameter("@JoinDate", c.JoinDate));
                cmd.Parameters.Add(new OleDbParameter("@HelpCategory", c.Help_Category.Id));
                cmd.Parameters.Add(new OleDbParameter("@LocationX", c.Location_X));
                cmd.Parameters.Add(new OleDbParameter("@LocationY", c.Location_Y));
                cmd.Parameters.Add(new OleDbParameter("@Id", c.Id));
            }
        }


        public override void Update(BaseEntity entity)
        {
            Volunteer Volunteer = entity as Volunteer;
            if (Volunteer != null)
            {
                updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }

        public override void Insert(BaseEntity entity)
        {
              BaseEntity reqEntity = this.NewEntity();
            if (entity != null & entity.GetType()==reqEntity.GetType())
            {
                inserted.Add(new ChangeEntity(base.CreateInsertdSQL, entity));
                inserted.Add(new ChangeEntity(this.CreateInsertdSQL, entity));
            }
        }

        public virtual void Delete(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                deleted.Add(new ChangeEntity(this.CreateDeletedSQL, entity));
                deleted.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }


    }
}
