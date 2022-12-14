using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice16
{
    internal class Zoo
    {
        Dictionary<string,string> animals;

        public Zoo(params (string, string)[] animal)
        {
            animals = new Dictionary<string, string>();
            for (int i = 0; i < animal.Length; i++)
            {
                animals.Add(animal[i].Item1, animal[i].Item2);
            }
        }

        public string this[string index]
        {
            get
            {u
                return animals[index];
            }
            set
            {
                animals[index] = value;
            }
        }

        
        
    }
}
