using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_StatePattern
{
    internal class Ordinateur
    {
        private State _state;

        public Ordinateur()
        {
            _state = new StateEteint();
        }

        public void Allumer()
        {
            _state = _state.Allumer();
        }

        public void Eteindre()
        {
            _state = _state.Eteindre();
        }

        public void Hiberner()
        {
            _state = _state.Hiberner();
        }
    }
}
