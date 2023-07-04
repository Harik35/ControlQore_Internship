// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter the Word");
string word = Console.ReadLine();
Console.WriteLine("Enter the number");
int.TryParse(Console.ReadLine(), out int num);
Console.WriteLine("Enter the Charectetr");
char.TryParse(Console.ReadLine(), out char letter);
Console.WriteLine("Enter the boolean");
bool.TryParse(Console.ReadLine(),out bool valu);


Console.WriteLine(word);
Console.WriteLine(num);
Console.WriteLine(letter);
Console.WriteLine(valu);

string write = Console.ReadLine();
