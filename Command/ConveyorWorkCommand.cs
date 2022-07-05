using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class ConveyorWorkCommand : ICommand
    {
        private Conveyor conveyor;
        public ConveyorWorkCommand(Conveyor conveyor)
        {
            this.conveyor = conveyor;
        }
        public void Negative()
        {
            conveyor.On();
        }
        public void Positive()
        {
            conveyor.Off();
        }
    }
}
