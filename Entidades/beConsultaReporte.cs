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
        [DisplayName("Fecha de Inicio:")]
        public DateTime FechaInicio { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [DisplayName("Fecha Final:")]
        public DateTime FechaFin { get; set; }
    }

    public class beReporte27
    {
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public int Almpes1 { get; set; }
        public int Almpes2 { get; set; }
        public int AlmpesCet { get; set; }
        public int AlmpesW1 { get; set; }
        public int AlmpesNA { get; set; }
        public int AlmpesTotal { get; set; }
        public int Crediscotia1 { get; set; }
        public int Crediscotia2 { get; set; }
        public int Crediscotia3 { get; set; }
        public int Crediscotia4 { get; set; }
        public int Crediscotia5 { get; set; }
        public int CrediscotiaTotal { get; set; }
        public int TotalGeneral { get; set; }

    }

    public class beReporte1 {
        public string Zona { get; set; }
        public string Semana { get; set; }
        public string DiaSemana { get; set; }
        public string Fecha { get; set; }
        public int NroVenta { get; set;}
        public int NroVeValida { get; set; }
        public int Dotacion { get; set; }
        public int RecorridoDia { get; set; }
        public int ContactoEfectivoTitular { get; set; }
        public int RecorridoReal { get; set; }
        public int CETReal { get; set; }
        public double NroVueltas { get; set; }
        public double VentasTMO { get; set; }
        public double CETTMO { get; set; }
        public double PorcCETReal { get; set; }
        public double PorcAcepReal { get; set; }
        public double AcepReal { get; set; }
        public double CETTiempo { get; set; }
        public double VentasTiempo { get; set; }
        public int RecorridoUnico { get; set; }
        public int CETUnico { get; set; }
        public double RecorridoAcumulado { get; set; }
        public double CETAcumulado { get; set; }
        public int BBDDAsignada { get; set; }
        public int Indecopi { get; set; }
        public int RetiroLeads { get; set; }
        public double BBDDAcumulado { get; set; }
        public double AvancePorcBBDD { get; set; }
        public double RecorridoDiaTiempo { get; set; }
        public double CTRTiempo { get; set; }
        public int ContactoTerceroRelacionado { get; set; } 
    }

    public class beReporte2
    {
        public string Zona { get; set; }
        public string FRecep { get; set; }
        public int NroVenta { get; set; }
        public int NroVenValida { get; set; }
        public int BBDD { get; set; }
        public int Indecopi { get; set; }
        public int RetiroLead { get; set; }
        public int RecorridoReal { get; set; }
        public int CETReal { get; set; }
        public double NroVuelta { get; set; }
        public double PorcCET { get; set; }
        public double PorcAceptacion { get; set; }
        public double AvancePorc { get; set; }
        public double PorcEfectividad { get; set; }
        public int Recorrido { get; set; }
        public int CET { get; set; }
        public double CETVueltas { get; set; }
    }

    public class beReporte5
    {
        public string TipoMes { get; set; }
        public string EstadoVer { get; set; }
        public int Mes { get; set; }
        public string DNI { get; set; }
        public string Cliente { get; set; }
        public string NroSolicitud { get; set; }
        public string FechaVenta { get; set; }
        public string Ver { get; set; }
        public string Descripcion { get; set; }
        public string ST3 { get; set; }
        public string ST1 { get; set; }
        public string Glosa { get; set; }
        public string Promotor { get; set; }
        public string Supervisor { get; set; }
        public string EstadoFinal { get; set; }
        public string RT95FACT { get; set; }
        public string Estado { get; set; }
        public string F_Ini { get; set; }
        public string Turno { get; set; }
        public int Horas { get; set; }
        public string EstadoEnvio { get; set; }
        public string Comision { get; set; }
    }

    public class beReporte7
    {
        public string Supervisor { get; set; }
        public string Promotor { get; set; }
        public string FechaVenta { get; set; }
        public string Mes { get; set; }
        public string Anio { get; set; }
        public string EstadoFinal { get; set; }
        public string Cliente { get; set; }
        public string DNI { get; set; }
    }

    public class beReporte8
    {
        public string Periodo { get; set; }
        public string Fecha { get; set; }
        public string DiaSemana { get; set; }
        public int Crediscotia1 { get; set; }
        public int Crediscotia2 { get; set; }
        public int Crediscotia3 { get; set; }
        public int Crediscotia4 { get; set; }
        public int Almpes1 { get; set; }
        public int Almpes2 { get; set; }
        public int AlmpesCET { get; set; }
        public int AlmpesNA { get; set; }
        public int TotalGeneral { get; set; }

    }

    public class beReporte9
    {
        public string Periodo { get; set; }
        public string Anio { get; set; }
        public int Column0 { get; set; }
        public int Column1 { get; set; }
        public int Column2 { get; set; }
        public int Column3 { get; set; }
        public int Column4 { get; set; }
        public int Column5 { get; set; }
        public int Column6 { get; set; }
        public int Column7 { get; set; }
        public int Column8 { get; set; }
        public int Column9 { get; set; }
        public int Column11 { get; set; }
        public int Column12 { get; set; }
        public int Column13 { get; set; }
 
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

    public class beReporte15 {
        public int ID { get; set; }
        public string DNI { get; set; }
        public string ST3 { get; set; }
        public string Cliente { get; set; }
        public string NroSol { get; set; }
        public string FechaVenta { get; set; }
        public string Descripcion { get; set; }
        public string Promotor { get; set; }
        public string Supervisor { get; set; }
        public string EstadoEnvio { get; set; }
        public string EstadoFinal { get; set; }
        public string RT95FACT { get; set; }
        public string F_Activacion { get; set; }
        public string TC_ACT { get; set; }
    }

    public class beReporte16
    {
        public string FechaVenta { get; set; }
        public string RT95FACT { get; set; }
        public string DNI { get; set; }
        public string NroSol { get; set; }
        public string Cliente { get; set; }
        public string Descripcion { get; set; }
    }

    public class beReporte19
    {
        public string TipoZona { get; set; }
        public string Zona { get; set; }
        public string Departamento { get; set; }
        public string Activacion { get; set; }
        public string EstadoAnalisis { get; set; }
        public string Estado { get; set; }
        public string Plen { get; set; }
        public string EstadoGestion { get; set; }
        public string Anio_Mes_AP { get; set; }
        public string X_Grupo { get; set; }
        public string DNI { get; set; }
        public string NrSol { get; set; }
        public string Cliente { get; set; }
        public string Gestor { get; set; }
        public string FeedBack { get; set; }
        public string Observacion { get; set; }
        public string FechaGestion { get; set; }
        public string FEntrega { get; set; }
    }

    public class beReporte20
    {
        public string Promotor { get; set; }
        public string FechaVenta { get; set; }
        public string Auditor { get; set; }
        public string EstadoFinal {get;set;}
        public string Cliente { get; set; }
        public string DNI { get; set; }
    }

    public class beReporte21
    {
        public string Promotor { get; set; }
        public string FechaVenta { get; set; }
        public string Auditor { get; set; }
        public string EstadoFinal { get; set; }
        public string DNI { get; set; }
        public string FechaTabla { get; set; }
        public string Dia { get; set; }

    }

    public class beReporte22
    {
        public int ID { get; set; }
        public string Fecha { get; set; }
        public int Cantidad { get; set; }
        public string Tipo { get; set; }
        public int Acumulado { get; set; }
        public int Promedio { get; set; }
        public string Dia { get; set; }
        public string Periodo { get; set; }
        public string PeriodoOrd { get; set; }
    }

    public class beReporte25
    {
        public string Periodo { get; set; }
        public string F_Recep { get; set; }
        public int NroVenta { get; set; }
        public int NroVenValida { get; set; }
        public int LlamadasTotal { get; set; }
        public int CETTiempo { get; set; }
        public double NroVueltas { get; set; }
        public double OKAlmpes { get; set; }
        public int LlamadasUnico { get; set; }
        public int CETUnico { get; set; }
        public int BBDDAcumulado { get; set; }
        public int RetiroLeads { get; set; }
        public int BBDDTotal { get; set; }
        public double AvanceBBDD { get; set; }
        public double PorcBBDD { get; set; }
        public double AvanceCET { get; set; }
        public double AceptacionPorc { get; set; }
        public int VentasTiempo { get; set; }
        public double VentasTMO { get; set; }
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
        public string DURACION_SEG { get; set; }
    }
}
