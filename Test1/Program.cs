using Model;
using ViewModel;

namespace Test1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person p = PersonDB.SelectById(1);
            System.Console.WriteLine(p);

            VolunteerDB cdb = new();
            VolunteerList cList = cdb.SelectAll();

           

        }
    }
}
