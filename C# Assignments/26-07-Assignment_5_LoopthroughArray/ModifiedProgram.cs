
// See https://aka.ms/new-console-template for more information

List<object> numArray2 = new List<object>();


int[] numArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

foreach (int num in numArray)
{
    numArray2.Add(num * 2);
}

numArray2.Add("Just Experimenting");

foreach (object num in numArray2)
{
    Console.WriteLine(num);
}

