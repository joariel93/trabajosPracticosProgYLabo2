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
        private double Operar(string numero1, string numero2, string operador)
        {
            Numero numeroUno = new Numero(numero1);
            Numero numeroDos = new Numero(numero2);

            return Calculadora.Operar(numeroUno, numeroDos, operador);

        }

        private void calculadoraBotonLimpiar_Click(object sender, EventArgs e)
        {
            calculadoraOperadores.ResetText();
            calculadoraResultado.Text = "";
            calculadoraNumeroUno.Clear();
            calculadoraNumeroDos.Clear();
        }

        private void calculadoraBotonConvertirABinario_Click(object sender, EventArgs e)
        {
            if (calculadoraResultado.Text != "")
            {
                Numero numero = new Numero();
                calculadoraResultado.Text = numero.DecimalBinario(calculadoraResultado.Text);

            }
        }

        private void calculadoraBotonConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (calculadoraResultado.Text != "")
            {
                    Numero numero = new Numero();
                    calculadoraResultado.Text = numero.BinarioDecimal(calculadoraResultado.Text);
                            
            }



        }




    }
}
