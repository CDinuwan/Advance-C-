using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Chanuka";
            string lastName;

            int age = 15;
            int OldAge;

            var Name = "chanuka";//AnyType
            //Implicit writing variable should be assign when we create it.
            Console.WriteLine(Name);
            //Cannot assign null for Implicit type variable.
            var StringBuilder = new StringBuilder();

            Console.ReadLine();
        }
    }
}
