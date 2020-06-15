using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AlumnoRepetidoException:Exception
    {
        public AlumnoRepetidoException()
           : base("El alumno ya se encuentra en la clase")
        { }
        public AlumnoRepetidoException(string mensaje, string origenError)
            : base(mensaje)
        {
            base.Source = origenError;
        }
        public AlumnoRepetidoException(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        { }
        public AlumnoRepetidoException(string mensaje, string origenError, Exception innerException)
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
