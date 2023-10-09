using calculcadora.Servicios;

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
        public static void Main(String[] args)
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
                        int n1;
                        int n2;
                        Console.WriteLine("Indique el primer operando:");
                        n1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Indique el segundo operando:");
                        n2 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la operación es:");
                        int resultado = n1 + n2;
                        Console.WriteLine(resultado+"\n");
                        break;
                    case 2:
                        int n3;
                        int n4;
                        Console.WriteLine("Indique el primer operando:");
                        n3 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Indique el segundo operando:");
                        n4 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la operación es:");
                        int resultado2 = n3 - n4;
                        Console.WriteLine(resultado2 + "\n");
                        break;
                    case 3:
                        int n5;
                        int n6;
                        Console.WriteLine("Indique el primer operando:");
                        n5 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Indique el segundo operando:");
                        n6 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la operación es:");
                        int resultado3 = n5 * n6;
                        Console.WriteLine(resultado3 + "\n");
                        break;
                    case 4:
                        float n7;
                        float n8;
                        Console.WriteLine("Indique el primer operando:");
                        n7 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Indique el segundo operando:");
                        n8 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la operación es:");
                        float resultado4 = n7 / n8;
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
