using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Person
    {
        public void Introduction(int age,string name)
        {
            Console.WriteLine("i am person"+name);
        }
        public string Introduction(string name,int age=0)
        {
            return "i am person"+name+age;
        }
    }
}
