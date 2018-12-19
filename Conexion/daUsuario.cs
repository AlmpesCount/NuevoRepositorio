using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Conexion
{
    public class daUsuario
    {
        public List<beUsuario> MostrarUsuarios()
        {
            List<beUsuario> lstusuarios = new List<beUsuario>();

            using (SqlConnection con = Conexion.ConexionSql)
            {
                SqlCommand cmd = new SqlCommand("MOSTRAR_ALM_T_USUARIO_CAB", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    beUsuario usuarios = new beUsuario();
                    usuarios.COD_USU_CAB = rdr["COD_USU_CAB"].ToString();
                    usuarios.APE_PATERNO = rdr["APE_PATERNO"].ToString();
                    usuarios.APE_MATERNO = rdr["APE_MATERNO"].ToString();
                    usuarios.NOMBRES = rdr["NOMBRES"].ToString();
                    usuarios.DOCUMENTO = rdr["DOCUMENTO"].ToString();
                    usuarios.CARGO = rdr["CARGO"].ToString();
                    usuarios.FECHA_INGRESO = Convert.ToDateTime(rdr["FECHA_INGRESO"]);
                    usuarios.AREA = rdr["AREA"].ToString();
                    usuarios.ESTADO = rdr["ESTADO"].ToString();

                    lstusuarios.Add(usuarios);
                }
                con.Close();
            }
            return lstusuarios;
        }

        public List<beUsuario> ObtenerCodigo(beUsuario cod)
        {
            List<beUsuario> lstusuarios = new List<beUsuario>();

            using(SqlConnection conexion = Conexion.ConexionSql)
            {
                SqlCommand cmd = conexion.CreateCommand();
                cmd.CommandText = "OBTENER_CODIGO";
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("@APE_PATERNO", cod.APE_PATERNO);
                cmd.Parameters.AddWithValue("@APE_MATERNO", cod.APE_MATERNO);
                cmd.Parameters.AddWithValue("@NOMBRES", cod.NOMBRES);

                SqlDataReader codigo = cmd.ExecuteReader();
                while(codigo.Read())
                {
                    beUsuario user = new beUsuario();
                    user.COD_USU_CAB = codigo["COD_USU_CAB"].ToString();

                    lstusuarios.Add(user);
                }
                conexion.Close();
            }
            return lstusuarios;
        }  
    }
}
