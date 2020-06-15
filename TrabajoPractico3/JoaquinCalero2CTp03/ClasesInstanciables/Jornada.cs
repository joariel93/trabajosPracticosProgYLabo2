using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using Excepciones;
using Archivos;

namespace ClasesInstanciables
{
    
    public class Jornada : Texto
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;

        /// <summary>
        /// Constructor por defecto, inicializa la lista de alumnos
        /// </summary>
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Constructor de clase que recibe la clase y el instructor como parametros
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="instructor"></param>
        public Jornada(Universidad.EClases clase, Profesor instructor):this()
        {
            this.Clase = clase;
            this.instructor = instructor;
        }

        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }

            set
            {
                this.alumnos = value;
            }
        }

        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }

        public static bool Guardar(Jornada jornada)
        {
            Texto guardar = new Texto();
            if(guardar.Guardar("JornadaTxt", jornada.ToString()))
                return true;

            return false;
        }

        public static string Leer()
        {
            Texto retorno = new Texto();
            string datos;
            
            retorno.Leer("JornadaTxt",out datos);
            return datos.ToString();
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Clase: {this.Clase}");
            retorno.AppendLine($"Profesor: {this.Instructor.ToString()}");
            foreach (Alumno item in this.Alumnos)
            {
                retorno.AppendLine(item.ToString());
            }

            return retorno.ToString(); 
        }

        public static bool operator == (Jornada jornada, Alumno alumno)
        {
            foreach (Alumno item in jornada.Alumnos)
            {
                if (item == alumno)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Jornada jornada,Alumno alumno)
        {
            return !(jornada == alumno);
        }

        public static Jornada operator +(Jornada jornada, Alumno alumno)
        {
            if (jornada != alumno)
                jornada.Alumnos.Add(alumno);

            return jornada;
        }
        


    }
}
