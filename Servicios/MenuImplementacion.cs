using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculcadora.Servicios
{
    /// <summary>
    /// Clase de la implementacion
    /// @autor jpr-091023
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra en pantalla el mensaje orincipal
        /// @autor jpr-091023
        /// </summary>
        public void mensajeBienvenida()
        {
            string mensaje = "Elija la opción para calcular la operacion deseada";
            Console.WriteLine(mensaje);
        }

        public int menuBucle()
        {
            int opcionescogida;
            Console.WriteLine("####################");
            Console.WriteLine("0. Cerrar Menú.");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("####################");
            opcionescogida = Console.ReadKey(true).KeyChar - ('0');
            return opcionescogida;
        }
    }
}