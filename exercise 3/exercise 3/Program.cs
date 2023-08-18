using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int rows=5;
            for (i = 0; i<rows;i++ )
            {
                for (j = 0; j < i;j++ )
                {
                    Console.Write("2");

                }
             // i=0  // 22222
             // i=1 // 2222
                Console.WriteLine("\n");
                
            }
        }
    }
}
