using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinProfesorException:Exception
    {
        public SinProfesorException()
            :base("No hay un profesor que pueda dar la clase")
        { }
        public SinProfesorException(string mensaje, string origenError)
            :base(mensaje)
        {
            base.Source = origenError;
        }
        public SinProfesorException(string mensaje, Exception innerException)
            :base(mensaje,innerException)
        { }
        public SinProfesorException(string mensaje, string origenError, Exception innerException)
            :base(mensaje,innerException)
        {
            base.Source = origenError;
        }

        public override string ToString()
        {
            return "Mensaje: "+base.Message+",Origen del error: "+base.Source; 
        }
    }
}
