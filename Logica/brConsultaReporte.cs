using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Conexion;

namespace Logica
{
    public class brConsultaReporte
    {
        private daConsultaReporte reporteDAL = new daConsultaReporte();

        public List<Object> TotalTabla(beConsultaReportePrincipal Data)
        {
            daConsultaReporte reporte = new daConsultaReporte();
            var lista = reporte.TotalTabla(Data);
            return lista;
        }

        public List<beConsultaReporte> MostrarConsulta()
        {
            daConsultaReporte reporte = new daConsultaReporte();
            var lista = reporte.MostrarConsulta();
            return lista;
        }

        /*public DataTable MostrarTablaConsulta(beConsultaReportePrincipal Data)
        {
            DataTable DataReporte = new DataTable();
            DataReporte = reporteDAL.MostrarTablaConsulta(Data);

            return DataReporte;
        }*/
    }
}
