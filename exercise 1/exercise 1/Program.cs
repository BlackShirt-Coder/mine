using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
         
             
            Console.WriteLine("Enter UserName");
           string userName= Console.ReadLine();
           Console.WriteLine("Enter Age");
           int age = int.Parse(Console.ReadLine());
           Console.WriteLine("Name is "+userName+" and "+age+" Years Old" );

        }
    }
}
