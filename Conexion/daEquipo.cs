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
    public class daEquipo
    {
        public List<beEquipo> MostrarEquipos()
        {
            List<beEquipo> lstequipos = new List<beEquipo>();

            using (SqlConnection con = Conexion.ConexionSql)
            {
                SqlCommand cmd = new SqlCommand("MOSTRAR_ALM_T_INVENT_CPU", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    beEquipo equipo = new beEquipo();
                    equipo.COD_UNI_CAB = rdr["COD_UNI_CAB"].ToString();
                    equipo.SIS_OPERATIVO = rdr["SIS_OPERATIVO"].ToString();
                    equipo.MEMORIA_RAM = rdr["MEMORIA_RAM"].ToString();
                    equipo.PROCESADOR = rdr["PROCESADOR"].ToString();
                    equipo.DIRECCION_IP = rdr["DIRECCION_IP"].ToString();
                    equipo.PUERTO_USB = rdr["BLOQUEO PUERTO USB"].ToString();
                    equipo.FECHA_COMPRA = Convert.ToDateTime(rdr["FECHA_COMPRA"]);
                    equipo.FECHA_REVISION = Convert.ToDateTime(rdr["FECHA_REVISION"]);
                    equipo.AREA = rdr["AREA"].ToString();
                    equipo.ESTADO = rdr["ESTADO"].ToString();
                    equipo.MODIFICACIONES = rdr["MODIFICACIONES"].ToString();

                    lstequipos.Add(equipo);
                }
                con.Close();
            }
            return lstequipos;
        }

        public bool InsertarPC(beEquipo datos)
        {
            bool res = false;
            try
            {
                SqlConnection conexion = Conexion.ConexionSql;
                SqlCommand cmd = conexion.CreateCommand();
                cmd.CommandText = "INS_ALM_T_INVENT_CPU";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter par1 = cmd.Parameters.Add("@COD_UNI_CAB", SqlDbType.VarChar, 50);
                par1.Direction = ParameterDirection.Input;
                par1.Value = datos.COD_UNI_CAB;

                SqlParameter par2 = cmd.Parameters.Add("@SIS_OPERATIVO", SqlDbType.VarChar, 50);
                par2.Direction = ParameterDirection.Input;
                par2.Value = datos.SIS_OPERATIVO;

                SqlParameter par3 = cmd.Parameters.Add("@MEMORIA_RAM", SqlDbType.VarChar, 50);
                par3.Direction = ParameterDirection.Input;
                par3.Value = datos.MEMORIA_RAM;

                SqlParameter par4 = cmd.Parameters.Add("@PROCESADOR", SqlDbType.VarChar, 50);
                par4.Direction = ParameterDirection.Input;
                par4.Value = datos.PROCESADOR;

                SqlParameter par5 = cmd.Parameters.Add("@DIRECCION_IP", SqlDbType.VarChar, 50);
                par5.Direction = ParameterDirection.Input;
                par5.Value = datos.DIRECCION_IP;

                SqlParameter par6 = cmd.Parameters.Add("@PUERTO_US", SqlDbType.VarChar, 50);
                par6.Direction = ParameterDirection.Input;
                par6.Value = datos.PUERTO_USB;

                SqlParameter par7 = cmd.Parameters.Add("@FECHA_COMPRA", SqlDbType.Date);
                par7.Direction = ParameterDirection.Input;
                par7.Value = datos.FECHA_COMPRA;

                SqlParameter par8 = cmd.Parameters.Add("@FECHA_REVISION", SqlDbType.Date);
                par8.Direction = ParameterDirection.Input;
                par8.Value = datos.FECHA_REVISION;

                SqlParameter par9 = cmd.Parameters.Add("@AREA", SqlDbType.VarChar, 50);
                par9.Direction = ParameterDirection.Input;
                par9.Value = datos.AREA;

                SqlParameter par10 = cmd.Parameters.Add("@ESTADO", SqlDbType.VarChar, 50);
                par10.Direction = ParameterDirection.Input;
                par10.Value = datos.ESTADO;

                SqlParameter par11 = cmd.Parameters.Add("@MODIFICACIONES", SqlDbType.VarChar, 50);
                par11.Direction = ParameterDirection.Input;
                par11.Value = datos.MODIFICACIONES;

                conexion.Open();
                if (cmd.ExecuteNonQuery() > 0)
                    res = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return res;
        }

        public bool ActualizarPC(beEquipo datos)
        {
            bool res = false;
            try
            {
                SqlConnection conexion = Conexion.ConexionSql;
                SqlCommand cmd = conexion.CreateCommand();
                cmd.CommandText = "MOD_ALM_T_INVENT_CPU";
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("@COD_UNI_CAB", datos.COD_UNI_CAB);

                SqlParameter par1 = cmd.Parameters.Add("@SIS_OPERATIVO", SqlDbType.VarChar, 50);
                par1.Direction = ParameterDirection.Input;
                par1.Value = datos.SIS_OPERATIVO;

                SqlParameter par2 = cmd.Parameters.Add("@MEMORIA_RAM", SqlDbType.VarChar, 50);
                par2.Direction = ParameterDirection.Input;
                par2.Value = datos.MEMORIA_RAM;

                SqlParameter par3 = cmd.Parameters.Add("@PROCESADOR", SqlDbType.VarChar, 50);
                par3.Direction = ParameterDirection.Input;
                par3.Value = datos.PROCESADOR;

                SqlParameter par4 = cmd.Parameters.Add("@DIRECCION_IP", SqlDbType.VarChar, 50);
                par4.Direction = ParameterDirection.Input;
                par4.Value = datos.DIRECCION_IP;

                SqlParameter par5 = cmd.Parameters.Add("@PUERTO_US", SqlDbType.VarChar, 50);
                par5.Direction = ParameterDirection.Input;
                par5.Value = datos.PUERTO_USB;

                SqlParameter par6 = cmd.Parameters.Add("@FECHA_COMPRA", SqlDbType.Date);
                par6.Direction = ParameterDirection.Input;
                par6.Value = datos.FECHA_COMPRA;

                SqlParameter par7 = cmd.Parameters.Add("@FECHA_REVISION", SqlDbType.Date);
                par7.Direction = ParameterDirection.Input;
                par7.Value = datos.FECHA_REVISION;

                SqlParameter par8 = cmd.Parameters.Add("@AREA", SqlDbType.VarChar, 50);
                par8.Direction = ParameterDirection.Input;
                par8.Value = datos.AREA;

                SqlParameter par9 = cmd.Parameters.Add("@ESTADO", SqlDbType.VarChar, 50);
                par9.Direction = ParameterDirection.Input;
                par9.Value = datos.ESTADO;

                SqlParameter par10 = cmd.Parameters.Add("@MODIFICACIONES", SqlDbType.VarChar, 50);
                par10.Direction = ParameterDirection.Input;
                par10.Value = datos.MODIFICACIONES;

                if (cmd.ExecuteNonQuery() > 0)
                    conexion.Close();
                res = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return res;
        }

        public void EliminarPC(string cod)
        {
            SqlConnection conexion = Conexion.ConexionSql;
            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandText = "ELM_ALM_T_INVENT_CPU";
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@COD_UNI_CAB", cod);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
