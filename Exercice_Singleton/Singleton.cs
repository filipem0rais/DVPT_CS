using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Singleton
{
    class Singleton
    {
        public static Singleton Instance;

        public static Singleton CreateInstance()
        {
            if (Instance == null)
            {
                Instance = new Singleton();
            }
            return Instance;
        }

        public Singleton()
        {
            CreateInstance();
        }







    }
}
