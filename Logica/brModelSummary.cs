using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Conexion;

namespace Logica
{
    public class brModelSummary
    {
        daModelSummary dlReport = new daModelSummary();
        public List<beReporte11> First_SummaryMonth(beConsultaReportePrincipal Data)
        {
            var FirstMonth = dlReport.First_SummaryMonth(Data);
            return FirstMonth;
        }

        public List<beReporte11> Second_SummaryMonth(beConsultaReportePrincipal Data)
        {
            var SecondMonth = dlReport.Second_SummaryMonth(Data);
            return SecondMonth;
        }
    }
}
