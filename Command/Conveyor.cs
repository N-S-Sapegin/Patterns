using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Conveyor
    {
        public void On() => Console.WriteLine("Conveyor On");
        public void Off() => Console.WriteLine("Conveyor Off");
        public void SpeedIncrease() => Console.WriteLine("Speed +");
        public void SpeedDecrease() => Console.WriteLine("Speed -");
    }
}
