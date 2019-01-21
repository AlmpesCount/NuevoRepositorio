using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Conexion;

namespace Logica
{
    public class brModelResumen
    {
        daModelResumen dlReport = new daModelResumen();

        /*Logica de Negocio para la muestra del Reporte Resumen Evolutivo*/
        #region Resumen Evolutivo

        public List<beResumenEvolutivo> EvolutionarySummary(beConsultaReportePrincipal Data)
        {
            var ListReport = dlReport.EvolutionarySummary(Data);
            return ListReport;
        }

        #endregion

        /*Logica de Negocio para la muestra del Reporte Resumen Mes*/
        #region Resumen Mes

        public List<beResumenMes> First_SummaryMonth(beConsultaReportePrincipal Data)
        {
            var FirstMonth = dlReport.First_SummaryMonth(Data);
            return FirstMonth;
        }

        public List<beResumenMes> Second_SummaryMonth(beConsultaReportePrincipal Data)
        {
            var SecondMonth = dlReport.Second_SummaryMonth(Data);
            return SecondMonth;
        }

        #endregion
    }
}
