using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice15
{
    internal class Voiture
    {
        private int _vitesse;

        public Voiture()
        {
            _vitesse = 0;
        }
        
        public int Vitesse
        {
            get { return _vitesse; }
        }

        public void Accelerer()
        {
            _vitesse += 10;
        }
    }
}
