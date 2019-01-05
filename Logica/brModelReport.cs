using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexion;
using Entidades;

namespace Logica
{
    public class brModelReport
    {
        daModelReport dlReport = new daModelReport();
        public List<beReporte8> First_ModelDBPhone(beConsultaReportePrincipal Data)
        {
            var List1 = dlReport.First_ModelDBPhone(Data);
            return List1;
        }

        public List<beReporte8> Second_ModelDBPhone(beConsultaReportePrincipal Data)
        {
            var List2 = dlReport.Second_ModelDBPhone(Data);
            return List2;
        }

        public List<beReporte27> Third_ModelDBPhone(beConsultaReportePrincipal Data)
        {
            var List3 = dlReport.Third_ModelDBPhone(Data);
            return List3;
        }

        public List<beReporte9> ModelDBCET(beConsultaReportePrincipal Data)
        {
            var ListCET = dlReport.ModelDBCET(Data);
            return ListCET;
        }

        public List<beReporte1> First_ModelDBDay(beConsultaReportePrincipal Data)
        {
            var DayFirst = dlReport.First_ModelDBDay(Data);
            return DayFirst;
        }

        public List<beReporte2> Second_ModelDBDay(beConsultaReportePrincipal Data)
        {
            var DaySecond = dlReport.Second_ModelDBDay(Data);
            return DaySecond;
        }

        public List<beReporte25> Third_ModelDBDay(beConsultaReportePrincipal Data)
        {
            var DayThird = dlReport.Third_ModelDBDay(Data);
            return DayThird;
        }
    }
}
