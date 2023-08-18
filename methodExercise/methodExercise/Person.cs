using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExercise
{
    class Person
    {
        public string name;
        public void Show()
        {
            Console.WriteLine("Name is "+name);
        }
        public void  greeting(){
            Console.WriteLine("Hello"+name);
        }
    }
}
