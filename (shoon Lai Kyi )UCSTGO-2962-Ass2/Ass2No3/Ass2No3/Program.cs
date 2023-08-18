using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass2No3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, sum = 0, n;
            int[,] arr1 = new int[50, 50];


            Console.Write("Input numbers of rows : ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input numbers of cols : ");
            int cols = Convert.ToInt32(Console.ReadLine());
           
            for (i = 0; i < rows; i++)
            {
               
                for (j = 0; j < cols; j++)
                {
                   
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (j == i )sum = sum + arr1[i, j];
                }
            }


            Console.Write("The matrix is :\n");
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                    Console.Write("{0} ", arr1[i, j]);
                Console.Write("\n");
            }

            Console.Write("Addition of the right Diagonal elements is :{0}\n", sum);
        }
    }
}