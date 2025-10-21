using Model;
using ViewModel;

namespace Test1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //PersonDB cdb = new();
            //PersonList PList = cdb.SelectAll(); //person
            //foreach (Person c in PList)
            //    Console.WriteLine(c);

            //Person personToUpdate = PList[0];
            //personToUpdate.FirstName += "whatever3";
            //personToUpdate.LivingAdress+= "whatever1";
            //personToUpdate.TelNum += "00000000000";
            //personToUpdate.LastName += "whatever2";
            //cdb.Update(personToUpdate);
            //int x = cdb.SaveChanges();
            //Console.WriteLine($"{x} rows were updated");


            //GroupActivityDB AG = new();
            //GroupActivityList ListAG = AG.SelectAll(); //GroupActivity
            //foreach (GroupActivity c in ListAG)
            //    Console.WriteLine(c);

            //InstructorDB Ins = new();
            //InstructorList IList = Ins.SelectAll(); //instructor
            //foreach (Instructor c in IList)
            //Console.WriteLine(c);


            //InstructorToGroupActivityDB AG2 = new();
            //InstructorToGroupActivityList ListAG2 = AG2.SelectAll(); //InstructorToGroupActivity
            //foreach (InstructorToGroupActivity c in ListAG2)
            //    Console.WriteLine(c);

            RegisteredDB Reg = new();
            VolunteerList ListR = Reg.SelectAll(); //Registered
            foreach (Registered c in ListR)
                Console.WriteLine(c);

            Registered RegisteredToUpdate = ListR[0];
            RegisteredToUpdate.FirstName += "whatever3";
            RegisteredToUpdate.LivingAdress += "whatever1";
            RegisteredToUpdate.TelNum += "00000000000";
            RegisteredToUpdate.LastName += "whatever2";
            Reg.Update(RegisteredToUpdate);
            int x = Reg.SaveChanges();


            VolunteerList List = Reg.SelectAll(); //Registered
            foreach (Registered c in List)
                Console.WriteLine(c);


            //PersonDB pdb = new();
            //PersonList pList = pdb.SelectAll();
            //foreach (Person c in pList)
            //Console.WriteLine(c.FirstName);
            //Console.WriteLine("Hello, World!");
        }
    }
}
