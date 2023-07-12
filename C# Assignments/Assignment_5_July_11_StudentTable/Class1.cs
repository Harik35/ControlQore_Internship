using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace July_11_second
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mark { get; set; }

        public char Grade 
        {
            get 
            { 
                if (this.Mark >= 90)
                {
                    return 'A';
                }
                else if (this.Mark >= 80 && this.Mark < 90)
                {
                    return 'B';
                }
                else if (this.Mark >= 70 &&  this.Mark < 80)
                {
                    return 'C';
                }
                else
                {
                    return 'D';
                }
            }
        }
        public Student(int id, string name, int mark)
        {
            Id = id;
            Name = name;
            Mark = mark;
        }
        public void Display()
        {
            Console.WriteLine("Id is: "+ Id);
            Console.WriteLine("Name is: "+  Name);
            Console.WriteLine("Mark is: "+  Mark);
            Console.WriteLine("Grade is: "+ Grade);
        }
        
    }
}
