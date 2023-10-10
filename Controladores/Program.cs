using calculcadora.Servicios;
using calculcadora.Serviciossuma;

namespace calculcadora
{
    /// <summary>
    /// Clase principal donde esta nuestro metodo main
    /// @autor jpr-091023
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo principal de nuestro programs
        /// @autor jpr-091023
        /// </summary>
        /// <param name="args"></param>
        public static void Main(String[] args, InterfazSuma interfazSuma)
        {
            MenuInterfaz menuInterfaz = new MenuImplementacion();
            menuInterfaz.mensajeBienvenida();
            bool cerrarMenu = false;
            int opcionSelect;

            while (!cerrarMenu)
            {
                opcionSelect = menuInterfaz.menuBucle();
                Console.WriteLine(opcionSelect);
                switch (opcionSelect)
                {
                   
                    case 0:
                        Console.WriteLine("[INFOS]-Se cerrara la aplicación");
                        cerrarMenu = true;
                        break;
                    case 1:
                        float operador;
                        float operador2;
                        operador = interfazSuma.devuelveUnEntero();
                        operador2 = interfazSuma.devuelveUnEntero();
                        float retultado = operador + operador2;
                        Console.WriteLine(retultado);

                        break;
                    case 2:
                        float operador3 = interfazSuma.devuelveUnEntero();
                        float operador4 = interfazSuma.devuelveUnEntero();
                        float resultado2 = operador3 - operador4;
                        Console.WriteLine(resultado2 + "\n");
                        break;
                    case 3:
                        float operador5 = interfazSuma.devuelveUnEntero();
                        float operador6 = interfazSuma.devuelveUnEntero();
                        float resultado3 = operador5 * operador6;
                        Console.WriteLine(resultado3 + "\n");
                        break;
                    case 4:
                        float operador7 = interfazSuma.devuelveUnEntero();
                        float operador8 = interfazSuma.devuelveUnEntero();
                        float resultado4 = operador7 / operador8;
                        Console.WriteLine(resultado4 + "\n");
                        break;
                    default:
                        Console.WriteLine("[INFOS]-La opcion seleccionada no existe");
                        break;
                }
            }
        }
    }
}
