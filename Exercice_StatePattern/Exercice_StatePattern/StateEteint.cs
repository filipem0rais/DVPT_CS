using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_StatePattern
{
    internal class StateEteint : State
    {
        public override State Allumer()
        {
            return new StateAllume();
        }

        public override State Eteindre()
        {
            return this;
        }

        public override State Hiberner()
        {
            return this;
        }

    }
}
