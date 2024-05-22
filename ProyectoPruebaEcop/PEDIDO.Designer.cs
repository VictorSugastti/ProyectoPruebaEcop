namespace ProyectoPruebaEcop
{
    partial class PEDIDO
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
            this.gbPedidoCabecera = new System.Windows.Forms.GroupBox();
            this.txtProductoId = new System.Windows.Forms.TextBox();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.txtClienteIdPed = new System.Windows.Forms.TextBox();
            this.txtDescripcionPedido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidadPedido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRazonSocialPedido = new System.Windows.Forms.TextBox();
            this.lblPedidoCliente = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.txtTotalCantidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalPrecio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.gbPedidoCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPedidoCabecera
            // 
            this.gbPedidoCabecera.Controls.Add(this.txtProductoId);
            this.gbPedidoCabecera.Controls.Add(this.btnAgregarPedido);
            this.gbPedidoCabecera.Controls.Add(this.txtClienteIdPed);
            this.gbPedidoCabecera.Controls.Add(this.txtDescripcionPedido);
            this.gbPedidoCabecera.Controls.Add(this.label9);
            this.gbPedidoCabecera.Controls.Add(this.dateFechaEntrega);
            this.gbPedidoCabecera.Controls.Add(this.label8);
            this.gbPedidoCabecera.Controls.Add(this.dateFecha);
            this.gbPedidoCabecera.Controls.Add(this.label7);
            this.gbPedidoCabecera.Controls.Add(this.textBox7);
            this.gbPedidoCabecera.Controls.Add(this.label6);
            this.gbPedidoCabecera.Controls.Add(this.txtCantidadPedido);
            this.gbPedidoCabecera.Controls.Add(this.label5);
            this.gbPedidoCabecera.Controls.Add(this.textBox5);
            this.gbPedidoCabecera.Controls.Add(this.label4);
            this.gbPedidoCabecera.Controls.Add(this.textBox4);
            this.gbPedidoCabecera.Controls.Add(this.label3);
            this.gbPedidoCabecera.Controls.Add(this.textBox3);
            this.gbPedidoCabecera.Controls.Add(this.label2);
            this.gbPedidoCabecera.Controls.Add(this.textBox2);
            this.gbPedidoCabecera.Controls.Add(this.label1);
            this.gbPedidoCabecera.Controls.Add(this.txtRazonSocialPedido);
            this.gbPedidoCabecera.Controls.Add(this.lblPedidoCliente);
            this.gbPedidoCabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPedidoCabecera.Location = new System.Drawing.Point(4, 12);
            this.gbPedidoCabecera.Name = "gbPedidoCabecera";
            this.gbPedidoCabecera.Size = new System.Drawing.Size(1070, 212);
            this.gbPedidoCabecera.TabIndex = 0;
            this.gbPedidoCabecera.TabStop = false;
            this.gbPedidoCabecera.Text = "Datos Pedido";
            // 
            // txtProductoId
            // 
            this.txtProductoId.Enabled = false;
            this.txtProductoId.Location = new System.Drawing.Point(366, 141);
            this.txtProductoId.Name = "txtProductoId";
            this.txtProductoId.ReadOnly = true;
            this.txtProductoId.Size = new System.Drawing.Size(132, 22);
            this.txtProductoId.TabIndex = 25;
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.Location = new System.Drawing.Point(909, 111);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(138, 28);
            this.btnAgregarPedido.TabIndex = 24;
            this.btnAgregarPedido.Text = "Agregar";
            this.btnAgregarPedido.UseVisualStyleBackColor = true;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // txtClienteIdPed
            // 
            this.txtClienteIdPed.Enabled = false;
            this.txtClienteIdPed.Location = new System.Drawing.Point(833, 32);
            this.txtClienteIdPed.Name = "txtClienteIdPed";
            this.txtClienteIdPed.ReadOnly = true;
            this.txtClienteIdPed.Size = new System.Drawing.Size(162, 22);
            this.txtClienteIdPed.TabIndex = 23;
            // 
            // txtDescripcionPedido
            // 
            this.txtDescripcionPedido.Location = new System.Drawing.Point(108, 113);
            this.txtDescripcionPedido.Name = "txtDescripcionPedido";
            this.txtDescripcionPedido.Size = new System.Drawing.Size(776, 22);
            this.txtDescripcionPedido.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Descripción";
            // 
            // dateFechaEntrega
            // 
            this.dateFechaEntrega.Location = new System.Drawing.Point(833, 67);
            this.dateFechaEntrega.Name = "dateFechaEntrega";
            this.dateFechaEntrega.Size = new System.Drawing.Size(162, 22);
            this.dateFechaEntrega.TabIndex = 20;
            this.dateFechaEntrega.Value = new System.DateTime(2024, 5, 22, 3, 59, 59, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(713, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Fecha Entrega";
            // 
            // dateFecha
            // 
            this.dateFecha.Location = new System.Drawing.Point(515, 69);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(173, 22);
            this.dateFecha.TabIndex = 18;
            this.dateFecha.Value = new System.DateTime(2024, 5, 22, 4, 6, 59, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fecha";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(890, 166);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(176, 22);
            this.textBox7.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(832, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Precio";
            // 
            // txtCantidadPedido
            // 
            this.txtCantidadPedido.Location = new System.Drawing.Point(725, 165);
            this.txtCantidadPedido.Name = "txtCantidadPedido";
            this.txtCantidadPedido.Size = new System.Drawing.Size(96, 22);
            this.txtCantidadPedido.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(366, 166);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(280, 22);
            this.textBox5.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descripción";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(75, 163);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(176, 22);
            this.textBox4.TabIndex = 7;
            this.textBox4.Click += new System.EventHandler(this.textBox4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codigo";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(108, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(314, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Direccion";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(579, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nro. Documento";
            // 
            // txtRazonSocialPedido
            // 
            this.txtRazonSocialPedido.Location = new System.Drawing.Point(84, 30);
            this.txtRazonSocialPedido.Name = "txtRazonSocialPedido";
            this.txtRazonSocialPedido.Size = new System.Drawing.Size(338, 22);
            this.txtRazonSocialPedido.TabIndex = 1;
            this.txtRazonSocialPedido.Click += new System.EventHandler(this.txtRazonSocialPedido_Click);
            // 
            // lblPedidoCliente
            // 
            this.lblPedidoCliente.AutoSize = true;
            this.lblPedidoCliente.Location = new System.Drawing.Point(18, 32);
            this.lblPedidoCliente.Name = "lblPedidoCliente";
            this.lblPedidoCliente.Size = new System.Drawing.Size(55, 16);
            this.lblPedidoCliente.TabIndex = 0;
            this.lblPedidoCliente.Text = "Cliente";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(4, 230);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.RowTemplate.Height = 24;
            this.dgvDetalle.Size = new System.Drawing.Size(1070, 439);
            this.dgvDetalle.TabIndex = 1;
            // 
            // txtTotalCantidad
            // 
            this.txtTotalCantidad.Location = new System.Drawing.Point(232, 689);
            this.txtTotalCantidad.Name = "txtTotalCantidad";
            this.txtTotalCantidad.ReadOnly = true;
            this.txtTotalCantidad.Size = new System.Drawing.Size(176, 22);
            this.txtTotalCantidad.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 692);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Cantidad Total Productos";
            // 
            // txtTotalPrecio
            // 
            this.txtTotalPrecio.Location = new System.Drawing.Point(616, 692);
            this.txtTotalPrecio.Name = "txtTotalPrecio";
            this.txtTotalPrecio.ReadOnly = true;
            this.txtTotalPrecio.Size = new System.Drawing.Size(176, 22);
            this.txtTotalPrecio.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(466, 694);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Total a Pagar";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(835, 731);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(216, 49);
            this.btnRegistrar.TabIndex = 29;
            this.btnRegistrar.Text = "Guardar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // PEDIDO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 801);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtTotalPrecio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotalCantidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.gbPedidoCabecera);
            this.Name = "PEDIDO";
            this.Text = "PEDIDO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PEDIDO_FormClosing);
            this.gbPedidoCabecera.ResumeLayout(false);
            this.gbPedidoCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPedidoCabecera;
        private System.Windows.Forms.TextBox txtRazonSocialPedido;
        private System.Windows.Forms.Label lblPedidoCliente;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidadPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateFechaEntrega;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.TextBox txtDescripcionPedido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtClienteIdPed;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.TextBox txtTotalCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalPrecio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtProductoId;
    }
}