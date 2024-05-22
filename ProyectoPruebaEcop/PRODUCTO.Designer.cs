namespace ProyectoPruebaEcop
{
    partial class PRODUCTO
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
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.btnEliminarPro = new System.Windows.Forms.Button();
            this.btnModificarPro = new System.Windows.Forms.Button();
            this.txtproductoidpro = new System.Windows.Forms.TextBox();
            this.lblproductoidpro = new System.Windows.Forms.Label();
            this.btnGuardarPro = new System.Windows.Forms.Button();
            this.txtcantidadpro = new System.Windows.Forms.TextBox();
            this.txtpreciopro = new System.Windows.Forms.TextBox();
            this.txtdescripcionpro = new System.Windows.Forms.TextBox();
            this.txtcodigopro = new System.Windows.Forms.TextBox();
            this.lblcantidadpro = new System.Windows.Forms.Label();
            this.lblpreciopro = new System.Windows.Forms.Label();
            this.lbldescripcionpro = new System.Windows.Forms.Label();
            this.lblcodigopro = new System.Windows.Forms.Label();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.gbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProductos
            // 
            this.gbProductos.Controls.Add(this.btnEliminarPro);
            this.gbProductos.Controls.Add(this.btnModificarPro);
            this.gbProductos.Controls.Add(this.txtproductoidpro);
            this.gbProductos.Controls.Add(this.lblproductoidpro);
            this.gbProductos.Controls.Add(this.btnGuardarPro);
            this.gbProductos.Controls.Add(this.txtcantidadpro);
            this.gbProductos.Controls.Add(this.txtpreciopro);
            this.gbProductos.Controls.Add(this.txtdescripcionpro);
            this.gbProductos.Controls.Add(this.txtcodigopro);
            this.gbProductos.Controls.Add(this.lblcantidadpro);
            this.gbProductos.Controls.Add(this.lblpreciopro);
            this.gbProductos.Controls.Add(this.lbldescripcionpro);
            this.gbProductos.Controls.Add(this.lblcodigopro);
            this.gbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductos.Location = new System.Drawing.Point(12, 22);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(448, 339);
            this.gbProductos.TabIndex = 1;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "CARGA DE PRODUCTO";
            // 
            // btnEliminarPro
            // 
            this.btnEliminarPro.Location = new System.Drawing.Point(21, 283);
            this.btnEliminarPro.Name = "btnEliminarPro";
            this.btnEliminarPro.Size = new System.Drawing.Size(118, 32);
            this.btnEliminarPro.TabIndex = 14;
            this.btnEliminarPro.Text = "Eliminar";
            this.btnEliminarPro.UseVisualStyleBackColor = true;
            this.btnEliminarPro.Click += new System.EventHandler(this.btnEliminarPro_Click);
            // 
            // btnModificarPro
            // 
            this.btnModificarPro.Location = new System.Drawing.Point(164, 283);
            this.btnModificarPro.Name = "btnModificarPro";
            this.btnModificarPro.Size = new System.Drawing.Size(118, 32);
            this.btnModificarPro.TabIndex = 13;
            this.btnModificarPro.Text = "Modificar";
            this.btnModificarPro.UseVisualStyleBackColor = true;
            this.btnModificarPro.Click += new System.EventHandler(this.btnModificarPro_Click);
            // 
            // txtproductoidpro
            // 
            this.txtproductoidpro.Location = new System.Drawing.Point(164, 34);
            this.txtproductoidpro.Name = "txtproductoidpro";
            this.txtproductoidpro.ReadOnly = true;
            this.txtproductoidpro.Size = new System.Drawing.Size(236, 22);
            this.txtproductoidpro.TabIndex = 12;
            // 
            // lblproductoidpro
            // 
            this.lblproductoidpro.AutoSize = true;
            this.lblproductoidpro.Location = new System.Drawing.Point(24, 37);
            this.lblproductoidpro.Name = "lblproductoidpro";
            this.lblproductoidpro.Size = new System.Drawing.Size(22, 16);
            this.lblproductoidpro.TabIndex = 11;
            this.lblproductoidpro.Text = "ID";
            // 
            // btnGuardarPro
            // 
            this.btnGuardarPro.Location = new System.Drawing.Point(305, 283);
            this.btnGuardarPro.Name = "btnGuardarPro";
            this.btnGuardarPro.Size = new System.Drawing.Size(118, 32);
            this.btnGuardarPro.TabIndex = 10;
            this.btnGuardarPro.Text = "Guardar";
            this.btnGuardarPro.UseVisualStyleBackColor = true;
            this.btnGuardarPro.Click += new System.EventHandler(this.btnguardarpro_Click);
            // 
            // txtcantidadpro
            // 
            this.txtcantidadpro.Location = new System.Drawing.Point(160, 240);
            this.txtcantidadpro.Name = "txtcantidadpro";
            this.txtcantidadpro.Size = new System.Drawing.Size(236, 22);
            this.txtcantidadpro.TabIndex = 9;
            this.txtcantidadpro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidadpro_KeyPress);
            // 
            // txtpreciopro
            // 
            this.txtpreciopro.Location = new System.Drawing.Point(164, 186);
            this.txtpreciopro.Name = "txtpreciopro";
            this.txtpreciopro.Size = new System.Drawing.Size(236, 22);
            this.txtpreciopro.TabIndex = 7;
            this.txtpreciopro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreciopro_KeyPress);
            // 
            // txtdescripcionpro
            // 
            this.txtdescripcionpro.Location = new System.Drawing.Point(164, 130);
            this.txtdescripcionpro.Name = "txtdescripcionpro";
            this.txtdescripcionpro.Size = new System.Drawing.Size(236, 22);
            this.txtdescripcionpro.TabIndex = 6;
            // 
            // txtcodigopro
            // 
            this.txtcodigopro.Location = new System.Drawing.Point(164, 78);
            this.txtcodigopro.Name = "txtcodigopro";
            this.txtcodigopro.Size = new System.Drawing.Size(236, 22);
            this.txtcodigopro.TabIndex = 5;
            // 
            // lblcantidadpro
            // 
            this.lblcantidadpro.AutoSize = true;
            this.lblcantidadpro.Location = new System.Drawing.Point(20, 246);
            this.lblcantidadpro.Name = "lblcantidadpro";
            this.lblcantidadpro.Size = new System.Drawing.Size(69, 16);
            this.lblcantidadpro.TabIndex = 4;
            this.lblcantidadpro.Text = "Cantidad";
            // 
            // lblpreciopro
            // 
            this.lblpreciopro.AutoSize = true;
            this.lblpreciopro.Location = new System.Drawing.Point(24, 189);
            this.lblpreciopro.Name = "lblpreciopro";
            this.lblpreciopro.Size = new System.Drawing.Size(52, 16);
            this.lblpreciopro.TabIndex = 2;
            this.lblpreciopro.Text = "Precio";
            // 
            // lbldescripcionpro
            // 
            this.lbldescripcionpro.AutoSize = true;
            this.lbldescripcionpro.Location = new System.Drawing.Point(24, 133);
            this.lbldescripcionpro.Name = "lbldescripcionpro";
            this.lbldescripcionpro.Size = new System.Drawing.Size(90, 16);
            this.lbldescripcionpro.TabIndex = 1;
            this.lbldescripcionpro.Text = "Descripción";
            // 
            // lblcodigopro
            // 
            this.lblcodigopro.AutoSize = true;
            this.lblcodigopro.Location = new System.Drawing.Point(24, 81);
            this.lblcodigopro.Name = "lblcodigopro";
            this.lblcodigopro.Size = new System.Drawing.Size(61, 16);
            this.lblcodigopro.TabIndex = 0;
            this.lblcodigopro.Text = "Código ";
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(466, 28);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.RowHeadersWidth = 51;
            this.dgvProducto.RowTemplate.Height = 24;
            this.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducto.Size = new System.Drawing.Size(608, 332);
            this.dgvProducto.TabIndex = 2;
            this.dgvProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellClick);
            // 
            // PRODUCTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 392);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.gbProductos);
            this.Name = "PRODUCTO";
            this.Text = "PRODUCTO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PRODUCTO_FormClosing);
            this.Load += new System.EventHandler(this.PRODUCTO_Load);
            this.gbProductos.ResumeLayout(false);
            this.gbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.Button btnGuardarPro;
        private System.Windows.Forms.TextBox txtcantidadpro;
        private System.Windows.Forms.TextBox txtpreciopro;
        private System.Windows.Forms.TextBox txtdescripcionpro;
        private System.Windows.Forms.TextBox txtcodigopro;
        private System.Windows.Forms.Label lblcantidadpro;
        private System.Windows.Forms.Label lblpreciopro;
        private System.Windows.Forms.Label lbldescripcionpro;
        private System.Windows.Forms.Label lblcodigopro;
        private System.Windows.Forms.TextBox txtproductoidpro;
        private System.Windows.Forms.Label lblproductoidpro;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.Button btnEliminarPro;
        private System.Windows.Forms.Button btnModificarPro;
    }
}