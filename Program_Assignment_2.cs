// See https://aka.ms/new-console-template for more information

//Project_1
using System.Reflection.Emit;

for (int i = 0; i < 20; i++)
{
    Console.WriteLine(i+1);
}


//Project_2
int num = 0;
while (num < 50)
{
    if (num % 2 != 0)
    {
        Console.WriteLine(num);
    }
    num++;
}

//Project_3
int num1, num2, num3;
Console.WriteLine("Enter thr first Number:");
int.TryParse(Console.ReadLine(), out num1);
Console.WriteLine("Enter the Second Number");
int.TryParse(Console.ReadLine(), out num2);
Console.WriteLine("Enter the Third Number");
int.TryParse(Console.ReadLine(), out num3);

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine(num1 + " is larger one");
}
else if (num1 < num2 && num3 < num2)
{
    Console.WriteLine(num2 + " is larger one");
}
else
{
    Console.WriteLine(num3 + " is larger one");
}



//Project_4
Console.WriteLine("Enter the number:");
int.TryParse(Console.ReadLine(), out num);
int reminder = 0;
while (num != 0)
{
    reminder *= 10;
    reminder = (reminder + (num % 10));
    num = num/10;

}
Console.WriteLine(reminder);



//Project_5

Console.WriteLine("Enter the number:");
int.TryParse(Console.ReadLine(), out num);
int sum = 0;
while (num != 0)
{
    sum += num % 10;
    num /= 10;
}
Console.WriteLine(sum);



//Project_6

Console.WriteLine("Enter the number:");
int.TryParse(Console.ReadLine(), out num);
int rem = 0;
while (num != 0)
{
    rem = num % 10;
    sum += (rem * rem);
    num = num / 10;
}
Console.WriteLine(sum);


//Project_7
bool rem_bool = true;
Console.WriteLine("Enter the number:");
int.TryParse(Console.ReadLine(), out num);
for (int i = 2; i < num; i++)
{
    if (num%i == 0)
    {
        rem_bool = false;
        Console.WriteLine("Number is not a prime number");
        break;
    }
}
if (rem_bool)
{
    Console.WriteLine("Number is a prime number");
}


//Project_8

for  (int i = 1; i < 100; i++)
{
    rem_bool = true;
    for (int j = 2; j < i/2; j++)
    {
        if (i % j == 0)
        {
            rem_bool = false;
            break;
            
        }
        
    }
    if (rem_bool)
    {
        Console.WriteLine(i);
    }

}


//Project_9
Console.WriteLine("Enter the number upto which Fibinacci Series wanted:");
int.TryParse(Console.ReadLine(), out num);
num1 = 0;
num2 = 1;
int fib = 0;
for (int i = 2; fib < num; i++)
{
    Console.WriteLine(fib);
    fib = num1 + num2;
    num1 = num2;
    num2 = fib;
}


//Project_10
int temp;
Console.WriteLine("Enter the number:");
int.TryParse(Console.ReadLine(), out num);
temp = num;
reminder = 0;
while (num != 0)
{
    reminder *= 10;
    reminder = (reminder + (num % 10));
    num = num / 10;

}
if (reminder == temp)
{
    Console.WriteLine("The number is Pallindrome");
}
else
{
    Console.WriteLine("Number is not pallindrome");
}



//Project_11
Console.WriteLine("Enter the amount:");
int.TryParse(Console.ReadLine(), out num);
float tax_percent = 5, tax_amount = 0;
if (num < 10000)
{
    tax_percent = 5;
}
else if (num > 10000 && num < 15000)
{
    tax_percent = 7.5f;
}
else if (num  > 15000 && num < 20000)
{
    tax_percent = 10;
}
else if (num > 20000 && num < 25000)
{
    tax_percent = 12.5f;
}
else if (num > 25000)
{
    tax_percent = 15;
}

tax_amount = num * (tax_percent / 100);
Console.WriteLine("tax amount is " + tax_amount);



//Program_12
char Option;
Console.WriteLine("Enter the amount:");
char.TryParse(Console.ReadLine(), out Option);
switch (Option)
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
        Console.WriteLine("Invalid input, Please try again");
        break;
}


//Program_13
int line;
Console.WriteLine("Enter the number of Lines required:");
int.TryParse(Console.ReadLine(), out line);
for (int i = 0; i < line; i++)
{
    for (int j = 0; j < i ; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine("\n");
}









