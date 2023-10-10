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
    }
}
