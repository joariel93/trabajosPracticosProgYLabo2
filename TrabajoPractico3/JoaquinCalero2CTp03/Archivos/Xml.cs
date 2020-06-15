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
