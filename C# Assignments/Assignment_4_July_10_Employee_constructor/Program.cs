using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1, "Peter Parker", 15000);
            employee.Display();
            Console.ReadLine();

        }
    }
}
