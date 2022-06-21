using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapDatos;

namespace CapNegocio
{
    public class CN_Producto
    {
        private CD_Productos productoCD = new CD_Productos();

        public DataTable Mostrar()
        {
            DataTable data = new DataTable();
            data = productoCD.Mostrar();
            return data;
        }
    }
}
