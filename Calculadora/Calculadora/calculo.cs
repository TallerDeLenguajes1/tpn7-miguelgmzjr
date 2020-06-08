using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class calculo
    {
        float numero1;
        float numero2;

        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }

        public float suma()
        {
            return numero1 + numero2;
        }

        public float resta()
        {
            return numero1 - numero2;
        }

        public float multiplicacion()
        {
            return numero1 * numero2;
        }

        public float division()
        {
            return numero1 / numero2;
        }
    }
}
