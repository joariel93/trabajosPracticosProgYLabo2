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

        private static string ValidarOperador (string operador)
        {
            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
                return operador;
            else
                return "+";
        }

    }
}
