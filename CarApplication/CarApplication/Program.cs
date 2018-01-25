using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car cart = new Car();
            cart.Color = "Shitty brown";
            cart.Engine = 1;
            cart.FuzzyDices = false;
            cart.Model = "BandwaGONE";
            cart.PrintData();
            Console.ReadLine();
            cart.Accelerate();
            cart.PrintData();
            Console.ReadLine();
        }
    }
}
