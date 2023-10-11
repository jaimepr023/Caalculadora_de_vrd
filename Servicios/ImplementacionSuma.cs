using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculcadora.Serviciossuma
{
    internal class ImplementacionSuma : InterfazSuma
    {
        public float devuelveUnEntero()
        {
            Console.WriteLine("Dame un numero:");
            float num = float.Parse(Console.ReadLine());
            return num;
        }

        public float operacionsuma(float num1, float num2)
        {
          float  resultado = num1 + num2;
            return resultado; 
        }

        public float operacionresta(float num3, float num4)
        {
            float resultado2 = num3 - num4;
            return resultado2;
        }

        public float opcionmulti(float num5, float num6)
        {
            float resultado3 = num5 * num6;
            return resultado3;
        }

        public float opciondivi(float num7, float num8)
        {
            float resultado4 = num7 / num8;
            return resultado4;
        }






    }
}
