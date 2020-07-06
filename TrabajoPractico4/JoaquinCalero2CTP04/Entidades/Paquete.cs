using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }

        public delegate void DelegadoEstado(object sender, EventArgs e);
        public static event DelegadoEstado InformaEstado;

        protected string direccionEntrega;
        protected EEstado estado;
        protected string trackingID;

        #region Constructores
        public Paquete()
        {
            this.DireccionEntrega = default;
            this.Estado = default;
            this.TrackingID = default;
        }
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.DireccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
            this.Estado = EEstado.Ingresado;
        }

        #endregion

        #region Propiedades
        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }
        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }

        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }
        #endregion


        #region Metodos

        public void MockCicloDeVida()
        {

            do
            {
                Thread.Sleep(4000);
                this.Estado++;
                InformaEstado.Invoke(this, null);

            } while (this.Estado < (EEstado)2);
            PaqueteDAO.Insertar(this);

        }

        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            Paquete p = (Paquete)elemento;
            return string.Format("{0} para {1}", p.trackingID, p.direccionEntrega);
        }

        public override string ToString()
        {


            return MostrarDatos(this);
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            if (!(p1 is null) && !(p2 is null) && p1.TrackingID == p2.TrackingID)
                return true;

            return false;
        }
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        #endregion
    }
}

