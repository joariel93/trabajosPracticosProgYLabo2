using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;


namespace ClasesInstanciables
{ 
    
    public class Universidad:Xml<Universidad>
    {
    public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }
        private List<Alumno> alumnos; //Lista de inscriptos
        private List<Jornada> jornada; //Jornadas
        private List<Profesor> profesores; //Lista de quienes pueden dar clases

        /// <summary>
        /// Constructo por defecto de clase, instancia las 3 listas
        /// </summary>
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornada = new List<Jornada>();
            this.profesores = new List<Profesor>();
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

        public List<Profesor> Profesores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }

        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }

        }

        public Jornada this[int i]
        {
            get
            {
                return this.jornada[i];
            }
        }
        

        /// <summary>
        /// Retorna los datos de la universidad como string.
        /// </summary>
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder retorno = new StringBuilder();

            foreach (Jornada item in uni.Jornadas)
            {
                retorno.Append(item.ToString());
            }

            return retorno.ToString();
        }

        /// <summary>
        /// Hace publicos los datos de la universidad
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }

        /// <summary>
        /// Agrega una jornada con la clase y el primero profesor que puede darla
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad g, Universidad.EClases clase)
        {
            Jornada nuevaJornada = new Jornada(clase, g == clase);
            foreach (Alumno item in g.Alumnos)
            {
                if (item == clase)
                    nuevaJornada += item;
            }

            g.jornada.Add(nuevaJornada);
            return g;
        }

        public static Universidad operator +(Universidad u, Alumno a)
        {
           
            if (u != a)
            {
                u.alumnos.Add(a);
                return u;
            }
            else
            throw new AlumnoRepetidoException();
            

        }
        public static Universidad operator +(Universidad u,Profesor p)
        {
            if(u!=p)
                u.profesores.Add(p);
             
            return u;
        }

        public static bool operator ==(Universidad u, Alumno a)
        {
            foreach (Alumno item in u.Alumnos)
            {
                if (a == item)
                    return true;
            }
            return false;
        }
        public static bool operator ==(Universidad u, Profesor i)
        {
            foreach (Profesor item in u.Profesores)
            {
                if (item == i)
                    return true;
            }
            return false;
        }

        public static Profesor operator ==(Universidad u, Universidad.EClases clase)
        {
            foreach (Profesor item in u.profesores)
            {
                if (item == clase)
                    return item;
            }
                throw new SinProfesorException();
        }
        public static bool operator !=(Universidad u, Alumno a)
        {
            return !(u == a);
        }
        public static bool operator !=(Universidad u, Profesor i)
        {
            return !(u == i);
        }

        public static Profesor operator !=(Universidad u, Universidad.EClases clase)
        {
            foreach (Profesor item in u.profesores)
            {
                if (item != clase)
                    return item;
            }
            return null;
        }

        public static bool Guardar (Universidad uni)
        {
            Xml<Universidad> serializador = new Xml<Universidad>();
            if (serializador.Guardar("Universidad", uni))
                return true;

            return false;
        }

        public static Universidad Leer ()
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            Universidad retorno = new Universidad();

            xml.Leer("Universidad",out retorno);               

            return retorno;
        }

    }
}
