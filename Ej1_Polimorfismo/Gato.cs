﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1_Polimorfismo
{
    public class Gato : ISonido
    {
        public string HacerSonido()
        {
            return "El gato hace miauuuu";
        }
    }
}
