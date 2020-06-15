using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Excepciones;

namespace ClasesAbstractas
{
    
    public abstract class Persona
    {
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }

        protected string apellido;
        protected int dni;
        protected ENacionalidad nacionalidad;
        protected string nombre;

        /// <summary>
        /// Constructor por defecto, inicializa todos los atributos en default
        /// </summary>
        public Persona()
        {
            this.apellido = default;
            this.nombre = default;
            this.dni = default;
            this.nacionalidad = default;
        }

        /// <summary>
        /// Constructor que recibe Nombre, Apellido y Nacionalidad y lo asigna
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        /// <summary>
        /// Constructor que recibe Nombre, Apellido, DNI y Nacionalidad y lo asigna
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="dni">DNI de la persona de tipo int</param>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            :this(nombre,apellido,nacionalidad)
        {
            this.Dni = dni;
        }

        /// <summary>
        /// Constructor que recibe Nombre, Apellido, DNI y Nacionalidad y lo asigna
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="dni">DNI de la persona de tipo string</param>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) 
            : this(nombre, apellido,nacionalidad)
        {
            this.StringToDni = dni;
        }

        /// <summary>
        /// Propiedad que retorna y asigna el Apellido de la persona validandolo
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = ValidarNombreApellido(value);
            }
        }

        /// <summary>
        /// Propiedad que retorna y asigna el Nombre de la persona validandolo
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = ValidarNombreApellido(value);
            }
        }

        /// <summary>
        /// Propiedad que retorna y asigna la Nacionalidad de la persona
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }

        /// <summary>
        /// Propiedad que retorna y asigna el DNI de la persona como int y validandolo
        /// </summary>
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = ValidarDni(this.Nacionalidad, value);
            }
        }

        

        /// <summary>
        /// Propiedad que asigna el DNI de la persona recibido como string para convertirlo a int
        /// </summary>
        public string StringToDni
        {
            set
            {
                this.Dni=ValidarDni(this.Nacionalidad, value);
            }
        }


        /// <summary>
        /// Valida el DNI de la persona con respecto a su nacionalidad
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        /// <param name="dato">DNI de tipo int recibido que sera validado</param>
        /// <returns>Si el DNI es valido lo retorna, sino lanza NacionalidadInvalidaException</returns>
        protected int ValidarDni(ENacionalidad nacionalidad,int dato)
        {
            if (nacionalidad == ENacionalidad.Argentino && dato >= 1 && dato < 90000000)
                return dato;
            else if (nacionalidad == ENacionalidad.Extranjero && dato >= 90000000 && dato <= 99999999)
                return dato;
            else
                throw new NacionalidadInvalidaException();

        }

        /// <summary>
        /// Valida el DNI de la persona con respecto a su nacionalidad
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        /// <param name="dato">DNI de tipo string recibido que sera validado</param>
        /// <returns>Si el DNI es valido lo retorna, sino lanza DniInvalidoException</returns>
        protected int ValidarDni(ENacionalidad nacionalidad,string dato)
        {
            int datoInt=default;

            if (int.TryParse(dato, out datoInt))
                return datoInt;
            else throw new DniInvalidoException();
        }

        /// <summary>
        /// Valida que el nombre o apellido recibido este compuesto por caracteres alfabeticos
        /// </summary>
        /// <param name="dato">Nombre o apellido a validar</param>
        /// <returns>Si el nombre o apellido es valido lo retorna, sino retorna null</returns>
        protected string ValidarNombreApellido(string dato)
        {
            if (dato.StartsWith(" "))
                return null;
            else
            {

                foreach (char item in dato)
                {
                    if (!(Char.IsLetter(item)) && !(Char.IsWhiteSpace(item)))
                    {
                        return null;
                    }
                }
            }
            return dato;
        }

        /// <summary>
        /// Sobreescritura del metodo ToString que retorna los atributos de la persona en string
        /// </summary>
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Apellido: {this.Apellido}");
            retorno.AppendLine($"Nombre: {this.Nombre}");
            retorno.AppendLine($"Nacionalidad: {this.Nacionalidad}");
            retorno.AppendLine($"DNI: {this.Dni}");


            return retorno.ToString();
        }


    }
}
