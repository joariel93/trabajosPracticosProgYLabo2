using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    class Calculadora
    {
        public double Operar(Numero numero1, Numero numero2, string operador)
        {
            double resultado=default;
            ValidarOperador(operador);

            switch (operador) { 
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

        private string ValidarOperador (string operador)
        {
            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
                return operador;
            else
                return "+";
        }

    }
}
