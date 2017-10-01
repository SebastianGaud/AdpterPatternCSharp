using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdpterPatternCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact c = new Customer("Riccardo Golia");

            Console.WriteLine(c.FullName);

            Contact e = new EmployeeAdapter( new Employee("Riccardo", "Golia"));

            Console.WriteLine(e.FullName);

        }
    }
}
