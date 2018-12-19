using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class beHeadPhone
    {
        public int ID_UNICO { get; set; }
        public string COD_HEAD { get; set; }
        public string ESTADO { get; set; }
        public string ASIGNADO { get; set; }
        public string COD_USU_CAB { get; set; }
        public DateTime FECHA_ENTREGA { get; set; }
        public string OBSERVACION { get; set; }
        public DateTime FECHA_DEVOLUCION { get; set; }
        public string DETALLE { get; set; }       
    }
}
