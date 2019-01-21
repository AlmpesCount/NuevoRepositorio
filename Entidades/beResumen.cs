using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class beResumenEvolutivo
    {
        public string PeriodoOrd { get; set; }
        public string Periodo { get; set; }
        public string Mes { get; set; }
        public string Anio { get; set; }
        public int VentaTotal { get; set; }
        public int VentaValida { get; set; }
        public int VentaAprobada { get; set; }
        public int VentaActivada { get; set; }
        public int ActivadaMes { get; set; }
        public int ActivasMes0 { get; set; }
        public int ActivadasMes1 { get; set; }
        public int ActivadasMes2 { get; set; }
        public int Uso { get; set; }
        public int TotalGeneral { get; set; }
    }

    public class beResumenMes
    {
        public string Promotor { get; set; }
        public string Supervisor { get; set; }
        public int VentaTotal { get; set; }
        public int VentaValida { get; set; }
        public int VentaAprobada { get; set; }
        public string Dia { get; set; }
        public double PassingValido { get; set; }
        public double PassingAprobado { get; set; }
        public double Venta { get; set; }
        public double Validado { get; set; }
        public double Aprobado { get; set; }
    }
}
