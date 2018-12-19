using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Conexion
{
    public class daConsultaReporte
    {
        public List<Object> TotalTabla(beConsultaReportePrincipal Data)
        {
            List<Object> lstReporte = new List<Object>();

            using (SqlConnection con = Conexion.ConexionSql)
            {
                SqlCommand cmd = new SqlCommand("WEB_SITE_Data_General", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@id", Data.TablaID);
                cmd.Parameters.AddWithValue("@Fecha_1", Data.FechaInicio);
                cmd.Parameters.AddWithValue("@Fecha_2", Data.FechaFin);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (Data.TablaID == 1)
                    {
                        beReporte1 conrep = new beReporte1();
                        conrep.Zona = rdr["Zona"].ToString();
                        conrep.Semana = rdr["Semana"].ToString();
                        conrep.DiaSemana = rdr["DiaSemana"].ToString();
                        conrep.Fecha = rdr["Fecha"].ToString();
                        conrep.NroVenta = rdr["N° Venta"].ToString();
                        conrep.NroVeValida = rdr["N° Ven. Valida"].ToString();
                        conrep.Dotacion = rdr["Dotacion"].ToString();
                        conrep.RecorridoDia = rdr["Recorrido por Dia"].ToString();
                        conrep.ContactoEfectivoTitular = rdr["Contacto Efectivo con Titular"].ToString();
                        conrep.ContactoTerceroRelacionado = rdr["Contacto con Tercero Relacionado"].ToString();
                        conrep.RecorridoReal = rdr["Recorrido Real"].ToString();
                        conrep.CETReal = rdr["CET Real"].ToString();
                        conrep.BBDDAsignada = rdr["BBDD Asignada"].ToString();
                        conrep.RecorridoDiaTiempo = rdr["Recorrido por Dia Tiempo"].ToString();
                        conrep.CETTiempo = rdr["CET Tiempo"].ToString();
                        conrep.CTRTiempo = rdr["CTR Tiempo"].ToString();
                        conrep.VentasTiempo = rdr["Ventas Tiempo"].ToString();
                        conrep.RecorridoUnico = rdr["Recorrido Unico"].ToString();
                        conrep.CETUnico = rdr["CET Unico"].ToString();
                        conrep.Indecopi = rdr["Indecopi"].ToString();
                        conrep.RetiroLeads = rdr["Retiro Leads"].ToString();

                        lstReporte.Add(conrep);
                    }

                    if(Data.TablaID == 10)
                    {
                        beConsultaReporte conrep = new beConsultaReporte();
                        conrep.Periodo = rdr["Periodo"].ToString();
                        conrep.PeriodoOrd = rdr["PeriodoOrd"].ToString();
                        conrep.Mes = rdr["Mes"].ToString();
                        conrep.Anio = rdr["Anio"].ToString();
                        conrep.TipoVenta = rdr["TipoVenta"].ToString();
                        conrep.Cantidad = Convert.ToInt32(rdr["Cantidad"].ToString());

                        lstReporte.Add(conrep);
                    }
                    if (Data.TablaID == 11)
                    {
                        beReporte11 conrep = new beReporte11();
                        conrep.Promotor = rdr["Promotor"].ToString();
                        conrep.Supervisor = rdr["Supervisor"].ToString();
                        conrep.VentaTotal = Convert.ToInt32(rdr["1.Venta Total"].ToString());
                        conrep.VentaValida = Convert.ToInt32(rdr["2.Venta Valida"].ToString());
                        conrep.VentaAprobada = Convert.ToInt32(rdr["3.Venta Aprobada"].ToString());
                        conrep.Dia = Convert.ToInt32(rdr["Dia"].ToString());

                        lstReporte.Add(conrep);
                    }
                    if (Data.TablaID == 12)
                    {
                        beReporte12 conrep = new beReporte12();
                        conrep.ID = Convert.ToInt32(rdr["ID"].ToString());
                        conrep.DIA = Convert.ToInt32(rdr["DIA"].ToString());
                        conrep.N_Doc = rdr["N_Doc"].ToString();
                        conrep.FECHA_VENTA = rdr["FECHA_VENTA"].ToString();
                        conrep.SUPERVISOR = rdr["SUPERVISOR"].ToString();
                        conrep.N_Solicitud = rdr["N_Solicitud"].ToString();
                        conrep.Fecha_Ing = rdr["Fecha_Ing"].ToString();
                        conrep.Cod_Promt = rdr["Cód_Promt"].ToString();
                        conrep.Apell_Cliente1 = rdr["Apell_Cliente1"].ToString();
                        conrep.Descripcion = rdr["DESCRIPCION"].ToString();
                        conrep.ST3 = rdr["ST3"].ToString();
                        conrep.ST1 = rdr["ST1"].ToString();
                        conrep.Glosa = rdr["GLOSA"].ToString();
                        conrep.RT95FACT = rdr["RT95FACT"].ToString();
                        conrep.Mes = rdr["MES"].ToString();

                        lstReporte.Add(conrep);
                    }
                    if (Data.TablaID == 13)
                    {
                        beReporte13 conrep = new beReporte13();
                        conrep.FVenta = rdr["FVenta"].ToString();
                        conrep.DNI = rdr["Dni"].ToString();
                        conrep.Estado_BO = rdr["Estado Bo"].ToString();
                        conrep.FAprobado = rdr["FAprobado"].ToString();
                        conrep.NroSol = rdr["NroSol"].ToString();
                        conrep.FActivado = rdr["FActivado"].ToString();
                        conrep.ActAcum3  = rdr["ActAcum3"].ToString();
                        conrep.ActAcum2 = Convert.ToInt32(rdr["ActAcum2"].ToString());
                        conrep.Act1 = Convert.ToInt32(rdr["Act1"].ToString());
                        conrep.Act2 = Convert.ToInt32(rdr["Act2"].ToString());
                        conrep.Act3 = Convert.ToInt32(rdr["Act3"].ToString());
                        conrep.CVenta = Convert.ToInt32(rdr["CVenta"].ToString());
                        conrep.CAprobado = Convert.ToInt32(rdr["CAprobado"].ToString());
                        conrep.CActivado = Convert.ToInt32(rdr["CActivado"].ToString());

                        lstReporte.Add(conrep);
                    }
                    if (Data.TablaID == 28)
                    {
                        beReporte28 conrep = new beReporte28();
                        conrep.DNI = rdr["DNI"].ToString();
                        conrep.CLIENTE = rdr["CLIENTE"].ToString();
                        conrep.PROMOTOR = rdr["PROMOTOR"].ToString();
                        conrep.FECHA_VENTA = rdr["FECHA_VENTA"].ToString();
                        conrep.FECHA_ACTU_BO = rdr["FECHA_ACTU_BO"].ToString();
                        conrep.ESTADO_BO = rdr["ESTADO_BO"].ToString();
                        conrep.COMENTARIO = rdr["COMENTARIO"].ToString();
                        conrep.AUDITOR = rdr["AUDITOR"].ToString();
                        conrep.SUPERVISOR = rdr["SUPERVISOR"].ToString();

                        lstReporte.Add(conrep);
                    }
                    
                }
                con.Close();
            }
            return lstReporte;
        }

        /*public DataTable MostrarTablaConsulta(beConsultaReportePrincipal Data)
        {
            DataTable DataReporte = new DataTable();

            using (SqlConnection con = Conexion.ConexionSql)
            {
                SqlCommand cmd = new SqlCommand("WEB_SITE_Data_General", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@id", Data.TablaID);
                cmd.Parameters.AddWithValue("@Fecha_1", Data.FechaInicio);
                cmd.Parameters.AddWithValue("@Fecha_2", Data.FechaFin);
                SqlDataReader rdr = cmd.ExecuteReader();

                DataReporte.Load(rdr);
                con.Close();
            }
            return DataReporte;
        }*/

        public beConsultaReporte MostrarConsulta()
        {
            beConsultaReporte conrep = new beConsultaReporte();

            using (SqlConnection con = Conexion.ConexionSql)
            {
                SqlCommand cmd = new SqlCommand("WEB_SITE_Data_Prueba_10", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    conrep.Periodo = rdr["Periodo"].ToString();
                    conrep.PeriodoOrd = rdr["PeriodoOrd"].ToString();
                    conrep.Mes = rdr["Mes"].ToString();
                    conrep.Anio = rdr["Año"].ToString();
                    conrep.TipoVenta = rdr["TipoVenta"].ToString();
                    conrep.Cantidad = Convert.ToInt32(rdr["Cantidad"].ToString());
                }
                con.Close();
            }
            return conrep;
        }
    }
}
