using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {
        //Properties
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public bool FuzzyDices { get; set; }
        public int Speed { get; set; }

        public Car()
        {

        }

        public void Accelerate()
        {
            Speed += 5;
        }
        public void Brake()
        {
            Speed -= 5;
        }
        public void PrintData()
        {
            Console.WriteLine("CAR DATA:");
            Console.WriteLine("model:" + Model);
            Console.WriteLine("color:" + Color);
            Console.WriteLine("engine:" + Engine);
            Console.WriteLine("speed:" + Speed);
            Console.WriteLine("fuzzy dices:" + FuzzyDices);
        }
    }
}
