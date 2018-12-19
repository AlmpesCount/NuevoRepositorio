using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Conexion;

namespace Logica
{
    public class brEquipo
    {
        private daEquipo equipoDAL = new daEquipo();

        public List<beEquipo> MostrarEquipo()
        {
            return equipoDAL.MostrarEquipos();
        }

        public bool InsertarPC(beEquipo invPC)
        {
            bool result = false;
            try
            {
                daEquipo objPC = new daEquipo();
                result = objPC.InsertarPC(invPC);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public bool ActualizarPC(beEquipo invPC)
        {
            bool result = false;
            try
            {
                daEquipo objPC = new daEquipo();
                result = objPC.ActualizarPC(invPC);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public void EliminarPC(string codigo)
        {
            daEquipo daPc = new daEquipo();
            daPc.EliminarPC(codigo);
        }
    }
}
