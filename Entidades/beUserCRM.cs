using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class beUserCRM
    {
        [DisplayName("Nombre de Usuario")]
        [Required(@ErrorMessage = "Este campo es obligatorio")]
        public string USUARIO { get; set; }

        [DisplayName("Cargo")]
        [DataType(DataType.Password)]
        [Required(@ErrorMessage = "Este campo es obligatorio")]
        public string CARGO { get; set; }
    }
}
