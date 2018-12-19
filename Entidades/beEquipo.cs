using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class beEquipo
    {
        public string COD_UNI_CAB { get; set; }
        public string SIS_OPERATIVO { get; set; }
        public string MEMORIA_RAM { get; set; }
        public string PROCESADOR { get; set; }
        public string DIRECCION_IP { get; set; }
        public string PUERTO_USB { get; set; }
        public DateTime FECHA_COMPRA { get; set; }
        public DateTime FECHA_REVISION { get; set; }
        public string AREA { get; set; }
        public string ESTADO { get; set; }
        public string MODIFICACIONES { get; set; }
    }
}
