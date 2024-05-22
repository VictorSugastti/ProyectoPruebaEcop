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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            CLIENTE btncliente = new CLIENTE();
            btncliente.Show();
            this.Hide();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            PRODUCTO btnProducto = new PRODUCTO();
            btnProducto.Show();
            this.Hide();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            PEDIDO btnPedido = new PEDIDO();
            btnPedido.Show();
            this.Hide();
        }
    }
}
