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

        public void insertarProduc(string nombre, string desc, string marca, string precio, string stock) {
            productoCD.insertar(nombre, desc, marca, Convert.ToDouble(precio),Convert.ToInt32(stock));
        }

        public void editarProduc(string nombre, string desc, string marca, string precio, string stock,string id)
        {
            productoCD.editar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(id));
        }
    }
}
