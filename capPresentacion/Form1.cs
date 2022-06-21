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
        private string idProduct = null;
        private bool editarState = false;
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

        private void reiniciarCampos()
        {
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            txtmarca.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(editarState == false)
            {
                try
                {
                    cn_producto.insertarProduc(txtnombre.Text, txtdescripcion.Text, txtmarca.Text, txtprecio.Text, txtstock.Text);
                    MessageBox.Show("Se inserto correctamente");
                    mostrarProductos();
                    reiniciarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error por: " + ex);
                }
            }

            if (editarState == true)
            {
                try {
                    cn_producto.editarProduc(txtnombre.Text, txtdescripcion.Text, txtmarca.Text, txtprecio.Text, txtstock.Text,idProduct);
                    MessageBox.Show("Se edito correctamente");
                    mostrarProductos();
                    reiniciarCampos();
                    editarState = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No se pudo editar por: " + ex);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(ventada.SelectedRows.Count > 0)
            {
                editarState = true;
                txtnombre.Text = ventada.CurrentRow.Cells["Nombre"].Value.ToString();
                txtdescripcion.Text = ventada.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtmarca.Text = ventada.CurrentRow.Cells["Marca"].Value.ToString();
                txtprecio.Text = ventada.CurrentRow.Cells["Precio"].Value.ToString();
                txtstock.Text = ventada.CurrentRow.Cells["Stock"].Value.ToString();
                idProduct = ventada.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecciona la fila a editar");
            }
        }
    }
}
