using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapNegocio;

namespace capPresentacion
{
    public partial class Form1 : Form
    {
        private CN_Producto cn_producto = new CN_Producto();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarProductos();
        }

        private void mostrarProductos()
        {
            CN_Producto producto = new CN_Producto();
            ventada.DataSource = producto.Mostrar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try {
                cn_producto.insertarProduc(txtnombre.Text, txtdescripcion.Text, txtmarca.Text, txtprecio.Text, txtstock.Text);
                MessageBox.Show("Se inserto correctamente");
                mostrarProductos();
            } catch(Exception ex) {
                MessageBox.Show("Hubo un error por: "+ex);
            }
        }
    }
}
