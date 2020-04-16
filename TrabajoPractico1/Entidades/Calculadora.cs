using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Calculadora
    {

        /// <summary>
        /// Retorna el resultado segun los numeros y el operador enviado
        /// </summary>
        public static double Operar(Numero numero1, Numero numero2, string operador)
        {
            double resultado=default;

            switch (ValidarOperador(operador)) 
            { 
                case "+":
                    resultado= numero1 + numero2;
                    break;
                    
                case "-":
                    resultado = numero1 - numero2;
                    break;

                case "*":
                    resultado = numero1 * numero2;
                    break;

                case "/":
                    resultado = numero1 / numero2;
                    break;
            }
            return resultado;
        }
        /// <summary>
        /// Verifica que el operador recibido sea valido, en caso contrario retorna +
        /// </summary>
        private static string ValidarOperador (string operador)
        {
            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
                return operador;
            else
                return "+";
        }

    }
}
