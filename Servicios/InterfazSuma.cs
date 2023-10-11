﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculcadora.Serviciossuma
{
    /// <summary>
    /// Interfaz con la cabecera del metodo de operaciones
    /// @autor jpr-111023
    /// </summary>
    internal interface InterfazSuma 
    {
        /// <summary>
        /// Cabecera que devuelve el numero para las operaciones
        /// @autor jpr-111023
        /// </summary>
        /// <returns></returns>
        public float devuelveUnEntero();

        /// <summary>
        /// Cabecera que devuelve la operacion de la suma
        /// @autor jpr-111023
        /// </summary>
        /// <returns></returns>
        public float operacionsuma(float num1, float num2);

        /// <summary>
        /// Cabecera que devuelve la operacion de la resta
        /// @autor jpr-111023
        /// </summary>
        /// <returns></returns>
        public float operacionresta(float num3, float num4);

        /// <summary>
        /// Cabecera que devuelve la operacion de la multiplicacion
        /// @autor jpr-111023
        /// </summary>
        /// <returns></returns>
        public float opcionmulti(float num5 , float num6);

        /// <summary>
        /// Cabecera que devuelve la operacion de la division
        /// @autor jpr-111023
        /// </summary>
        /// <returns></returns>
        public float opciondivi(float num7, float num8);


    }
}
