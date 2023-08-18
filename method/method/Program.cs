using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {
          Person p= new Person();
          p.name = "susu"; 
         
          Student s = new Student();
          s.name = "mama"; 

          s.roll = "UCSTGO-2962";
          s.Show();
          p.Show();
          Person.greeting();
        }
    }
}
