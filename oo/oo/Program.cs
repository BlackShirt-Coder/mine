using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oo
{
   partial class Program
    {
        static void Main(string[] args)
        {
           Program p= new Program();
           Console.WriteLine(p.name);
        }
    }
    partial class Program
    {
        public string name = "mgmg";
    }
}
