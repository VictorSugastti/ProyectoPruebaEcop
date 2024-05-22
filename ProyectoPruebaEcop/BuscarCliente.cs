using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoPruebaEcop
{
    public partial class BuscarCliente : Form
    {
        public BuscarCliente()
        {
            InitializeComponent();
        }

        public delegate void ClienteSeleccionadoHandler(string clienteId, string razonSocial, string nroDocumento, string direccion);
        public event ClienteSeleccionadoHandler ClienteSeleccionado;
        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            CLIENTES cli = new CLIENTES();
            cli.ListarClientes(dgvBuscarCli);
        }

        private void dgvBuscarCli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBuscarCli.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvBuscarCli.SelectedRows[0];
                if (selectedRow.Cells.Count >= 5)
                {
                    string clienteId = selectedRow.Cells[0].Value.ToString();
                    string razonSocial = selectedRow.Cells[3].Value.ToString();
                    string nroDocumento = selectedRow.Cells[1].Value.ToString();
                    string direccion = selectedRow.Cells[4].Value.ToString();
                    ClienteSeleccionado?.Invoke(clienteId, razonSocial, nroDocumento, direccion);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La fila seleccionada no tiene suficientes celdas.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila.");
            }

        }
    }
}
