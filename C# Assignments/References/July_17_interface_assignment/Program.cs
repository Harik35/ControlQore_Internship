using July_17_INTERFACE_ASSIGNMENT;

Employee employee1 = new Employee(1, "Hari",DateTime.UtcNow, "Developer", 15000, 'C' );
IBonusCalculator bonus;
if ( employee1.JobType == 'P')
{
    bonus = new PermanentEmployeeBonusCalculator();
}
else if ( employee1.JobType == 'C')
{
    bonus = new ContractEmployeeBonusCalculator();
}
else
{
    Console.WriteLine("Invalid data entered");
}

