using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace July_17_INTERFACE_ASSIGNMENT
{
    public interface IBonusCalculator
    {
        double CalculateBonus(Employee employee1);
    }

    public class PermanentEmployeeBonusCalculator : IBonusCalculator
    {
        public double CalculateBonus(Employee employee1)
        {
            return employee1.Salary * 0.2;
        }
        
    }
    
    public class ContractEmployeeBonusCalculator: IBonusCalculator
    {
        public  double CalculateBonus(Employee employee1)
        {
       
            return employee1.Salary * 0.15;
        }
    }

        
    
}
