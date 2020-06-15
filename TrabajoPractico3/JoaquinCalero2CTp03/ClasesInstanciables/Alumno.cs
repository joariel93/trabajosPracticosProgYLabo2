using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;
using ClasesInstanciables;
using Excepciones;

namespace ClasesInstanciables
{
   
    public sealed class Alumno : Universitario
    {
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        /// <summary>
        /// Constructor por defecto de la clase
        /// </summary>
        public Alumno ():base()
        {
            this.claseQueToma = default;
            this.estadoCuenta = default;
        }

        /// <summary>
        /// Constructor de clase que recibe legajo, nombre, apellido, DNI, nacionalidad y clase que toma
        /// </summary>
        /// <param name="id">Legajo del alumno</param>
        /// <param name="nombre">Nombre del alumno</param>
        /// <param name="apellido">Apellido del alumno</param>
        /// <param name="dni">DNI del alumno</param>
        /// <param name="nacionalidad">Nacionalidad del alumno</param>
        /// <param name="claseQueToma">Clase que toma el alumno</param>
        public Alumno (int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            :this(id,nombre,apellido,dni,nacionalidad,claseQueToma,default)
        {
            
        }
        /// <summary>
        /// Constructor de clase que recibe legajo, nombre, apellido, DNI, nacionalidad y clase que toma
        /// </summary>
        /// <param name="id">Legajo del alumno</param>
        /// <param name="nombre">Nombre del alumno</param>
        /// <param name="apellido">Apellido del alumno</param>
        /// <param name="dni">DNI del alumno</param>
        /// <param name="nacionalidad">Nacionalidad del alumno</param>
        /// <param name="claseQueToma">Clase que toma el alumno</param>
        /// /// <param name="estadoCuenta">Estado de cuenta del alumno</param>
        public Alumno (int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : base(id,nombre,apellido,dni,nacionalidad)
        {
            this.claseQueToma = claseQueToma;
            this.estadoCuenta = estadoCuenta;
        }

        public static bool operator == (Alumno a, Universidad.EClases clase)
        {
            if (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
                return true;
         
            return false;
        }
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return !(a == clase);
        }

        /// <summary>
        /// Retorna los datos del alumno en formato string
        /// </summary>
        protected override string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(base.MostrarDatos());
            retorno.AppendLine(this.ParticiparEnClase());
            retorno.AppendLine($"Estado de cuenta: {this.estadoCuenta}");

            return retorno.ToString();

        }

        /// <summary>
        /// Retorna la clase que toma el alumno
        /// </summary>
        protected override string ParticiparEnClase()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append($"TOMA CLASE DE {this.claseQueToma}");

            return retorno.ToString();
        }

        /// <summary>
        /// Hace publicos los datos del alumno
        /// </summary>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
