// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the ConsoleApp");

Console.WriteLine("Enter the number: ");
int num  = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter the char0");
char letter  = Convert.ToChar(Console.ReadLine());


Console.WriteLine("Enter the Word/ Sentence");
string word = Console.ReadLine();

Console.WriteLine("Enter the boolean vale");
string temp = Console.ReadLine();

bool boole;

if (bool.TryParse(temp,out boole))
{
    Console.WriteLine("True");
}
else { Console.WriteLine("False"); }

string stay = Console.ReadLine(); //just to see the boolean value


