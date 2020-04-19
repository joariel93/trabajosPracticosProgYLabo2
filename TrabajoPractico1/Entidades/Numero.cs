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

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = 0;
        }
        public Numero(string numero)
        {
            this.SetNumero = numero;

        }
        /// <summary>
        /// Valida que el string recibido sea un numero y lo convierte, caso contrario retorna 0
        /// </summary>
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
                    this.numero = ValidarNumero(value);
            }
        }
        public static double operator +(Numero numero1, Numero numero2)
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
        /// <summary>
        /// Recibe un numero string y retorna la parte entera del mismo en binario string
        /// </summary>
        public string DecimalBinario(string strNumero)
        {
            StringBuilder aux = new StringBuilder();
            int numero = default;
            if (!VerificarSiEsDecimal(strNumero))
                int.TryParse(strNumero, out numero);
            else
                numero = int.Parse(PasarDeDecimalAEntero(strNumero));

            double binarioInt = default;
            string retorno;

            if (numero != 0 && numero != 1)
            {
                while (numero != 0 && numero != 1)
                {
                    binarioInt = numero % 2;
                    numero = numero / 2;
                    aux.Append(binarioInt);
                }
                aux.Append(1);
                retorno = aux.ToString();

                return InvertirString(retorno);
            }
            else if (numero == 0)
                return "0";
            else
                return "1";
        }


        /// <summary>
        /// Retorna el string recibido invertido
        /// </summary>
        private string InvertirString(string bufferString)
        {
            char[] bufferChar = ConvertirStringEnArrayChar(bufferString);
            char[] retorno = bufferChar.Reverse().ToArray();
            string retornoString = new string(retorno);

            return retornoString;
        }

        /// <summary>
        /// Verifica que el numero que recibe sea entero
        /// </summary>
        private bool VerificarSiEsDecimal(string strNumero)
        {
            bool flag = default;
            char[] verificador = strNumero.ToCharArray();

            foreach (char item in verificador)
            {
                if (item == ',' || item == '.')
                    return flag = true;
            }
            return flag;
        }
        /// <summary>
        /// Recibe un numero en formato string y retorna el mismo entero.
        /// </summary>
        private string PasarDeDecimalAEntero(string strNumero)
        {
            char[] verificador = strNumero.ToCharArray();
            StringBuilder retorno = new StringBuilder();

            foreach (char item in verificador)
            {
                if (item == ',' || item == '.')
                    break;
                else
                {
                    retorno.Append(item);
                }

            }
            return retorno.ToString();
        }

        /// <summary>
        /// Recibe un numero binario y retorna el mismo en decimal
        /// </summary>
        public string BinarioDecimal(string numBinario)
        {
            char[] bufferChar = ConvertirStringEnArrayChar(InvertirString(numBinario));
            double numeroDecimal = 0;
            int i;

            for (i = 0; i < bufferChar.Length; i++)
            {
                if (bufferChar[i] == '1')
                {
                    numeroDecimal = numeroDecimal + Math.Pow(2, i);
                }
            }

            return numeroDecimal.ToString();
        }
        /// <summary>
        /// Recibe un string y devuelve una Array de chars
        /// </summary>
        private char[] ConvertirStringEnArrayChar(string str)
        {
            char[] bufferChar = str.ToCharArray();
            return bufferChar;

        }
    }


}
