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

namespace MainCorreo
{
    public partial class FrmPpal : Form
    {
        Correo correo;
        public FrmPpal()
        {
            this.correo = new Correo();
            InitializeComponent();
        }


        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paquete aux = new Paquete(this.txtBxDireccion.Text, this.mskdTxtBx.Text);
            Paquete.InformaEstado += paq_InformaEstado;
            try
            {
                this.correo += aux;
            }
            catch(TrackingIdRepetidoException excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }

            ActualizarEstados();


        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.correo.FinEntregas();
        }

        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if(!(elemento is null))
            {
                this.rchtxtBx.Text = elemento.MostrarDatos(elemento);
                
                try
                {
                    elemento.MostrarDatos(elemento).Guardar("salida.txt");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
        }

        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado delegado = new Paquete.DelegadoEstado(paq_InformaEstado);

                this.Invoke(delegado, new object[] { sender, e });
            }
            else
            {
                ActualizarEstados();
            }
        }
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }
        private void ActualizarEstados()
        {
            this.lstBxIngresado.Items.Clear();
            this.lstBxEnViaje.Items.Clear();
            this.lstEstadoEntregado.Items.Clear();

            foreach (Paquete p in this.correo.Paquetes)
            {
                switch(p.Estado)
                {
                    case Paquete.EEstado.Ingresado:
                        this.lstBxIngresado.Items.Add(p);
                        break;
                    case Paquete.EEstado.EnViaje:
                        this.lstBxEnViaje.Items.Add(p);
                        break;
                    case Paquete.EEstado.Entregado:
                        this.lstEstadoEntregado.Items.Add(p);
                        break;
                }
            }
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            PaqueteDAO.TenemosUnProblema += ProblemaConSQL;
            this.mskdTxtBx.Select();
        }

        private void ProblemaConSQL(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
