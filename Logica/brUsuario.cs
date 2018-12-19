using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Conexion;

namespace Logica
{
    public class brUsuario
    {
        private daUsuario usuarioDAL = new daUsuario();

        public List<beUsuario> MostrarUsuarios()
        {
            return usuarioDAL.MostrarUsuarios();
        }

        public List<beUsuario> ObtenerCodigo(beUsuario cod)
        {
            return usuarioDAL.ObtenerCodigo(cod);
        }
    }
}
