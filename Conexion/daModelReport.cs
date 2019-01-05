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
    public class daModelReport
    {
        public List<beReporte8> First_ModelDBPhone(beConsultaReportePrincipal Data)
        {
            List<beReporte8> FirtReport = new List<beReporte8>();

            using (SqlConnection con = Conexion.ConexionSql)
            {
                SqlCommand cmd = new SqlCommand("WEB_SITE_MODEL_REPORT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@Id", 2);
                cmd.Parameters.AddWithValue("@Fecha1", Data.FechaInicio);
                cmd.Parameters.AddWithValue("@Fecha2", Data.FechaFin);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    beReporte8 firstConrep = new beReporte8();
                    firstConrep.Fecha = rdr["Fecha"].ToString();
                    firstConrep.DiaSemana = rdr["DiaSemana"].ToString();
                    firstConrep.Crediscotia1 = Convert.ToInt32(rdr["T1"].ToString());
                    firstConrep.Crediscotia2 = Convert.ToInt32(rdr["T2"].ToString());
                    firstConrep.Crediscotia3 = Convert.ToInt32(rdr["T3"].ToString());
                    firstConrep.Crediscotia4 = Convert.ToInt32(rdr["T4"].ToString());
                    firstConrep.Almpes1 = Convert.ToInt32(rdr["Q1"].ToString());
                    firstConrep.Almpes2 = Convert.ToInt32(rdr["Q2"].ToString());
                    firstConrep.AlmpesCET = Convert.ToInt32(rdr["Cet"].ToString());
                    firstConrep.AlmpesNA = Convert.ToInt32(rdr["NA"].ToString());
                    firstConrep.TotalGeneral =  firstConrep.Crediscotia1 + firstConrep.Crediscotia2 +
                                                firstConrep.Crediscotia3 + firstConrep.Crediscotia4 +
                                                firstConrep.Almpes1 + firstConrep.Almpes2 +
                                                firstConrep.AlmpesCET + firstConrep.AlmpesNA;

                    FirtReport.Add(firstConrep);
                }
                con.Close();
            }
            return FirtReport;
        }

        public List<beReporte8> Second_ModelDBPhone(beConsultaReportePrincipal Data)
        {
            List<beReporte8> SecondReport = new List<beReporte8>();

            using (SqlConnection con = Conexion.ConexionSql)
            {
                SqlCommand cmd = new SqlCommand("WEB_SITE_MODEL_REPORT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@id", 1);
                cmd.Parameters.AddWithValue("@Fecha1", Data.FechaInicio);
                cmd.Parameters.AddWithValue("@Fecha2", Data.FechaFin);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    beReporte8 conrep = new beReporte8();
                    conrep.Periodo = rdr["Periodo"].ToString();
                    conrep.Crediscotia1 = Convert.ToInt32(rdr["T1"].ToString());
                    conrep.Crediscotia2 = Convert.ToInt32(rdr["T2"].ToString());
                    conrep.Crediscotia3 = Convert.ToInt32(rdr["T3"].ToString());
                    conrep.Crediscotia4 = Convert.ToInt32(rdr["T4"].ToString());
                    conrep.Almpes1 = Convert.ToInt32(rdr["Q1"].ToString());
                    conrep.Almpes2 = Convert.ToInt32(rdr["Q2"].ToString());
                    conrep.AlmpesCET = Convert.ToInt32(rdr["Cet"].ToString());
                    conrep.TotalGeneral =     conrep.Crediscotia1 + conrep.Crediscotia2 +
                                              conrep.Crediscotia3 + conrep.Crediscotia4 +
                                              conrep.Almpes1 + conrep.Almpes2 +
                                              conrep.AlmpesCET;

                    SecondReport.Add(conrep);
                }
                con.Close();
            }
            return SecondReport;
        }

        public List<beReporte27> Third_ModelDBPhone(beConsultaReportePrincipal Data)
        {
            List<beReporte27> ThirdReport = new List<beReporte27>();

            using (SqlConnection con = Conexion.ConexionSql)
            {
                SqlCommand cmd = new SqlCommand("WEB_SITE_MODEL_REPORT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@id", 3);
                cmd.Parameters.AddWithValue("@Fecha1", Data.FechaInicio);
                cmd.Parameters.AddWithValue("@Fecha2", Data.FechaFin);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    beReporte27 conrep = new beReporte27();
                    conrep.Descripcion = rdr["Descripcion"].ToString();
                    conrep.Tipo = rdr["Tipo"].ToString();
                    conrep.Almpes1 = Convert.ToInt32(rdr["Q1"].ToString());
                    conrep.Almpes2 = Convert.ToInt32(rdr["Q2"].ToString());
                    conrep.AlmpesCet = Convert.ToInt32(rdr["Cet"].ToString());
                    conrep.AlmpesW1 = Convert.ToInt32(rdr["W1"].ToString());
                    conrep.AlmpesNA = Convert.ToInt32(rdr["NA"].ToString());
                    conrep.AlmpesTotal = conrep.Almpes1 + conrep.Almpes2 + conrep.AlmpesCet + conrep.AlmpesW1 + conrep.AlmpesNA;

                    conrep.Crediscotia1 = Convert.ToInt32(rdr["T1"].ToString());
                    conrep.Crediscotia2 = Convert.ToInt32(rdr["T2"].ToString());
                    conrep.Crediscotia3 = Convert.ToInt32(rdr["T3"].ToString());
                    conrep.Crediscotia4 = Convert.ToInt32(rdr["T4"].ToString());
                    conrep.Crediscotia5 = Convert.ToInt32(rdr["T5"].ToString());
                    conrep.CrediscotiaTotal = conrep.Crediscotia1 + conrep.Crediscotia2 + conrep.Crediscotia3 + conrep.Crediscotia4 + conrep.Crediscotia5;

                    conrep.TotalGeneral = conrep.AlmpesTotal + conrep.CrediscotiaTotal;

                    ThirdReport.Add(conrep);
                }
                con.Close();
            }
            return ThirdReport;
        }

        public List<beReporte9> ModelDBCET(beConsultaReportePrincipal Data)
        {
            List<beReporte9> CETList = new List<beReporte9>();

            using (SqlConnection con = Conexion.ConexionSql)
            {
                SqlCommand cmd = new SqlCommand("WEB_SITE_MODEL_REPORT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@id", 4);
                cmd.Parameters.AddWithValue("@Fecha1", Data.FechaInicio);
                cmd.Parameters.AddWithValue("@Fecha2", Data.FechaFin);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    beReporte9 conrep = new beReporte9();
                    conrep.Periodo = rdr["Periodo"].ToString();
                    conrep.Anio = rdr["Anio"].ToString();
                    conrep.Column0 = Convert.ToInt32(rdr["00.VENTA CRM"].ToString());
                    conrep.Column1 = Convert.ToInt32(rdr["01.CLIENTE ACEPTA OFERTA"].ToString());
                    conrep.Column2 = Convert.ToInt32(rdr["02.NO DESEA POR OFERTA"].ToString());
                    conrep.Column3 = Convert.ToInt32(rdr["03.NO DESEA B POR TASAS"].ToString());
                    conrep.Column4 = Convert.ToInt32(rdr["04.NO CALIFICA"].ToString());
                    conrep.Column5 = Convert.ToInt32(rdr["05.MEJOR OFERTA OTRA ENTIDAD"].ToString());
                    conrep.Column6 = Convert.ToInt32(rdr["06.MALA  EXPERIENCIA"].ToString());
                    conrep.Column7 = Convert.ToInt32(rdr["07.CLIENTE YA CUENTA CON OFERTA"].ToString());
                    conrep.Column8 = Convert.ToInt32(rdr["08.CLIENTE SE ACERCARA AGENCIA"].ToString());
                    conrep.Column9 = Convert.ToInt32(rdr["09.CLIENTE NO DESEA NO INSISTIR"].ToString());
                    conrep.Column11 = Convert.ToInt32(rdr["11.CITA TELEFONICA CON TITULAR"].ToString());
                    conrep.Column12 = Convert.ToInt32(rdr["12.CITA TELEFONICA CON TITULAR"].ToString());
                    conrep.Column13 = Convert.ToInt32(rdr["13.CITA TELEFONICA CON TITULAR"].ToString());

                    CETList.Add(conrep);
                }
                con.Close();
            }
            return CETList;
        }

        public List<beReporte1> First_ModelDBDay(beConsultaReportePrincipal Data)
        {
            List<beReporte1> FirtDay = new List<beReporte1>();

            using (SqlConnection con = Conexion.ConexionSql)
            {
                SqlCommand cmd = new SqlCommand("WEB_SITE_MODEL_REPORT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@id", 5);
                cmd.Parameters.AddWithValue("@Fecha1", Data.FechaInicio);
                cmd.Parameters.AddWithValue("@Fecha2", Data.FechaFin);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    beReporte1 conrep = new beReporte1();
                    conrep.Zona = rdr["Zona"].ToString();
                    conrep.Semana = rdr["Semana"].ToString();
                    conrep.DiaSemana = rdr["DiaSemana"].ToString();
                    conrep.Fecha = rdr["Fecha"].ToString();
                    conrep.NroVenta = Convert.ToInt32(rdr["NVenta"].ToString());
                    conrep.NroVeValida = Convert.ToInt32(rdr["NVenValida"].ToString());
                    conrep.Dotacion = Convert.ToInt32(rdr["Dotacion"].ToString());
                    conrep.RecorridoDia = Convert.ToInt32(rdr["RecorridoporDia"].ToString());
                    conrep.ContactoEfectivoTitular = Convert.ToInt32(rdr["ContEfectTitular"].ToString());
                    conrep.RecorridoReal = Convert.ToInt32(rdr["RecorridoReal"].ToString());
                    conrep.CETReal = Convert.ToInt32(rdr["CETReal"].ToString());
                    conrep.CETTiempo = Convert.ToDouble(rdr["CETTiempo"].ToString());
                    conrep.VentasTiempo = Convert.ToDouble(rdr["VentasTiempo"].ToString());
                    conrep.RecorridoUnico = Convert.ToInt32(rdr["RecorridoUnico"].ToString());
                    conrep.CETUnico = Convert.ToInt32(rdr["CETUnico"].ToString());
                    conrep.BBDDAsignada = Convert.ToInt32(rdr["BBDDAsignada"].ToString());
                    conrep.Indecopi = Convert.ToInt32(rdr["Indecopi"].ToString());
                    conrep.RetiroLeads = Convert.ToInt32(rdr["RetiroLeads"].ToString());
                    conrep.RecorridoDiaTiempo = Convert.ToDouble(rdr["RecorridoDiaTiempo"].ToString());
                    conrep.CTRTiempo = Convert.ToDouble(rdr["CTRTiempo"].ToString());
                    conrep.ContactoTerceroRelacionado = Convert.ToInt32(rdr["ContTercRelacionado"].ToString());

                    //FALTAN COLOCAR COLUMNAS TOTALES
                    //if (conrep.Fecha.Contains("01"))
                    //{
                    //    conrep.RecorridoAcumulado = conrep.RecorridoUnico;
                    //}
                    //else
                    //{
                    //    conrep.RecorridoAcumulado = conrep.RecorridoUnico + conrep.RecorridoAcumulado;
                    //}

                    if (conrep.RecorridoReal != 0)
                    {
                        conrep.NroVueltas = Math.Round(((double)conrep.RecorridoDia / (double)conrep.RecorridoReal), 1);
                        conrep.PorcCETReal = Math.Round((((double)conrep.CETReal / (double)conrep.RecorridoReal) * 100), 1);
                    }
                    else
                    {
                        conrep.NroVueltas = 0;
                    }
                    if (conrep.NroVenta != 0)
                    {

                        conrep.VentasTMO = Math.Round(((double)conrep.VentasTiempo / (double)conrep.NroVenta), 1);
                    }
                    if (conrep.ContactoEfectivoTitular != 0)
                    {
                        conrep.CETTMO = Math.Round(((double)conrep.CETTiempo / (double)conrep.ContactoEfectivoTitular), 1);
                    }
                    else
                    {
                        conrep.CETTMO = 0;
                    }
                    if (conrep.CETReal != 0)
                    {
                        conrep.PorcAcepReal = Math.Round((((double)conrep.NroVenta / (double)conrep.CETReal) * 100), 1);
                    }
                    else
                    {
                        conrep.PorcAcepReal = 0;
                    }

                    FirtDay.Add(conrep);
                }
                con.Close();
            }
            return FirtDay;
        }

        public List<beReporte2> Second_ModelDBDay(beConsultaReportePrincipal Data)
        {
            List<beReporte2> SecondDay = new List<beReporte2>();

            using (SqlConnection con = Conexion.ConexionSql)
            {
                SqlCommand cmd = new SqlCommand("WEB_SITE_Data_General", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@id", 2);
                cmd.Parameters.AddWithValue("@Fecha_1", Data.FechaInicio);
                cmd.Parameters.AddWithValue("@Fecha_2", Data.FechaFin);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    beReporte2 conrep = new beReporte2();

                    conrep.FRecep = rdr["FRecep"].ToString();
                    conrep.Zona = rdr["Zona"].ToString();
                    conrep.NroVenta = Convert.ToInt32(rdr["NroVenta"].ToString());
                    conrep.NroVenValida = Convert.ToInt32(rdr["NroVenValida"].ToString());
                    conrep.BBDD = Convert.ToInt32(rdr["BBDD"].ToString());
                    conrep.RecorridoReal = Convert.ToInt32(rdr["RecorridoReal"].ToString());
                    conrep.CETReal = Convert.ToInt32(rdr["CETReal"].ToString());
                    conrep.Recorrido = Convert.ToInt32(rdr["Recorrido"].ToString());
                    conrep.CET = Convert.ToInt32(rdr["CET"].ToString());
                    conrep.Indecopi = Convert.ToInt32(rdr["Indecopi"].ToString());
                    conrep.RetiroLead = Convert.ToInt32(rdr["RetiroLead"].ToString());                    

                    if (conrep.RecorridoReal != 0)
                    {
                        conrep.NroVuelta = Math.Round(((double)conrep.Recorrido / (double)conrep.RecorridoReal), 1);
                        conrep.PorcCET = Math.Round(((double)conrep.CETReal / (double)conrep.RecorridoReal * 100), 0);
                    }
                    else
                    {
                        conrep.NroVuelta = 0;
                        conrep.PorcCET = 0;
                    }
                    if (conrep.CETReal != 0)
                    {
                        conrep.PorcAceptacion = Math.Round(((double)conrep.NroVenta / (double)conrep.CETReal * 100), 0);
                        conrep.CETVueltas = Math.Round(((double)conrep.CET / (double)conrep.CETReal), 1);
                    }
                    else
                    {
                        conrep.PorcAceptacion = 0;
                        conrep.CETVueltas = 0;
                    }
                    if (conrep.BBDD != 0)
                    {
                        conrep.AvancePorc = Math.Round(((double)conrep.RecorridoReal / (double)conrep.BBDD * 100), 0);
                        conrep.PorcEfectividad = Math.Round(((double)conrep.NroVenta / (double)conrep.BBDD * 100), 1);
                    }
                    else
                    {
                        conrep.AvancePorc = 0;
                        conrep.PorcEfectividad = 0;
                    }

                    SecondDay.Add(conrep);
                }
                con.Close();
            }
            return SecondDay;
        }

        public List<beReporte25> Third_ModelDBDay(beConsultaReportePrincipal Data)
        {
            List<beReporte25> ThirdDay = new List<beReporte25>();

            using (SqlConnection con = Conexion.ConexionSql)
            {
                SqlCommand cmd = new SqlCommand("WEB_SITE_Data_General", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@id", 25);
                cmd.Parameters.AddWithValue("@Fecha_1", Data.FechaInicio);
                cmd.Parameters.AddWithValue("@Fecha_2", Data.FechaFin);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    beReporte25 conrep = new beReporte25();

                    conrep.Periodo = rdr["Periodo"].ToString();
                    conrep.F_Recep = rdr["F_Recep"].ToString();
                    conrep.NroVenta = Convert.ToInt32(rdr["N° Venta"].ToString());
                    conrep.NroVenValida = Convert.ToInt32(rdr["N° Ven. Valida"].ToString());
                    conrep.LlamadasTotal = Convert.ToInt32(rdr["Llamadas Total"].ToString());
                    conrep.LlamadasUnico = Convert.ToInt32(rdr["Llamadas Unico"].ToString());
                    conrep.CETUnico = Convert.ToInt32(rdr["CET Unico"].ToString());
                    conrep.BBDDAcumulado = Convert.ToInt32(rdr["BBDD Acumulado"].ToString());
                    conrep.RetiroLeads = Convert.ToInt32(rdr["Retiro de Leads"].ToString());
                    conrep.CETTiempo = Convert.ToInt32(rdr["CET Tiempo"].ToString());
                    conrep.VentasTiempo = Convert.ToInt32(rdr["Ventas Tiempo"].ToString());

                    conrep.BBDDTotal = conrep.BBDDAcumulado - conrep.RetiroLeads;

                    if (conrep.LlamadasUnico != 0)
                    {
                        conrep.NroVueltas = Math.Round(((double)conrep.LlamadasTotal / (double)conrep.LlamadasUnico), 1);
                        conrep.AvanceCET = Math.Round(((double)conrep.CETUnico / (double)conrep.LlamadasUnico * 100), 0);
                    }
                    else
                    {
                        conrep.NroVueltas = 0;
                        conrep.AvanceCET = 0;
                    }

                    if (conrep.NroVenta != 0)
                    {
                        conrep.OKAlmpes = Math.Round(((double)conrep.NroVenValida / (double)conrep.NroVenta * 100), 0);
                        conrep.VentasTMO = Math.Round(((double)conrep.VentasTiempo / (double)conrep.NroVenta), 2);
                    }
                    else
                    {
                        conrep.OKAlmpes = 0;
                        conrep.VentasTMO = 0;
                    }

                    if (conrep.BBDDAcumulado != 0)
                    {
                        conrep.AvanceBBDD = Math.Round(((double)conrep.LlamadasUnico / (double)conrep.BBDDAcumulado * 100), 0);
                    }
                    else
                    {
                        conrep.AvanceBBDD = 0;
                    }

                    if (conrep.BBDDTotal != 0)
                    {
                        conrep.PorcBBDD = Math.Round(((double)conrep.LlamadasUnico / (double)conrep.BBDDTotal * 100), 0);
                    }
                    else
                    {
                        conrep.PorcBBDD = 0;
                    }
                    if (conrep.CETUnico != 0)
                    {
                        conrep.AceptacionPorc = Math.Round(((double)conrep.NroVenta / (double)conrep.CETUnico * 100), 0);
                    }
                    else
                    {
                        conrep.AceptacionPorc = 0;
                    }

                    ThirdDay.Add(conrep);
                }
                con.Close();
            }
            return ThirdDay;
        }
    }
}
