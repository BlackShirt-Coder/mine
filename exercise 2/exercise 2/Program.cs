using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius");
            float radius = Convert.ToSingle(Console.ReadLine());
            float pi = 3.1415926535f;
            float area = 4 * pi * (radius * radius);
            Console.WriteLine("Area is " + area);
        }
    }
}
