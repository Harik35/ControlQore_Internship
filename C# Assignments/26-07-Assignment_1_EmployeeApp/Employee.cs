using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Employee.App
{
    public class Employee
    {
        public static int empNo = 1000;
        public string empID { get; private set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string EmployeeType { get; set; }

        public  Employee(string name, double salary, string empType) 
        {
            empID = "Emp" + empNo;
            Name = name;
            Salary = salary;
            EmployeeType = empType;
            empNo++;
        }


        public void Display()
        {
            Console.WriteLine(empID);
        }
        public static void DisplayNo() 
        {
            Console.WriteLine($"Total Number of Employees:{empNo-1000} ");
        }
    }
}
