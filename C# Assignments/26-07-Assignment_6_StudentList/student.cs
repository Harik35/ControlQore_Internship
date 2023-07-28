using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass_With_List
{
    public class student
    {
        public static int count = 1;
        public int Id { get; private set; }
        public string Name { get; set; }    
        public double Mark { get; set; }


        public student(string name, double mark) 
        {
            this.Id = count;
            this.Name = name;
            this.Mark = mark;
            
            count++;
        }

    }
}
