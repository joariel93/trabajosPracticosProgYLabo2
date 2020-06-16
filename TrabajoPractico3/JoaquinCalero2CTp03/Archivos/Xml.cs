using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Implementacion del metodo Guardar de la interface, crea un archivo xml con los datos y nombre que recibe
        /// </summary>
        /// <param name="archivo">Nombre o ruta que tendra el archivo</param>
        /// <param name="datos">Datos de clase generica que se guardaran dentro del archivo</param>
        /// <returns></returns>
        public bool Guardar(string archivo, T datos)
        {

            if(archivo!=null&& datos !=null)
            { 
            XmlTextWriter writer = new XmlTextWriter(archivo+".xml", Encoding.UTF8);
            XmlSerializer serializador = new XmlSerializer(typeof(T));
            serializador.Serialize(writer, datos);

            writer.Close();
                return true;
            }
            throw new ArchivosException();
        }

        /// <summary>
        /// Implementacion del metodo Leer de la interface, en caso de que el nombre o ruta del archivo indicado exista lo retorna como el tipo generico que se serializo
        /// </summary>
        /// <param name="archivo">Nombre o ruta del archivo</param>
        /// <param name="datos">Retorno del archivo</param>
        /// <returns></returns>
        public bool Leer(string archivo, out T datos)
        {

            if(archivo!=null&&File.Exists(archivo+".xml"))
            {
                XmlTextReader reader = new XmlTextReader(archivo+".xml");
                XmlSerializer serializador = new XmlSerializer(typeof(T));

                datos = (T)serializador.Deserialize(reader);
                reader.Close();
                return true;
            }
            datos = default(T);
            throw new ArchivosException();
        }
    }
}
