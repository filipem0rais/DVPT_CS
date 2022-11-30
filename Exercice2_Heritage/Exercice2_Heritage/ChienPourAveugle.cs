using Exercice1_Heritage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2_Heritage
{
    internal class ChienPourAveugle : Chien, IGuideAveugle
    {
        public void ApprendGuider()
        {
            Console.WriteLine("Je suis un chien pour aveugle et je suis en train d'apprendre à guider");
        }

        public void GuiderMaitre()
        {
            Console.WriteLine("Je suis un chien pour aveugle et je suis en train de guider mon maitre");
        }

        new public string Manger()
        {
            return "Je suis un chien pour aveugle et je mange de la viande";
        }
    }
}
