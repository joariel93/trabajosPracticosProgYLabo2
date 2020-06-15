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

        public bool Guardar(string archivo, string datos)
        {
            using (StreamWriter streamGuardar = new StreamWriter(archivo+".txt"))
            {
                streamGuardar.Write(datos);
                return true;
            }
            throw new ArchivosException();
        }

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
