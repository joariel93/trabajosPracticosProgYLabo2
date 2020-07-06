using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public static class PaqueteDAO
    {
        public delegate void Houston(string mensaje);
        public static event Houston TenemosUnProblema;

        #region Atributos
        static SqlConnection conexion;
        static SqlCommand comando;
        #endregion

        static PaqueteDAO()
        {
            conexion = new SqlConnection("Data Source=.;Database=correo-sp-2017;Trusted_Connection=True;");
            comando = new SqlCommand();
        }

        public static bool Insertar(Paquete p)
        {

            try
            {
                SqlDataReader ejecutor;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.Parameters.Clear();
                comando.CommandText = "INSERT INTO Paquetes (direccionEntrega,trackingID,alumno) VALUES (@laDireccion,@elTracking,@elBurro)";
                comando.Parameters.Add(new SqlParameter("laDireccion", p.DireccionEntrega));
                comando.Parameters.Add(new SqlParameter("elTracking", p.TrackingID));
                comando.Parameters.Add(new SqlParameter("elBurro", "Joaquin Calero"));

                ejecutor = comando.ExecuteReader();
                return true;
            }
            catch (SqlException excepcion)
            {

                TenemosUnProblema.Invoke(excepcion.Message);
                return false;
            }

            finally
            {
                conexion.Close();

            }
        }



    }
}

