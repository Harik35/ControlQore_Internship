using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee1
{
    public class Employee
    {
        public int Id;
        public string Name;
        public double Salary;

        public Employee(int id)
        {
            Id = id;
        }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void Display()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Salary: " + Salary);
        }
    }

}