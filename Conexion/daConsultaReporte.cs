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
                    if (Data.TablaID == 2)
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
     
                        conrep.NroVuelta = Math.Round(((double)conrep.Recorrido / (double)conrep.RecorridoReal), 1);
                        conrep.PorcCET = Math.Round(((double)conrep.CETReal / (double)conrep.RecorridoReal * 100), 0);
                        conrep.PorcAceptacion = Math.Round(((double)conrep.NroVenta / (double)conrep.CETReal * 100), 0);
                        conrep.AvancePorc = Math.Round(((double)conrep.RecorridoReal / (double)conrep.BBDD * 100), 0);
                        conrep.PorcEfectividad = Math.Round(((double)conrep.NroVenta / (double)conrep.BBDD * 100), 0);
                        conrep.CETVueltas = Math.Round(((double)conrep.CET / (double)conrep.CETReal), 1);

                        lstReporte.Add(conrep);
                    }

                    if (Data.TablaID == 5)
                    {
                        beReporte5 conrep = new beReporte5();
                        conrep.TipoMes = rdr["TipoMes"].ToString();
                        conrep.EstadoVer = rdr["EstadoVer"].ToString();
                        conrep.Mes = Convert.ToInt32(rdr["Mes"].ToString());
                        conrep.DNI = rdr["Dni"].ToString();
                        conrep.Cliente = rdr["Cliente"].ToString();
                        conrep.NroSolicitud = rdr["N° Solicitud"].ToString();
                        conrep.FechaVenta = rdr["FechaVenta"].ToString();
                        conrep.Ver = rdr["Ver"].ToString();
                        conrep.Descripcion = rdr["Descripcion"].ToString();
                        conrep.ST3 = rdr["ST3"].ToString();
                        conrep.ST1 = rdr["ST1"].ToString();
                        conrep.Glosa = rdr["Glosa"].ToString();
                        conrep.Promotor = rdr["Promotor"].ToString();
                        conrep.Supervisor = rdr["Supervisor"].ToString();
                        conrep.EstadoFinal = rdr["Estado_Final"].ToString();
                        conrep.RT95FACT = rdr["RT95FACT"].ToString();
                        conrep.Estado = rdr["Estado"].ToString();
                        conrep.F_Ini = rdr["F_Ini"].ToString();
                        conrep.Turno = rdr["Turno"].ToString();
                        conrep.Horas = Convert.ToInt32(rdr["Horas"].ToString());
                        conrep.EstadoEnvio = rdr["Estado de Envio"].ToString();
                        conrep.Comision = rdr["Comision"].ToString();

                        lstReporte.Add(conrep);
                    }

                    if (Data.TablaID == 7)
                    {
                        beReporte7 conrep = new beReporte7();
                        conrep.Supervisor = rdr["SUPERVISOR"].ToString();
                        conrep.Promotor = rdr["Promotor"].ToString();
                        conrep.FechaVenta = rdr["FECHA_VENTA"].ToString();
                        conrep.Mes = rdr["MES"].ToString();
                        conrep.Anio = rdr["AÑO"].ToString();
                        conrep.EstadoFinal = rdr["ESTADO_FINAL"].ToString();
                        conrep.Cliente = rdr["CLIENTE"].ToString();
                        conrep.DNI = rdr["DNI"].ToString();

                        lstReporte.Add(conrep);
                    }

                    if(Data.TablaID == 10)
                    {
                        beConsultaReporte conrep = new beConsultaReporte();
                        conrep.PeriodoOrd = rdr["PeriodoOrd"].ToString();
                        conrep.Periodo = rdr["Periodo"].ToString();
                        conrep.Mes = rdr["Mes"].ToString();
                        conrep.Anio = rdr["Año"].ToString();
                        conrep.VentaTotal = Convert.ToInt32(rdr["1.Venta Total"].ToString());
                        conrep.VentaValida = Convert.ToInt32(rdr["2.Venta Valida"].ToString());
                        conrep.VentaAprobada = Convert.ToInt32(rdr["3.Venta Aprobada"].ToString());
                        conrep.VentaActivada = Convert.ToInt32(rdr["4.Venta Activada"].ToString());
                        conrep.ActivadaMes = Convert.ToInt32(rdr["5.Activadas del Mes"].ToString());
                        conrep.ActivasMes0 = Convert.ToInt32(rdr["6.Activadas Mes0"].ToString());
                        conrep.ActivadasMes1 = Convert.ToInt32(rdr["7.Activadas Mes1"].ToString());
                        conrep.ActivadasMes2 = Convert.ToInt32(rdr["8.Activadas Mes2"].ToString());
                        conrep.Uso = Convert.ToInt32(rdr["9.Uso"].ToString());
                        conrep.TotalGeneral =   conrep.VentaTotal + conrep.VentaAprobada +
                                                conrep.VentaActivada + conrep.ActivadaMes;

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
                    if(Data.TablaID == 15)
                    {
                        beReporte15 conrep = new beReporte15();
                        conrep.ID = Convert.ToInt32(rdr["ID"].ToString());
                        conrep.DNI = rdr["DNI"].ToString();
                        conrep.ST3 = rdr["ST3"].ToString();
                        conrep.Cliente = rdr["CLIENTE"].ToString();
                        conrep.NroSol = rdr["NRSOL"].ToString();
                        conrep.FechaVenta = rdr["FECHAVENTA"].ToString();
                        conrep.Descripcion = rdr["DESCRIPCION"].ToString();
                        conrep.Promotor = rdr["PROMOTOR"].ToString();
                        conrep.Supervisor = rdr["SUPERVISOR"].ToString();
                        conrep.EstadoEnvio = rdr["ESTADO DE ENVIO"].ToString();
                        conrep.EstadoFinal = rdr["ESTADO_FINAL"].ToString();
                        conrep.RT95FACT = rdr["RT95FACT"].ToString();
                        conrep.F_Activacion = rdr["F_ACTIVACION"].ToString();
                        conrep.TC_ACT = rdr["TC_ACT"].ToString();

                        lstReporte.Add(conrep);
                    }
                    if (Data.TablaID == 16)
                    {
                        beReporte16 conrep = new beReporte16();
                        conrep.FechaVenta = rdr["FECHAVENTA"].ToString();
                        conrep.RT95FACT = rdr["RT95FACT"].ToString();
                        conrep.DNI = rdr["DNI"].ToString();
                        conrep.NroSol = rdr["NRSOL"].ToString();
                        conrep.Cliente = rdr["CLIENTE"].ToString();
                        conrep.Descripcion = rdr["DESCRIPCION"].ToString();

                        lstReporte.Add(conrep);
                    }
                    if (Data.TablaID == 19)
                    {
                        beReporte19 conrep = new beReporte19();
                        conrep.TipoZona = rdr["TIPO ZONA"].ToString();
                        conrep.Zona = rdr["ZONA"].ToString();
                        conrep.Departamento = rdr["DEPARTAMENTO"].ToString();
                        conrep.Activacion = rdr["ACTIVACION"].ToString();
                        conrep.EstadoAnalisis = rdr["ESTADO_ANALISIS"].ToString();
                        conrep.Estado = rdr["ESTADO"].ToString();
                        conrep.Plen = rdr["PLEN"].ToString();
                        conrep.EstadoGestion = rdr["ESTADO_GESTION"].ToString();
                        conrep.Anio_Mes_AP = rdr["AÑO_MES_AP"].ToString();
                        conrep.X_Grupo = rdr["X_GRUPO"].ToString();
                        conrep.DNI = rdr["DNI"].ToString();
                        conrep.NrSol = rdr["NRSOL"].ToString();
                        conrep.Cliente = rdr["CLIENTE"].ToString();
                        conrep.Gestor = rdr["GESTOR"].ToString();
                        conrep.FeedBack = rdr["FEEDBACK"].ToString();
                        conrep.Observacion = rdr["OBSERVACION"].ToString();
                        conrep.FechaGestion = rdr["FECHA DE GESTION"].ToString();
                        conrep.FEntrega = rdr["FENTREGA"].ToString();

                        lstReporte.Add(conrep);
                    }
                    if(Data.TablaID == 20)
                    {
                        beReporte20 conrep = new beReporte20();
                        conrep.Promotor = rdr["PROMOTOR"].ToString();
                        conrep.FechaVenta = rdr["FECHA_VENTA"].ToString();
                        conrep.Auditor = rdr["AUDITOR"].ToString();
                        conrep.EstadoFinal = rdr["ESTADO_FINAL"].ToString();
                        conrep.Cliente = rdr["CLIENTE"].ToString();
                        conrep.DNI = rdr["DNI"].ToString();

                        lstReporte.Add(conrep);

                    }
                    if (Data.TablaID == 21)
                    {
                        beReporte21 conrep = new beReporte21();
                        conrep.Promotor = rdr["PROMOTOR"].ToString();
                        conrep.FechaVenta = rdr["FECHA_VENTA"].ToString();
                        conrep.Auditor = rdr["AUDITOR"].ToString();
                        conrep.EstadoFinal = rdr["ESTADO_FINAL"].ToString();
                        conrep.DNI = rdr["DNI"].ToString();
                        conrep.FechaTabla = rdr["FECHATABLA"].ToString();
                        conrep.Dia = rdr["Dia"].ToString();

                        lstReporte.Add(conrep);

                    }
                    if (Data.TablaID == 22)
                    {
                        beReporte22 conrep = new beReporte22();
                        conrep.ID = Convert.ToInt32(rdr["Id"].ToString());
                        conrep.Fecha = rdr["Fecha"].ToString();
                        conrep.Cantidad = Convert.ToInt32(rdr["Cantidad"].ToString());
                        conrep.Tipo = rdr["Tipo"].ToString();
                        conrep.Acumulado = Convert.ToInt32(rdr["Acumulado"].ToString());
                        conrep.Promedio = Convert.ToInt32(rdr["Promedio"].ToString());
                        conrep.Dia = rdr["dia"].ToString();
                        conrep.Periodo = rdr["Periodo"].ToString();
                        conrep.PeriodoOrd = rdr["PeridoOrd"].ToString();

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

                    if (Data.TablaID == 29)
                    {
                        beReporte29 conrep = new beReporte29();
                        conrep.HORA = rdr["HORA"].ToString();
                        conrep.DIA = rdr["DIA"].ToString();
                        conrep.MES = rdr["MES"].ToString();
                        conrep.FECHA_LLAMADA = rdr["FECHA_LLAMADA"].ToString();
                        conrep.DNI = rdr["DNI"].ToString();
                        conrep.TELEFONO = rdr["TELEFONO"].ToString();
                        conrep.USERGO = rdr["USERGO"].ToString();
                        conrep.NOMBREGO = rdr["NOMBREGO"].ToString();
                        conrep.RESULTADO = rdr["RESULTADO"].ToString();
                        conrep.DURACION_SEG = rdr["DURACION_SEG"].ToString();

                        lstReporte.Add(conrep);
                    }
                    
                }
                con.Close();
            }
            return lstReporte;
        }

        //public DataTable MostrarTablaConsulta(beConsultaReportePrincipal Data)
        //{
        //    DataTable DataReporte = new DataTable();

        //    using (SqlConnection con = Conexion.ConexionSql)
        //    {
        //        SqlCommand cmd = new SqlCommand("WEB_SITE_Data_General", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        con.Open();
        //        cmd.Parameters.AddWithValue("@id", Data.TablaID);
        //        cmd.Parameters.AddWithValue("@Fecha_1", Data.FechaInicio);
        //        cmd.Parameters.AddWithValue("@Fecha_2", Data.FechaFin);
        //        SqlDataReader rdr = cmd.ExecuteReader();

        //        DataReporte.Load(rdr);
        //        con.Close();
        //    }
        //    return DataReporte;
        //}

        public List<beConsultaReporte> MostrarConsulta()
        {
            List<beConsultaReporte> lstConsulta = new List<beConsultaReporte>();

            using (SqlConnection con = Conexion.ConexionSql)
            {
                SqlCommand cmd = new SqlCommand("WEB_SITE_Data_Prueba_10", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    beConsultaReporte conrep = new beConsultaReporte();

                    conrep.PeriodoOrd = rdr["PeriodoOrd"].ToString();
                    conrep.Periodo = rdr["Periodo"].ToString();
                    conrep.VentaTotal = Convert.ToInt32(rdr["1.Venta Total"].ToString());
                    conrep.VentaAprobada = Convert.ToInt32(rdr["3.Venta Aprobada"].ToString());
                    conrep.VentaActivada = Convert.ToInt32(rdr["4.Venta Activada"].ToString());
                    conrep.ActivadaMes = Convert.ToInt32(rdr["5.Activadas del Mes"].ToString());

                    lstConsulta.Add(conrep);
                }
                con.Close();
            }
            return lstConsulta;
        }
    }
}
