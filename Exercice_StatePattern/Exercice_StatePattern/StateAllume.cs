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
            Console.WriteLine("L'ordinateur est déjà allumé");
            return this;
           
        }

        public override State Eteindre()
        {
            Console.WriteLine("L'ordinateur est éteint");
            return new StateEteint();
            
        }

        public override State Hiberner()
        {
            Console.WriteLine("L'ordinateur est en veille");
            return new StateVeille();
        }

    }
}
