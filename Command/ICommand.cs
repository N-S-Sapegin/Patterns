using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    interface ICommand
    {
        void Positive();
        void Negative();
    }
}
