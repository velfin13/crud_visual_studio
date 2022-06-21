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

        /* 
         *  Mostart productos con sql 
         * 
           public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT * FROM Productos;";
            leer = comando.ExecuteReader();
            table.Load(leer);
            conexion.CerrarConexion();
            return table;
        }
        */

        /*
         *  Mostrar productos con procedimiento almacenado
         */

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            table.Load(leer);
            conexion.CerrarConexion();
            return table;
        }


        /* 
         *  ingresar productos con sql 
         * 
            public void insertar(string nombre,string desc,string marca,double precio ,int stock) {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "INSERT INTO Productos VALUES ('"+nombre+"','"+desc+"','"+marca+"',"+precio+","+stock+");";
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
                conexion.CerrarConexion();

            }
        */

        /* 
         *  ingresar productos con procedimiento almacenado 
         */
        public void insertar(string nombre,string desc,string marca,double precio ,int stock) {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
            comando.Parameters.Clear();
        }


        public void editar(string nombre, string desc, string marca, double precio, int stock,int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
            comando.Parameters.Clear();
        }

    }
}
