using SportsName;



Console.WriteLine("Enter the code for sports Name:");
char.TryParse(Console.ReadLine(), out char customName);


try
{
    switch (customName)
    {
        case 'c':
            Console.WriteLine("Cricket");
            break;
        case 'f':
            Console.WriteLine("Football");
            break;
        case 'h':
            Console.WriteLine("Hockey");
            break;
        case 't':
            Console.WriteLine("Tennis");
            break;
        case 'b':
            Console.WriteLine("Badminton");
            break;
        default:
            throw new CustomException("Invalid entry, please enter any of the following option (c,f,h,t,b)");
    }
}
catch(CustomException msg)
{ Console.WriteLine(msg.ToString()); }