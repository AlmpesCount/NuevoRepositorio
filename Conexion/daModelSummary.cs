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
    public class daModelSummary
    {
        public List<beReporte11> First_SummaryMonth(beConsultaReportePrincipal Data)
        {
            List<beReporte11> FirstList = new List<beReporte11>();

            using (SqlConnection con = Conexion.ConexionSql)
            {
                SqlCommand cmd = new SqlCommand("WEB_SITE_MODEL_REPORT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@Id", 7);
                cmd.Parameters.AddWithValue("@Fecha1", Data.FechaInicio);
                cmd.Parameters.AddWithValue("@Fecha2", Data.FechaFin);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    beReporte11 conrep = new beReporte11();
                    conrep.Dia = rdr["Dia"].ToString();
                    conrep.VentaTotal = Convert.ToInt32(rdr["VentaTotal"].ToString());
                    conrep.VentaValida = Convert.ToInt32(rdr["VentaValida"].ToString());
                    conrep.VentaAprobada = Convert.ToInt32(rdr["VentaAprobada"].ToString());

                    if (conrep.VentaTotal != 0)
                    {
                        conrep.PassingValido = Math.Round((((double)conrep.VentaValida / (double)conrep.VentaTotal * 100)), 0);
                    }
                    else
                    {
                        conrep.PassingValido = 0;
                    }
                    if (conrep.VentaValida != 0)
                    {

                        conrep.PassingAprobado = Math.Round((((double)conrep.VentaAprobada / (double)conrep.VentaValida * 100)), 0);
                    }

                    FirstList.Add(conrep);
                }
                con.Close();
            }
            return FirstList;
        }

        public List<beReporte11> Second_SummaryMonth(beConsultaReportePrincipal Data)
        {
            List<beReporte11> SecondMonth = new List<beReporte11>();

            using (SqlConnection con = Conexion.ConexionSql)
            {
                SqlCommand cmd = new SqlCommand("WEB_SITE_MODEL_REPORT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@Id", 6);
                cmd.Parameters.AddWithValue("@Fecha1", Data.FechaInicio);
                cmd.Parameters.AddWithValue("@Fecha2", Data.FechaFin);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    beReporte11 conrep = new beReporte11();
                    conrep.Promotor = rdr["Promotor"].ToString();
                    conrep.Supervisor = rdr["Supervisor"].ToString();
                    conrep.VentaTotal = Convert.ToInt32(rdr["VentaTotal"].ToString());
                    conrep.VentaValida = Convert.ToInt32(rdr["VentaValida"].ToString());
                    conrep.VentaAprobada = Convert.ToInt32(rdr["VentaAprobada"].ToString());

                    if (conrep.VentaTotal != 0)
                    {
                        conrep.PassingValido = Math.Round((((double)conrep.VentaValida / (double)conrep.VentaTotal * 100)), 0);
                    }
                    else
                    {
                        conrep.PassingValido = 0;
                    }
                    if (conrep.VentaValida != 0)
                    {

                        conrep.PassingAprobado = Math.Round((((double)conrep.VentaAprobada / (double)conrep.VentaValida * 100)), 0);
                    }

                    SecondMonth.Add(conrep);
                }
                con.Close();
            }
            return SecondMonth;
        }
    }
}
