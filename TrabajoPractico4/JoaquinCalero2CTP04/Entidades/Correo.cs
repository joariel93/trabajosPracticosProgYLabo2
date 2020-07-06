using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        protected List<Thread> mockPaquetes;
        protected List<Paquete> paquetes;

        public Correo()
        {
            this.mockPaquetes = new List<Thread>();
            this.Paquetes = new List<Paquete>();
        }

        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }

        public void FinEntregas()
        {
            foreach (Thread mock in this.mockPaquetes)
            {
                mock.Abort();
            }
        }

        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            StringBuilder retorno = new StringBuilder();
            foreach (Paquete p in (List<Paquete>)((Correo)elementos).Paquetes)
            {
                retorno.AppendLine(string.Format("{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString()));
            }
            return retorno.ToString();
        }

        public static Correo operator +(Correo c, Paquete p)
        {
            Thread nuevoMock;

            if (!(c is null) && !(p is null))
            {
                foreach (Paquete item in c.Paquetes)
                {
                    if (item == p)
                        throw new TrackingIdRepetidoException("El ID del paquete ya se encuentra en la lista");
                }
                c.Paquetes.Add(p);
                nuevoMock = new Thread(p.MockCicloDeVida);
                c.mockPaquetes.Add(nuevoMock);
                nuevoMock.Start();
            }

            return c;

        }
    }
}

