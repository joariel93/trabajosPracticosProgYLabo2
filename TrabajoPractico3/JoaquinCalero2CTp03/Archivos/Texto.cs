using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Archivos
{
    public class Texto: IArchivo<string>
    {

        /// <summary>
        /// Implementacion del metodo Guardar de la interface, crea un archivo de texto con los datos y nombre que recibe
        /// </summary>
        /// <param name="archivo">Nombre o ruta que tendra el archivo</param>
        /// <param name="datos">Datos que se guardaran dentro del archivo</param>
        /// <returns></returns>
        public bool Guardar(string archivo, string datos)
        {
            using (StreamWriter streamGuardar = new StreamWriter(archivo+".txt"))
            {
                streamGuardar.Write(datos);
                return true;
            }
            throw new ArchivosException();
        }

        /// <summary>
        /// Implementacion del metodo Leer de la interface, en caso de que el nombre o ruta del archivo indicado exista lo retorna como string
        /// </summary>
        /// <param name="archivo">Nombre o ruta del archivo</param>
        /// <param name="datos">Retorno del archivo</param>
        /// <returns></returns>

        public bool Leer(string archivo, out string datos)
        {

            if(archivo!=null&&File.Exists(archivo+".txt"))
            { 
            using (StreamReader lector=new StreamReader(archivo+".txt"))
            {
                    datos=lector.ReadToEnd();
                    return true;
            }
            }
            datos = null;
            throw new ArchivosException();
        }
    }
}
