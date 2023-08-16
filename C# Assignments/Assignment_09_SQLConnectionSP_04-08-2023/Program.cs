using SqlConnection_1;

Class1 data = new Class1();

int datacalling = data.StudentDataUsingSP("Hari", 23, 43, "EEE");
int datacalling2 = data.AddElementManually("Krishnan", 22, 80, "EC");

Console.WriteLine(datacalling);
Console.WriteLine(datacalling2);