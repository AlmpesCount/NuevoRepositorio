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
    public class daLogin
    {
        public List<beLogin> DatosLogeo(beLogin usuario)
        {
            List<beLogin> lstlogin = new List<beLogin>();
            using (SqlConnection conexion = Conexion.ConexionSql)
                {
                    SqlCommand cmd = conexion.CreateCommand();
                    cmd.CommandText = "LOGIN_USER";
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    cmd.Parameters.AddWithValue("@USUARIO", usuario.UserName);
                    cmd.Parameters.AddWithValue("@CLAVE", usuario.Password);
                    //cmd.ExecuteNonQuery();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        beLogin login = new beLogin();
                        login.UserName = rdr["USUARIO"].ToString();
                        login.Password = rdr["CLAVE"].ToString();
                        login.Nombres = rdr["NOMBRES"].ToString();
                        login.Ape_Paterno = rdr["APE_PATERNO"].ToString();
                        login.Ape_Materno = rdr["APE_MATERNO"].ToString();
                        login.DNI = rdr["DNI"].ToString();
                        login.PERFIL = rdr["PERFIL"].ToString();

                        lstlogin.Add(login);
                    }
                    conexion.Close();
                }
                return lstlogin;    
        }

        public List<beUserCRM> LoginUserCRM(beUserCRM user)
        {
            List<beUserCRM> lstuserCRM = new List<beUserCRM>();

            using (SqlConnection con = Conexion.ConexionSql)
            {
                string SQL = "SELECT * FROM CRM_LOGIN_LOG WHERE USUARIO ='"+user.USUARIO+"' AND CARGO ='"+user.CARGO+"' AND DIA=13";
                SqlCommand cmd = new SqlCommand(SQL, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    beUserCRM userCRM = new beUserCRM();
                    userCRM.USUARIO = rdr["USUARIO"].ToString();
                    userCRM.CARGO = rdr["CARGO"].ToString();

                    lstuserCRM.Add(userCRM);
                }
                con.Close();
            }
            return lstuserCRM;
        }
    }
}
