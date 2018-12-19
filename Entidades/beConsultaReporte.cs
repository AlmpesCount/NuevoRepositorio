using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class beConsultaReportePrincipal
    {
        public int TablaID { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime FechaFin { get; set; }
    }

    public class beConsultaReporte
    {
        public string Periodo { get; set; }
        public string PeriodoOrd { get; set; }
        public string Mes { get; set; }
        public int MesID { get; set; }
        public string Anio { get; set; }
        public int AnioID { get; set; }
        public string TipoVenta { get; set; }
        public int Cantidad { get; set; }
    }

    public class beReporte29
    {
        public string HORA { get; set; }
        public string DIA { get; set; }
        public string MES { get; set; }
        public string FECHA_LLAMADA { get; set; }
        public string DNI { get; set; }
        public string TELEFONO { get; set; }
        public string USERGO { get; set; }
        public string NOMBREGO { get; set; }
        public string RESULTADO { get; set; }
        public int DURACION_SEG { get; set; }
    }

    public class beReporte28
    {
        public string DNI { get; set; }
        public string CLIENTE { get; set; }
        public string PROMOTOR { get; set; }
        public string FECHA_VENTA { get; set; }
        public string FECHA_ACTU_BO { get; set; }
        public string ESTADO_BO { get; set; }
        public string COMENTARIO { get; set; }
        public string AUDITOR { get; set; }
        public string SUPERVISOR { get; set; }
    }

    public class beReporte27
    {
        public string Periodo { get; set; }
        public string N_Doc { get; set; }
        public string Telefono { get; set; }
        public string F_Recep { get; set; }
        public string F_Gestion { get; set; }
        public string TipoCel { get; set; }
        public string GrupoCel { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }

    }

    public class beReporte1 {
        public string Zona { get; set; }
        public string Semana { get; set; }
        public string DiaSemana { get; set; }
        public string Fecha { get; set; }
        public string NroVenta { get; set;}
        public string NroVeValida { get; set; }
        public string Dotacion { get; set; }
        public string RecorridoDia { get; set; }
        public string ContactoEfectivoTitular { get; set; }
        public string ContactoTerceroRelacionado { get; set; }
        public string RecorridoReal { get; set; }
        public string CETReal { get; set; }
        public string BBDDAsignada { get; set; }
        public string RecorridoDiaTiempo { get; set; }
        public string CETTiempo { get; set; }
        public string CTRTiempo { get; set; }
        public string VentasTiempo { get; set; }
        public string RecorridoUnico { get; set; }
        public string CETUnico { get; set; }
        public string Indecopi { get; set; }
        public string RetiroLeads { get; set; }
    }

    public class beReporte2
    {
        public string FRecep { get; set; }

        public string Zona { get; set; }

        public int NroVenta { get; set; }

        public int NroVenValida { get; set; }

        public int BBDD { get; set; }

        public int RecorridoReal { get; set; }

        public int CETReal { get; set; }

        public int Recorrido { get; set; }

        public int CET { get; set; }

        public int Indecopi { get; set; }

        public int RetiroLead { get; set; }
    }

    public class beReporte9
    {
        public string Periodo { get; set; }
        public string Resultado { get; set; }
        public int Cuenta { get; set; }
        public int año { get; set; }
        public int mes { get; set; }
    }

    public class beReporte11 {
        public string Promotor { get; set; }
        public string Supervisor { get; set; }
        public int VentaTotal  {get; set;}
        public int VentaValida { get; set; }
        public int VentaAprobada { get; set; }
        public int Dia { get; set; }
    }

    public class beReporte12 {
        public int ID { get; set; }
        public int DIA { get; set; }
        public string N_Doc { get; set; }
        public string FECHA_VENTA { get; set; }
        public string SUPERVISOR { get; set; }
        public string N_Solicitud { get; set; }
        public string Fecha_Ing { get; set; }
        public string Cod_Promt { get; set; }
        public string Apell_Cliente1 { get; set; }
        public string Descripcion { get; set; }
        public string ST3 { get; set; }
        public string ST1 { get; set; }
        public string Glosa { get; set; }
        public string RT95FACT { get; set; }
        public string Mes { get; set; }

    }

    public class beReporte13 {
        public string FVenta { get; set; }
        public string DNI { get; set; }
        public string Estado_BO { get; set; }
        public string FAprobado { get; set; }
        public string NroSol { get; set; }
        public string FActivado { get; set; }
        public string ActAcum3 { get; set; }
        public int ActAcum2 { get; set; }
        public int Act1 { get; set; }
        public int Act2 { get; set; }
        public int Act3 { get; set; }
        public int CVenta { get; set; }
        public int CAprobado { get; set; }
        public int CActivado { get; set; }
    }
}
