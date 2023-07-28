// See https://aka.ms/new-console-template for more information



using StudentClass_With_List;

student std1 = new student("John Doe", 85);
student std2 = new student("Liam Smith", 70);
student std3 = new student("Mary James", 62);
student std4 = new student("Davide James", 55);
student std5 = new student("Lionel Messi", 100);
student std6 = new student("Ronaldo", 90);
student std7 = new student("Neymar", 85);
student stdtemp = new student(" ", 0);


List<student> students = new List<student>();
students.Add(std1);
students.Add(std2);
students.Add(std3);    
students.Add(std4);
students.Add(std5);    
students.Add(std6);
students.Add(std7);


//foreach (student student in students)
//{
//    Console.WriteLine(student.Name);
//}
double maxMark = 0;
student Topper = stdtemp;
student Messi = stdtemp;
string TopperName = " ";

Console.WriteLine($"Topper name using class variable is {Topper.Name}");
Console.WriteLine($"Topper name stored by foreach loop is {TopperName}");
Console.WriteLine($"Topper mark using class variable is {maxMark}");


List<student> studentGreaterThan75 = new List<student>();
List<student> studentNameEnd_S = new List<student>();

foreach (student student in students)
{
    if (student.Mark >= maxMark)
    {
        maxMark = student.Mark;
        Topper = student;
        TopperName = student.Name;

    }

    if (student.Mark > 75)
    {
        studentGreaterThan75.Add(student);
    }

    if (student.Name[(student.Name.Length) - 1] == 's')
    {
        studentNameEnd_S.Add(student);
    }

    if (student.Name == "Lionel Messi")
    {
        Messi = student;
    }
}

Console.WriteLine("\nStudents with greater than 75 mark are: \n");
foreach (student student in studentGreaterThan75)
{
    Console.WriteLine(student.Name);
}


Console.WriteLine("\nStudent whose name ends with ‘s’are: \n");
foreach (student student in studentNameEnd_S)
{
    Console.WriteLine(student.Name);
}

Console.WriteLine($"\nDetails of Student with name 'Messi' is Name: {Messi.Name}, Id: {Messi.Id}, Mark: {Messi.Mark}");





