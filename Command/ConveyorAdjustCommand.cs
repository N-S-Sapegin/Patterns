using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class ConveyorAdjustCommand : ICommand
    {
        private Conveyor conveyor;
        public ConveyorAdjustCommand(Conveyor conveyor)
        {
            this.conveyor = conveyor;
        }

        public void Negative()
        {
            conveyor.SpeedIncrease();
        }
        public void Positive()
        {
            conveyor.SpeedDecrease();
        }
    }
}
