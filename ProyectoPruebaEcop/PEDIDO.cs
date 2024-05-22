using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoPruebaEcop.BuscarCliente;

namespace ProyectoPruebaEcop
{
    public partial class PEDIDO : Form
    {
        public PEDIDO()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void txtRazonSocialPedido_Click(object sender, EventArgs e)
        {
            BuscarCliente cliente = new BuscarCliente();
            cliente.ClienteSeleccionado += ClienteSeleccionadoHandler;
            cliente.Show();
        }

        private void ClienteSeleccionadoHandler(string clienteId,string razonSocial, string nroDocumento, string direccion)
        {
            txtClienteIdPed.Text = clienteId;
            txtRazonSocialPedido.Text = razonSocial;
            textBox2.Text = nroDocumento;
            textBox3.Text = direccion;
        }

        private void ProductoSeleccionadoHandler(int productoId, string codigo, string descripcion, string precio)
        {
            txtProductoId.Text = productoId.ToString();
            textBox4.Text = codigo;
            textBox5.Text = descripcion;
            textBox7.Text = precio;
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            int clienteId = Convert.ToInt32(txtClienteIdPed.Text);
            string razonsocial = txtRazonSocialPedido.Text;
            string nrodoc = textBox2.Text;
            string direccion = textBox3.Text;
            int productoId = Convert.ToInt32(txtProductoId.Text);
            string codigo = textBox4.Text;
            string producto = textBox5.Text;
            string precio = textBox7.Text;

            string cantidad = txtCantidadPedido.Text;
            DateTime fecha;
            if (!DateTime.TryParse(dateFechaEntrega.Text, out fecha))
            {
                MessageBox.Show("La fecha de entrega debe ser una fecha válida.");
                return;
            }

            if (razonsocial == "" || nrodoc == "" || cantidad == "")
            {
                MessageBox.Show("Debe completar los campos.");
                return;
            }

            decimal precioDecimal;
            int cantidadInt;
            if (!decimal.TryParse(precio, out precioDecimal))
            {
                MessageBox.Show("El precio debe ser un número válido.");
                return;
            }
            if (!int.TryParse(cantidad, out cantidadInt))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.");
                return;
            }
            decimal total = Convert.ToDecimal(precio) * Convert.ToInt32(cantidad);

            dgvDetalle.Rows.Add(codigo, productoId, producto, precio, cantidad, total);

            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            txtCantidadPedido.Text = "";

            ActualizarTotales();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            BuscarProducto prod = new BuscarProducto();
            prod.ProductoSeleccionado += ProductoSeleccionadoHandler;
            prod.Show();
        }

        private void SetupDataGridView()
        {
            dgvDetalle.Columns.Add("Codigo", "Código Producto");
            dgvDetalle.Columns.Add("ProductoId", "Producto Id");
            dgvDetalle.Columns.Add("Producto", "Descripcion");
            dgvDetalle.Columns.Add("Precio", "Precio Unitario");
            dgvDetalle.Columns.Add("Cantidad", "Cantidad");
            dgvDetalle.Columns.Add("Total", "Total");

        }

        private void ActualizarTotales()
        {
            int totalCantidad = 0;
            decimal totalPrecio = 0;

            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                decimal total = Convert.ToDecimal(row.Cells["Total"].Value);

                totalCantidad += cantidad;
                totalPrecio += total;
            }

            txtTotalCantidad.Text = totalCantidad.ToString();
            txtTotalPrecio.Text = totalPrecio.ToString("0.00");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                int clienteId = Convert.ToInt32(txtClienteIdPed.Text);
                string razonsocial = txtRazonSocialPedido.Text;
                string nrodoc = textBox2.Text;
                string direccion = textBox3.Text;
                string pedidodescripcion = txtDescripcionPedido.Text;

                double cantidadtotal = Convert.ToDouble(txtTotalCantidad.Text);
                decimal preciototal = Convert.ToDecimal(txtTotalPrecio.Text);

                DateTime fechaEntrega;
                if (!DateTime.TryParse(dateFechaEntrega.Text, out fechaEntrega))
                {
                    MessageBox.Show("La fecha de entrega debe ser una fecha válida.");
                    return;
                }

                PEDIDOS pedidoDAO = new PEDIDOS();
                int pedidoId = pedidoDAO.InsertarPedido(clienteId, fechaEntrega, pedidodescripcion, cantidadtotal, preciototal);

                foreach (DataGridViewRow row in dgvDetalle.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string codigo = row.Cells["Codigo"].Value.ToString();
                        string productoId = row.Cells["ProductoId"].Value.ToString();
                        decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        string descripcionproducto = row.Cells["Producto"].Value.ToString();

                        pedidoDAO.InsertarDetallePedido(pedidoId, productoId, precio, cantidad, descripcionproducto);
                    }
                }

                MessageBox.Show("Pedido registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtClienteIdPed.Text = "";
                txtRazonSocialPedido.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox7.Text = "";
                txtCantidadPedido.Text = "";
                dateFechaEntrega.Text = DateTime.Now.ToString();
                dgvDetalle.Rows.Clear();
                txtTotalCantidad.Text = "";
                txtTotalPrecio.Text = "";
                txtRazonSocialPedido.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void PEDIDO_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
