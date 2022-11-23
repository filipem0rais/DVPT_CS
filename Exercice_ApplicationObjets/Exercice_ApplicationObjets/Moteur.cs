using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_ApplicationObjets
{
    internal class Moteur
    {
        private double puissance;
        private double regimeCourant;

        public Moteur(double puissance)
        {
            this.puissance = puissance;
            this.regimeCourant = 0;
        }

        public void Demarrer()
        {
            Console.WriteLine("Le moteur démarre");
            regimeCourant = 1000;
        }
        
        public void ChangerRegime(double regime)
        {
           
            regimeCourant = regime;
            Console.WriteLine("Le moteur tourne à " + regime + " tours par minute");

        }
    }
}
