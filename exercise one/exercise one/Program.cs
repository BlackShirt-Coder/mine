using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int i, j;
            int rows = int.Parse(Console.ReadLine());
            for(i=0;i<5;i++){
                for (j = 0; j < 5 - i; j++)
                {
                    Console.Write(rows);
                }
                Console.WriteLine();
            }
        }
    }
}
