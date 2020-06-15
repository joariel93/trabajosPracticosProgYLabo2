using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException:Exception
    {
        public DniInvalidoException()
           : base("Solo puede ingresar numeros como DNI")
        { }
        public DniInvalidoException(string mensaje, string origenError)
            : base(mensaje)
        {
            base.Source = origenError;
        }
        public DniInvalidoException(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        { }
        public DniInvalidoException(string mensaje, string origenError, Exception innerException)
            : base(mensaje, innerException)
        {
            base.Source = origenError;
        }

        public override string ToString()
        {
            return "Mensaje: " + base.Message + ",Origen del error: " + base.Source;
        }
    }
}
