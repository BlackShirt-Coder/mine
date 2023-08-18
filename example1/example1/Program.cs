using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] salary = new int[] { 400000, 500000, 200000 };
           // Array.Sort(salary);
            Array.Reverse(salary);
            foreach (int i in salary)
            {
                Console.WriteLine(i+"");
            }
        }
    }
}
