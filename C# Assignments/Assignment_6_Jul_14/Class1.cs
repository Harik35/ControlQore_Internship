using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoin { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public char Jobtype { get; set; }
        public Employee(int id, string name, DateTime datetime, string dept, double salary, char jobtype)
        {
            Id = id;
            Name = name;
            DateOfJoin = datetime;
            Department = dept;
            Salary = salary;
            Jobtype = jobtype;
        }
    }
    interface IBonusCalculator
    {
        double CalculateBonus(Employee employee1);
    }
    class PermanentEmployeeBonusCalculator : IBonusCalculator
    {
        public double CalculateBonus(Employee employee1)
        {
            return 0.2 * employee1.Salary;
        }
    }
    class ContractEmployeeBonusCalculator : IBonusCalculator
    {
        public double CalculateBonus(Employee employee1)
        {
            return 0.15 * employee1.Salary;
        }
    }
}