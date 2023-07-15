using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1_Polimorfismo
{
    public class Perro : ISonido
    {
        public string HacerSonido()
        {
            return "El perro hace guauuu guauuuu";
        }
    }
}
