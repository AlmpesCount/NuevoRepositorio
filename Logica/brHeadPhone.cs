using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Conexion;
using System.Data;


namespace Logica
{
    public class brHeadPhone
    {
        private daHeadPhone headDAL = new daHeadPhone();

        //public List<beHeadPhone> MostrarHeadPhone()
        //{
        //    return headDAL.MostrarHeadPhone();
        //}

        public DataTable CargarHead()
        {
            DataTable dtHead = new DataTable();
            dtHead = headDAL.CargarHeadphone();

            return dtHead;
        }
    }
}
