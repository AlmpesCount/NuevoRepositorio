using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Conexion;

namespace Logica
{
    public class brLogin
    {
        public List<beLogin> DatosLogeo(beLogin usuario)
        {
            daLogin login = new daLogin();
            var user = login.DatosLogeo(usuario);
            return user;
        }

        public List<beUserCRM> LoginUserCRM(beUserCRM user)
        {
            daLogin login = new daLogin();
            var userCRM = login.LoginUserCRM(user);
            return userCRM;
        }
    }
}
