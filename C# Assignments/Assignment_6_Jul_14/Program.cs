// See https://aka.ms/new-console-template for more information

using ConsoleApp9;

Employee employee1 = new Employee(1, "Hari", DateTime.Now, "Dev", 15000, 'P');
IBonusCalculator ibonus = null;
if (employee1.Jobtype == 'P')
{
    ibonus = new PermanentEmployeeBonusCalculator();
}
else if (employee1.Jobtype == 'C')
{
    ibonus = new ContractEmployeeBonusCalculator();
}

double bonusAmt = ibonus.CalculateBonus(employee1);
Console.WriteLine("Bonus amount:" + bonusAmt);