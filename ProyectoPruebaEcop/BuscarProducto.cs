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
    public partial class BuscarProducto : Form
    {
        public BuscarProducto()
        {
            InitializeComponent();
        }

        public delegate void ProductoSeleccionadoHandler(int productoId, string codigo, string descripcion, string precio);
        public event ProductoSeleccionadoHandler ProductoSeleccionado;

        private void dgvBuscarProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i == -1 || dgvBuscarProducto.SelectedCells[0].Value.ToString() == "")
            {

            }
            else
            {
                int productoId = (int)dgvBuscarProducto.SelectedCells[0].Value;
                string codigo = dgvBuscarProducto.SelectedCells[1].Value.ToString();
                string descripcion = dgvBuscarProducto.SelectedCells[2].Value.ToString();
                string precio = dgvBuscarProducto.SelectedCells[4].Value.ToString();

                ProductoSeleccionado?.Invoke(productoId, codigo, descripcion, precio);
                this.Close();
            }
        }

        private void BuscarProducto_Load(object sender, EventArgs e)
        {
            PRODUCTOS pro = new PRODUCTOS();
            pro.ListarProductos(dgvBuscarProducto);
        }
    }
}
