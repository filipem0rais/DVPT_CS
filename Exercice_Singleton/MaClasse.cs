using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Singleton
{
    class MaClasse
    {
        public static MaClasse Instance;

        public static MaClasse CreateInstance()
        {
            if (Instance == null)
            {
                Instance = new MaClasse();
            }
            return Instance;
        }

        





    }
}
