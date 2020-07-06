using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class GuardaString
    {
        public static bool Guardar(this String dato, string nombreArchivo)
        {
            bool retorno = default;
            if (!(nombreArchivo is null))
            {
                StringBuilder path = new StringBuilder();
                path.Append(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
                path.Append($"\\{nombreArchivo}");
                StreamWriter toWrite = new StreamWriter(path.ToString(), true);
                try
                {
                    toWrite.WriteLine(dato);
                    retorno = true;

                }
                catch (Exception)
                {
                    throw new Exception("No se ha podido guardar el archivo");
                }
                finally
                {
                    toWrite.Close();
                }
            }

            return retorno;

        }

    }
}

