using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_StatePattern
{
    internal class StateAllume : State
    {
        public override State Allumer()
        {
            return this;
        }

        public override State Eteindre()
        {
            return new StateEteint();
        }

        public override State Hiberner()
        {
            return new StateVeille();
        }

    }
}
