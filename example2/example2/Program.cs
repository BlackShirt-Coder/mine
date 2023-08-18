using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = " Hello C# ";
            string s2 = s1.Trim();
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            string s3 = "##Hello C#$$";
            char[] ch = { '#', '$' };
            string s4 = s3.Trim(ch);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
        }
    }
}
