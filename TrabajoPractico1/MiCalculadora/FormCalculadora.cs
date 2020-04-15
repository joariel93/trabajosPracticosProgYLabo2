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
        private string calcularBinario (string strNumero)
        {
            StringBuilder aux=new StringBuilder();
            int numero = default;
            int.TryParse(strNumero ,out numero);
            int binarioInt=default;

            if (numero != 0 && numero != 1)
            {
                while (numero != 0 && numero != 1)
                {
                    binarioInt = numero % 2;
                    numero = numero / 2;
                    if (binarioInt == 1)
                        aux.Append(0);
                    else
                        aux.Append(1);
                }
                aux.Append(0);


                return aux.ToString();
            }
            else if (numero == 0)
                return "0";
            else
                return "1";
        }
    }
}
