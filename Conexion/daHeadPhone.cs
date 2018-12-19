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
    public class daHeadPhone
    {
        //public List<beHeadPhone> MostrarHeadPhone()
        //{
        //    List<beHeadPhone> lsthead = new List<beHeadPhone>();

        //    using (SqlConnection con = Conexion.ConexionSql)
        //    {
        //        SqlCommand cmd = new SqlCommand("MOSTRAR_ALM_T_INVENT_HEAD", con);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        con.Open();
        //        SqlDataReader rdr = cmd.ExecuteReader();

        //        while (rdr.Read())
        //        {
        //            beHeadPhone head = new beHeadPhone();
        //            head.COD_HEAD = rdr["COD_HEAD"].ToString();
        //            head.ESTADO = rdr["ESTADO"].ToString();
        //            head.ASIGNADO = rdr["ASIGNADO"].ToString();
        //            head.COD_USU_CAB = rdr["COD_HEAD"].ToString();
        //            head.FECHA_ENTREGA = Convert.ToDateTime(rdr["FECHA_ENTREGA"]);
        //            head.OBSERVACION = rdr["OBSERVACION"].ToString();

        //            lsthead.Add(head);
        //        }
        //        con.Close();
        //    }
        //    return lsthead;
        //}

        public DataTable CargarHeadphone()
        {
            SqlConnection conexion = Conexion.ConexionSql;
            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandText = "MOSTRAR_ALM_T_INVENT_HEAD";
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            SqlDataReader InventarioHead = cmd.ExecuteReader();

            DataTable dtInventarioHead = new DataTable();
            using (InventarioHead)
            {
                dtInventarioHead.Load(InventarioHead);
            }
            return dtInventarioHead;
        }
    }
}
