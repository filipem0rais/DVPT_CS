using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_ApplicationObjets
{
    internal class Voiture
    {
        private string couleur;
        private double contenanceReservoir;
        private Moteur moteur;

        public Voiture(string couleur, double contenanceReservoir, double puissanceMoteur)
        {
            this.couleur = couleur;
            this.contenanceReservoir = contenanceReservoir;
            this.moteur = new Moteur(puissanceMoteur);
        }

        public void MettreEnMarche()
        {
            Console.WriteLine("La voiture démarre");
            moteur.Demarrer();

        }

        public void Avancer()
        {

            moteur.ChangerRegime(2000);
            Console.WriteLine("La voiture avance");
        }

    }
}
