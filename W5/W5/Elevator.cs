using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5
{
    class Elevator
    {
        private int floor = 1;

        public int Floor
        {
            get { return floor; }
            set
            {
                if (value < 1) { Console.WriteLine("Elevator can't go underground!"); }
                else if (value > 5) { Console.WriteLine("Elevator can't go trough the roof!"); }
                else { floor = value; }
            }
        }

    }
}
