using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Conexion
{
    public class Conexion
    {
        public static SqlConnection ConexionSql
        {
            get
            {
                SqlConnection conexion = null;
                try
                {
                    string cadena = ConfigurationManager.ConnectionStrings["conexionAlmpes"].ToString();
                    conexion = new SqlConnection(cadena);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return conexion;
            }
        }
    }
}
