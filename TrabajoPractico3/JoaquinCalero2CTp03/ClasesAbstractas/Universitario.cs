using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    
    public abstract class Universitario:Persona
    {

        protected int legajo;


        /// <summary>
        /// Constructor por defecto de la clase
        /// </summary>
        public Universitario():base()
        {
            this.legajo = default;
        }

        /// <summary>
        /// Constructor que recibe parametros y los asigna
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }

        /// <summary>
        /// Retorna los datos del universitario en formato string
        /// </summary>
        protected virtual string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(base.ToString());
            retorno.AppendLine($"Legajo: {this.legajo}");

            return retorno.ToString();

        }

        /// <summary>
        /// Método protegido y abstracto ParticiparEnClase
        /// </summary>
        /// <returns></returns>
        protected abstract string ParticiparEnClase();

        /// <summary>
        /// Sobrecarga del metodo Equals que compara por los tipos de objetos
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return this.GetType()==obj.GetType();
        }
        /// <summary>
        /// Sobre carga del operador != que compara 2 universitarios por su tipo, legajo y DNI
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        /// <summary>
        /// Sobre carga del operador == que compara 2 universitarios por su tipo, legajo y DNI
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if (pg1.Equals(pg2) && pg1.legajo == pg2.legajo || pg1.Dni == pg2.Dni)
                return true;
            else
                return false;
        }

    }
}
