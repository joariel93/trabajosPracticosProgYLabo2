using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException:Exception
    {
        public NacionalidadInvalidaException()
           : base("La nacionalidad ingresada no es valida")
        { }
        public NacionalidadInvalidaException(string mensaje, string origenError)
            : base(mensaje)
        {
            base.Source = origenError;
        }
        public NacionalidadInvalidaException(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        { }
        public NacionalidadInvalidaException(string mensaje, string origenError, Exception innerException)
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
