namespace ProyectoPruebaEcop
{
    partial class BuscarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvBuscarCli = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRazonSocialPedido = new System.Windows.Forms.TextBox();
            this.lblPedidoCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCli)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuscarCli
            // 
            this.dgvBuscarCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarCli.Location = new System.Drawing.Point(28, 54);
            this.dgvBuscarCli.Name = "dgvBuscarCli";
            this.dgvBuscarCli.ReadOnly = true;
            this.dgvBuscarCli.RowHeadersWidth = 51;
            this.dgvBuscarCli.RowTemplate.Height = 24;
            this.dgvBuscarCli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscarCli.Size = new System.Drawing.Size(767, 372);
            this.dgvBuscarCli.TabIndex = 13;
            this.dgvBuscarCli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarCli_CellClick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(586, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 22);
            this.textBox2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nro. Documento";
            // 
            // txtRazonSocialPedido
            // 
            this.txtRazonSocialPedido.Location = new System.Drawing.Point(91, 10);
            this.txtRazonSocialPedido.Name = "txtRazonSocialPedido";
            this.txtRazonSocialPedido.Size = new System.Drawing.Size(338, 22);
            this.txtRazonSocialPedido.TabIndex = 10;
            // 
            // lblPedidoCliente
            // 
            this.lblPedidoCliente.AutoSize = true;
            this.lblPedidoCliente.Location = new System.Drawing.Point(25, 12);
            this.lblPedidoCliente.Name = "lblPedidoCliente";
            this.lblPedidoCliente.Size = new System.Drawing.Size(48, 16);
            this.lblPedidoCliente.TabIndex = 9;
            this.lblPedidoCliente.Text = "Cliente";
            // 
            // BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.dgvBuscarCli);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRazonSocialPedido);
            this.Controls.Add(this.lblPedidoCliente);
            this.Name = "BuscarCliente";
            this.Text = "BuscarCliente";
            this.Load += new System.EventHandler(this.BuscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarCli;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRazonSocialPedido;
        private System.Windows.Forms.Label lblPedidoCliente;
    }
}