using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapDatos
{
    public class CD_Productos
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM Productos;";
            leer = comando.ExecuteReader();
            table.Load(leer);
            conexion.CerrarConexion();
            return table;
        }

    }
}
