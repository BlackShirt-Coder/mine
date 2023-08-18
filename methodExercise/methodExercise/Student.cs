using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExercise
{
    class Student:Person
    {
        public string rollNumber;
        public new void Show()
        {
            Console.WriteLine("Name"+name);
            Console.WriteLine("roll number" + rollNumber);

        }
    }
}
