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
    public class daModelResumen
    {
        /*Conexiones para la muestra del Reporte Resumen Evolutivo*/
        #region Resumen Evolutivo

        public List<beResumenEvolutivo> EvolutionarySummary(beConsultaReportePrincipal Data)
        {
            List<beResumenEvolutivo> lstReporte = new List<beResumenEvolutivo>();
            string tsql = Resumen_Evolutivo(Data);

            using (SqlConnection con = Conexion.ConexionSql)
            {
                SqlCommand cmd = new SqlCommand(tsql, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    beResumenEvolutivo conrep = new beResumenEvolutivo();
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
                    conrep.TotalGeneral = conrep.VentaTotal + conrep.VentaAprobada +
                                            conrep.VentaActivada + conrep.ActivadaMes;

                    lstReporte.Add(conrep);
                }
                con.Close();
            }
            return lstReporte;
        }

        #endregion

        /*Conexiones para la muestra del Reporte Resumen Mes*/
        #region Resumen Mes

        public List<beResumenMes> First_SummaryMonth(beConsultaReportePrincipal Data)
        {
            List<beResumenMes> FirstList = new List<beResumenMes>();
            string tsql = First_Resumen_Mes(Data);

            using (SqlConnection con = Conexion.ConexionSql)
            {
                SqlCommand cmd = new SqlCommand(tsql, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    beResumenMes conrep = new beResumenMes();
                    conrep.Dia = rdr["Dia"].ToString();
                    conrep.VentaTotal = Convert.ToInt32(rdr["VentaTotal"].ToString());
                    conrep.VentaValida = Convert.ToInt32(rdr["VentaValida"].ToString());
                    conrep.VentaAprobada = Convert.ToInt32(rdr["VentaAprobada"].ToString());
                    conrep.Venta = Convert.ToDouble(rdr["% Venta"].ToString());
                    conrep.Validado = Convert.ToDouble(rdr["% Valido"].ToString());
                    conrep.Aprobado = Convert.ToDouble(rdr["% Aprobado"].ToString());

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
                    else
                    {
                        conrep.PassingAprobado = 0;
                    }

                    FirstList.Add(conrep);
                }
                con.Close();
            }
            
            return FirstList;
        }

        public List<beResumenMes> Second_SummaryMonth(beConsultaReportePrincipal Data)
        {
            List<beResumenMes> SecondMonth = new List<beResumenMes>();
            string tsql = Second_Resumen_Mes(Data);

            using (SqlConnection con = Conexion.ConexionSql)
            {
                SqlCommand cmd = new SqlCommand(tsql, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    beResumenMes conrep = new beResumenMes();
                    conrep.Promotor = rdr["Promotor"].ToString();
                    conrep.Supervisor = rdr["Supervisor"].ToString();
                    conrep.VentaTotal = Convert.ToInt32(rdr["VentaTotal"].ToString());
                    conrep.VentaValida = Convert.ToInt32(rdr["VentaValida"].ToString());
                    conrep.VentaAprobada = Convert.ToInt32(rdr["VentaAprobada"].ToString());
                    conrep.Venta = Convert.ToDouble(rdr["% Venta"].ToString());
                    conrep.Validado = Convert.ToDouble(rdr["% Valido"].ToString());
                    conrep.Aprobado = Convert.ToDouble(rdr["% Aprobado"].ToString());

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
                    else
                    {
                        conrep.PassingAprobado = 0;
                    }

                    SecondMonth.Add(conrep);
                }
                con.Close();
            }
            return SecondMonth;
        }

        #endregion

        /*String de consulta Resumen Evolutivo*/
        #region Consulta Resumen Evolutivo

        static string Resumen_Evolutivo(beConsultaReportePrincipal Data)
        {
            return @"
                Declare @Fecha1 date
                set @Fecha1 = '" + Data.FechaInicio + @"'

                Declare @Fecha2 date
                set @Fecha2 = '" + Data.FechaFin + @"'  

                    Declare @Table TABLE(
	                    Periodo varchar(20),
	                    PeriodoOrd varchar(10),
	                    Mes varchar(10),
	                    Año varchar(50),
	                    TipoVenta varchar(50),
	                    Cantidad int
                    )

                    INSERT @Table exec WEB_SITE_Data_General 10, @Fecha1, @Fecha2

	                select
	                PeriodoOrd
	                ,Periodo
	                ,Mes
	                ,Año
	                ,ISNULL([1.Venta Total], 0) AS [1.Venta Total]
	                ,ISNULL([2.Venta Valida], 0) AS [2.Venta Valida]
	                ,ISNULL([3.Venta Aprobada], 0) AS [3.Venta Aprobada]
	                ,ISNULL([4.Venta Activada], 0) AS [4.Venta Activada]
	                ,ISNULL([5.Activadas del Mes], 0) AS [5.Activadas del Mes]
	                ,ISNULL([6.Activadas Mes0], 0) AS [6.Activadas Mes0]
	                ,ISNULL([7.Activadas Mes1], 0) AS [7.Activadas Mes1]
	                ,ISNULL([8.Activadas Mes2], 0) AS [8.Activadas Mes2]
	                ,ISNULL([9.Uso], 0) AS [9.Uso]
	                from (SELECT * FROM @Table) p
	                PIVOT  
	                (  
		                SUM (Cantidad)  
		                FOR TipoVenta IN  
		                ( [1.Venta Total], [2.Venta Valida], [3.Venta Aprobada], [4.Venta Activada] ,[5.Activadas del Mes],
		                  [6.Activadas Mes0], [7.Activadas Mes1], [8.Activadas Mes2], [9.Uso] )  
	                ) AS pvt  
	                order by pvt.PeriodoOrd
            ";
        }

        #endregion

        /*Strings de consultas Resumen Mes*/
        #region Consulta Resumen Mes

        static string First_Resumen_Mes(beConsultaReportePrincipal Data)
        {
            return @"
                Declare @Fecha1 date
                set @Fecha1 = '" + Data.FechaInicio + @"'

                Declare @Fecha2 date
                set @Fecha2 = '" + Data.FechaFin + @"'  

                DECLARE @Table1 table(
	                Promotor varchar(100),
	                Supervisor varchar(100),
	                VentaTotal decimal(10,0),
	                VentaValida decimal(10,0),
	                VentaAprobada decimal(10,0),
	                Dia char(5)
                )

                INSERT @Table1 exec WEB_SITE_data_general 11, @Fecha1, @Fecha2

		        SELECT
		        Dia
		        ,SUM(VentaTotal) AS VentaTotal
		        ,SUM(VentaValida) AS VentaValida
		        ,SUM(VentaAprobada) AS VentaAprobada
		        ,CAST(SUM(VentaTotal) / (SELECT SUM(VentaTotal) FROM @Table5) * 100 AS DECIMAL(10,2)) AS '% Venta'
		        ,CAST(SUM(VentaValida) / (SELECT SUM(VentaValida) FROM @Table5) * 100 AS DECIMAL(10,2)) AS '% Valido'
		        ,CAST(SUM(VentaAprobada) / (SELECT SUM(VentaAprobada) FROM @Table5) * 100 AS DECIMAL(10,2)) AS '% Aprobado'
		        FROM @Table5
		        GROUP BY DIA
            ";
        }

        static string Second_Resumen_Mes(beConsultaReportePrincipal Data)
        {
            return @"
                Declare @Fecha1 date
                set @Fecha1 = '" + Data.FechaInicio + @"'

                Declare @Fecha2 date
                set @Fecha2 = '" + Data.FechaFin + @"'  

                DECLARE @Table2 table(
	                Promotor varchar(100),
	                Supervisor varchar(100),
	                VentaTotal decimal(10,0),
	                VentaValida decimal(10,0),
	                VentaAprobada decimal(10,0),
	                Dia char(5)
                )

                INSERT @Table2 exec WEB_SITE_data_general 11, @Fecha1, @Fecha2

		        SELECT
		        Promotor
		        ,Supervisor
		        ,SUM(VentaTotal) AS VentaTotal
		        ,SUM(VentaValida) AS VentaValida
		        ,SUM(VentaAprobada) AS VentaAprobada
		        ,CAST(SUM(VentaTotal) / (SELECT SUM(VentaTotal) FROM @Table5) * 100 AS DECIMAL(10,2)) AS '% Venta'
		        ,CAST(SUM(VentaValida) / (SELECT SUM(VentaValida) FROM @Table5) * 100 AS DECIMAL(10,2)) AS '% Valido'
		        ,CAST(SUM(VentaAprobada) / (SELECT SUM(VentaAprobada) FROM @Table5) * 100 AS DECIMAL(10,2)) AS '% Aprobado'
		        FROM @Table5
		        GROUP BY Supervisor, Promotor
		        ORDER BY Supervisor
            ";
        }

        #endregion
    }
}
