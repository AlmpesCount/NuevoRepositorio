using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class beLogin
    {
        public int UserID { get; set; }
        [DisplayName("Nombre de Usuario")]
        [Required(@ErrorMessage = "Este campo es obligatorio")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(@ErrorMessage = "Este campo es obligatorio")]
        public string Password { get; set; }
        public string LoginError { get; set; }
        public string Nombres { get; set; }
        public string Ape_Paterno { get; set; }
        public string Ape_Materno { get; set; }
        public string DNI { get; set; }
        public string PERFIL { get; set; }
    }
}
