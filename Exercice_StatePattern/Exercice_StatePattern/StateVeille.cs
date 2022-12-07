using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_StatePattern
{
    internal class StateVeille : State
    {
        public override State Allumer()
        {
            return new StateAllume();
        }

        public override State Eteindre()
        {
            return new StateEteint();
        }

        public override State Hiberner()
        {
            return this;
        }
    }
}
