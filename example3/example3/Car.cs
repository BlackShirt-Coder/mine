using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example3
{
    class Car
    {
        string model;
        string color;
        static void Main(string[] args)
        {
            Show s=new Show();
            s.color = "blue";
            s.Display(s.color);
           
        }
    }
}
