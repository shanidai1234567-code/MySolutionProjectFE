using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using ViewModel;


namespace test
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Instructor ins = new Instructor();
            InstructorList cList = cdb.SelectAll();
            Foreach(Instructor ins in cList)
          Console.WriteLine(ins.instructorName);

            PersonDB pdb = new();
            PersonList pList = pdb.SelectAll();
            foreach (Person c in pList)
                Console.WriteLine(c.FirstName);

        }
    }
}
