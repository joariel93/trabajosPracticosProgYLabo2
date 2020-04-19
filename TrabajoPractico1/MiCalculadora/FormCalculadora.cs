using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace MiCalculadora
{
    public partial class laCalculadora : Form
    {
        public laCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void calculadoraBotonCerrar_Click(object sender, EventArgs e)
        {
           this.Close();

        }

        private void calculadoraBotonOperar_Click(object sender, EventArgs e)
        {
            calculadoraResultado.Text = Operar(calculadoraNumeroUno.Text, calculadoraNumeroDos.Text, calculadoraOperadores.Text).ToString();
        }
        private double Operar (string numero1, string numero2, string operador)
        {
            Numero numeroUno = new Numero(numero1);
            Numero numeroDos = new Numero(numero2);

            return Calculadora.Operar(numeroUno, numeroDos, operador);

        }

        private void calculadoraBotonLimpiar_Click(object sender, EventArgs e)
        {
            calculadoraOperadores.ResetText();
            calculadoraResultado.Text="";
            calculadoraNumeroUno.Clear();
            calculadoraNumeroDos.Clear();
        }

        private void calculadoraBotonConvertirABinario_Click(object sender, EventArgs e)
        {
            if (calculadoraResultado.Text != "")
                calculadoraResultado.Text = calcularBinario(calculadoraResultado.Text);
            
        }
        
        private void calculadoraBotonConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (calculadoraResultado.Text != "")
                calculadoraResultado.Text = calcularDecimal(calculadoraResultado.Text);


        }
        
        #region Funciones para el calculo a binario y viceversa
        /// <summary>
        /// Recibe un numero y retorna la parte entera del mismo en binario
        /// </summary>
        private string calcularBinario (string strNumero)
        {
            StringBuilder aux=new StringBuilder();
            int numero = default;
            if (!VerificarSiEsDecimal(strNumero))
                int.TryParse(strNumero, out numero);
            else
                numero = int.Parse(PasarDeDecimalAEntero(strNumero));           

            int binarioInt=default;
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
                
                return VoltearString(retorno);
            }
            else if (numero == 0)
                return "0";
            else
                return "1";
        }

        
        /// <summary>
        /// Retorna el string recibido invertido
        /// </summary>
        private string VoltearString (string bufferString)
        {
            char[] bufferChar= ConvertirStringEnArrayChar(bufferString);
            char[] retorno=bufferChar.Reverse().ToArray();
            string retornoString = new string(retorno);

            return retornoString;
        }

        /// <summary>
        /// Verifica que el numero que recibe sea entero
        /// </summary>
        private bool VerificarSiEsDecimal(string strNumero)
        {
            bool flag=default;
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
        private string calcularDecimal(string numBinario)
        {
            char[] bufferChar = ConvertirStringEnArrayChar(VoltearString(numBinario));
            double numeroDecimal = 0;
            int i;

            for( i=0;i<bufferChar.Length;i++)
            {
               if(bufferChar[i]=='1')
                {
                    numeroDecimal =numeroDecimal+Math.Pow(2,i);
                }
            }

            return numeroDecimal.ToString();
        }
        /// <summary>
        /// Recibe un string y devuelve una Array de chars
        /// </summary>
        private char[] ConvertirStringEnArrayChar (string str)
        {
            char[] bufferChar = str.ToCharArray();
            return bufferChar;

        }

        #endregion


    }
}
