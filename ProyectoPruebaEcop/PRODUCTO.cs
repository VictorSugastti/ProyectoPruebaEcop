using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPruebaEcop
{
    public partial class PRODUCTO : Form
    {
        public PRODUCTO()
        {
            InitializeComponent();
        }

        private void txtpreciopro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtcantidadpro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btnguardarpro_Click(object sender, EventArgs e)
        {
            string codigo = txtcodigopro.Text;
            string descripcion = txtdescripcionpro.Text;
            string precio = txtpreciopro.Text;
            string cantidad = txtcantidadpro.Text;

            if (codigo == "" || descripcion == "" || cantidad == "" || precio == "")
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }
            else
            {
                PRODUCTOS nuevoproducto = new PRODUCTOS(0, codigo, descripcion, Convert.ToDecimal(precio), Convert.ToDouble(cantidad));
                int reg = nuevoproducto.AgregarProducto();

                if (reg > 0)
                {
                    MessageBox.Show("El Producto se guardo correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposProducto();
                    PRODUCTOS prod = new PRODUCTOS();
                    prod.ListarProductos(dgvProducto);
                }
                else
                {
                    MessageBox.Show("El Producto no se pudo insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void PRODUCTO_Load(object sender, EventArgs e)
        {
            PRODUCTOS pro = new PRODUCTOS();
            pro.ListarProductos(dgvProducto);
        }

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (i == -1 || dgvProducto.SelectedCells[1].Value.ToString() == "")
            {
                LimpiarCamposProducto();
            }
            else
            {
                txtcodigopro.Text = dgvProducto.SelectedCells[1].Value.ToString();
                txtdescripcionpro.Text = dgvProducto.SelectedCells[2].Value.ToString();
                txtpreciopro.Text = dgvProducto.SelectedCells[4].Value.ToString();
                txtcantidadpro.Text = dgvProducto.SelectedCells[3].Value.ToString();

                btnGuardarPro.Enabled = false;
                btnModificarPro.Enabled = true;
                btnEliminarPro.Enabled = true;
            }
        }

        public void LimpiarCamposProducto()
        {
            txtproductoidpro.Text = "";
            txtcodigopro.Text = "";
            txtdescripcionpro.Text = "";
            txtpreciopro.Text = "";
            txtcantidadpro.Text = "";

            btnGuardarPro.Enabled = true;
            btnModificarPro.Enabled = false;
            btnEliminarPro.Enabled = false;

            txtcodigopro.Focus();
        }

        private void btnEliminarPro_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtproductoidpro.Text);

            DialogResult confirmar = MessageBox.Show("El producto se eliminará, ¿esta seguro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirmar == DialogResult.OK)
            {
                PRODUCTOS pro = new PRODUCTOS(id);
                int reg = pro.EliminarProducto();

                if (reg == 1)
                {
                    MessageBox.Show("El producto se elimino correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposProducto();
                    PRODUCTOS prod = new PRODUCTOS();
                    prod.ListarProductos(dgvProducto);
                }
                else
                {
                    MessageBox.Show("El producto no se pudo eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                LimpiarCamposProducto();
            }
        }

        private void btnModificarPro_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtproductoidpro.Text);
            string codigo = txtcodigopro.Text;
            string descripcion = txtdescripcionpro.Text;
            string precio = txtpreciopro.Text;
            string cantidad = txtcantidadpro.Text;

            DialogResult confirmar = MessageBox.Show("Se guardarán los cambios, ¿esta seguro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirmar == DialogResult.OK)
            {
                PRODUCTOS pro = new PRODUCTOS(id, codigo, descripcion, Convert.ToDecimal(precio), Convert.ToDouble(cantidad));
                int reg = pro.ModificarProducto();

                if (reg == 1)
                {
                    MessageBox.Show("El Producto se modifico correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposProducto();
                    PRODUCTOS prod = new PRODUCTOS();
                    prod.ListarProductos(dgvProducto);
                }
                else
                {
                    MessageBox.Show("El Producto no se pudo actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                LimpiarCamposProducto();
            }
        }

        private void PRODUCTO_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
