using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class Student:Person
    {
        public string roll;
        public new void Show()
        {
            Console.WriteLine("Name from student"+name); //mama
            Console.WriteLine("Roll No "+roll);
        }
    }
}
