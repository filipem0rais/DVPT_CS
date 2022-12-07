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
            Console.WriteLine("L'ordinateur est allumé");
            return new StateAllume();
        }

        public override State Eteindre()
        {
            Console.WriteLine("L'ordinateur est déjà éteint");
            return this;
        }

        public override State Hiberner()
        {
            Console.WriteLine("L'ordinateur ne peut pas hiberner");
            return this;
        }

    }
}
