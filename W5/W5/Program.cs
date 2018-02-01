using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator hissi = new Elevator();
            Console.WriteLine("Elevator is on the floor: " + hissi.Floor);

            while (true)
            {
                Console.Write("To which floor (1-5) you would like to go? ");
                string floorNumber = Console.ReadLine();
                int floorNumberInt = 0;
                Int32.TryParse(floorNumber, out floorNumberInt);
                hissi.Floor = floorNumberInt;
                Console.Write("\n");
                Console.WriteLine("Elevator is on the floor: " + hissi.Floor);
            }
        }
    }
}
