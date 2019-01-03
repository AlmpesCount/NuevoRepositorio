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
        daConsultaReporte reporte = new daConsultaReporte();
        daModelReport model = new daModelReport();

        public List<Object> TotalTabla(beConsultaReportePrincipal Data)
        {
            var lista = reporte.TotalTabla(Data);
            return lista;
        }

        public List<beConsultaReporte> MostrarConsulta()
        {
            var lista = reporte.MostrarConsulta();
            return lista;
        }

        //public DataTable MostrarTablaConsulta(beConsultaReportePrincipal Data)
        //{
        //    DataTable DataReporte = new DataTable();
        //    DataReporte = reporte.MostrarTablaConsulta(Data);

        //    return DataReporte;
        //}
    }
}
