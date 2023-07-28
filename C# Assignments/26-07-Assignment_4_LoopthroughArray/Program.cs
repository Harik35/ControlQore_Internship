
// See https://aka.ms/new-console-template for more information

List<int> numArray2 = new List<int>();


int[] numArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

foreach (int num in numArray)
{
    numArray2.Add(num * 2);
}

foreach (int num in numArray2)
{
    Console.WriteLine(num);
}
