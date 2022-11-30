using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1_Heritage
{
    internal class Oiseau : Animal
    {
        new public string Manger()
        {
            return "Je mange des graines";
        }
    }
}
