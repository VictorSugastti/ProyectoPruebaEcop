using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoPruebaEcop
{
    public partial class CLIENTE : Form
    {
        public CLIENTE()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string razon_social = txtrazonsocial.Text;
            string nro_documento = txtnrodocumento.Text;
            string direccion = txtdireccion.Text;
            string correo = txtcorreo.Text;
            string telefono = txttelefono.Text;
            int tipodoc = 0;

            if (cbtipo.SelectedIndex != -1)
            {
                tipodoc = (int)cbtipo.SelectedValue;
            }

            if (correo != "")
            {
                if (!ValidarCorreoElectronico(correo))
                {
                    MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (razon_social == "" || nro_documento == "" || cbtipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar al menos la Razón Social y el Nro. de Documento");
            }
            else
            {
                CLIENTES nuevocliente = new CLIENTES(0, razon_social, nro_documento, direccion, correo, telefono, tipodoc);
                int reg = nuevocliente.AgregarCliente();

                if (reg > 0)
                {
                    MessageBox.Show("El Cliente se guardo correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposCliente();
                }
                else
                {
                    MessageBox.Show("El Cliente no se pudo insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarCamposCliente();
                }

            }
        }

        private void CLIENTE_Load(object sender, EventArgs e)
        {
            CargarCbtipo();
            CLIENTES cli = new CLIENTES();
            cli.ListarClientes(dgvCliente);
        }
        private void CargarCbtipo()
        {
            try
            {
                UNIDAD_MEDIDA unidadMedida = new UNIDAD_MEDIDA();
                List<UNIDAD_MEDIDA> listaUnidad = unidadMedida.ListarUnidadMedida();

                UNIDAD_MEDIDA elementoPorDefecto = new UNIDAD_MEDIDA
                {
                    Id = 0,
                    Codigo = "Seleccione",
                    Descripcion = ""
                };
                listaUnidad.Insert(0, elementoPorDefecto);
                cbtipo.DisplayMember = "Codigo";
                cbtipo.ValueMember = "Id";

                cbtipo.DataSource = listaUnidad;
                cbtipo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los tipos de documentos: " + ex.Message);
            }
        }

        private bool ValidarCorreoElectronico(string correo)
        {
            string patronCorreo = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            return Regex.IsMatch(correo, patronCorreo);
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (i == -1 || dgvCliente.SelectedCells[1].Value.ToString() == "")
            {
                LimpiarCamposCliente();
            }
            else
            {
                txtClienteId.Text = dgvCliente.SelectedCells[0].Value.ToString();
                txtrazonsocial.Text = dgvCliente.SelectedCells[3].Value.ToString();
                txtnrodocumento.Text = dgvCliente.SelectedCells[1].Value.ToString();
                txtdireccion.Text = dgvCliente.SelectedCells[4].Value.ToString();
                txtcorreo.Text = dgvCliente.SelectedCells[7].Value.ToString();
                txttelefono.Text = dgvCliente.SelectedCells[5].Value.ToString();
                cbtipo.SelectedIndex = (int)dgvCliente.SelectedCells[2].Value;

                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtClienteId.Text);

            DialogResult confirmar = MessageBox.Show("El cliente se eliminará, ¿esta seguro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirmar == DialogResult.OK)
            {
                CLIENTES cliente = new CLIENTES(id);
                int reg = cliente.EliminarCliente();

                if (reg == 1)
                {
                    MessageBox.Show("El Cliente se elimino correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposCliente();
                    CLIENTES cli = new CLIENTES();
                    cli.ListarClientes(dgvCliente);
                }
                else
                {
                    MessageBox.Show("El Cliente no se pudo eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                LimpiarCamposCliente();
            }
        }

        public void LimpiarCamposCliente()
        {
            txtrazonsocial.Text = "";
            txtnrodocumento.Text = "";
            txtdireccion.Text = "";
            txtcorreo.Text = "";
            txttelefono.Text = "";
            cbtipo.SelectedIndex = 0;
            txtClienteId.Text = "";

            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            txtrazonsocial.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtClienteId.Text);
            string razon_social = txtrazonsocial.Text;
            string nro_documento = txtnrodocumento.Text;
            string direccion = txtdireccion.Text;
            string correo = txtcorreo.Text;
            string telefono = txttelefono.Text;
            int tipodoc = (int)cbtipo.SelectedValue;

            DialogResult confirmar = MessageBox.Show("Se guardarán los cambios, ¿esta seguro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirmar == DialogResult.OK)
            {
                CLIENTES cliente = new CLIENTES(id, nro_documento, razon_social, direccion, correo, telefono, tipodoc);
                int reg = cliente.ModificarCliente();

                if (reg == 1)
                {
                    MessageBox.Show("El Cliente se modifico correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposCliente();
                    CLIENTES cli = new CLIENTES();
                    cli.ListarClientes(dgvCliente);
                }
                else
                {
                    MessageBox.Show("El Cliente no se pudo actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                LimpiarCamposCliente();
            }
        }

        private void CLIENTE_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
