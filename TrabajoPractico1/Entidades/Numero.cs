using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public Numero ()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = 0;
        }
        public Numero(string numero)
        {
            this.SetNumero=numero;
          
        }

        public double ValidarNumero(string strNumero)
        {
            double aux;
            if (double.TryParse(strNumero, out aux))
                return aux;
            else
                return 0;
        }
        public string SetNumero
        {
            set
            {
                if (ValidarNumero(value) != 0)
                    this.numero = ValidarNumero(value);
            }
        }
        public static double operator + (Numero numero1, Numero numero2)
        {
            return numero1.numero + numero2.numero;
        }
        public static double operator -(Numero numero1, Numero numero2)
        {
            return numero1.numero - numero2.numero;
        }
        public static double operator *(Numero numero1, Numero numero2)
        {
            return numero1.numero * numero2.numero;
        }
        public static double operator /(Numero numero1, Numero numero2)
        {
            if (numero2.numero == 0)
                return double.MinValue;
            else
                return numero1.numero / numero2.numero;
        }
    }
}
