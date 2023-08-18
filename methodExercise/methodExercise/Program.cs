using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p=new Person();
            p.name = "susu";
            Student s = new Student();
            s.name = "mgmg";
            s.rollNumber = "34";
            s.Show();
            p.Show();
            p.greeting();
        }
    }
}
