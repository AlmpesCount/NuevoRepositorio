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
            var List4 = dlReport.ModelDBCET(Data);
            return List4;
        }

        public List<beReporte2> Second_ModelDBDay(beConsultaReportePrincipal Data)
        {
            var List5 = dlReport.Second_ModelDBDay(Data);
            return List5;
        }
    }
}
