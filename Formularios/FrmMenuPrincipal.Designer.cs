namespace SistemaVentas.Formularios
{
    partial class FrmMenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVendedores = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblResumen = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(720, 100);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblTitulo.Location = new System.Drawing.Point(36, 14);
            this.lblTitulo.Text = "SISTEMA DE VENTAS";
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 2;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(190, 208, 230);
            this.lblSubtitulo.Location = new System.Drawing.Point(40, 64);
            this.lblSubtitulo.Text = "Proyecto Integrador - Grupo 3";
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 3;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProductos.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnProductos.Location = new System.Drawing.Point(40, 135);
            this.btnProductos.Size = new System.Drawing.Size(200, 100);
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(22, 160, 133);
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClientes.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnClientes.Location = new System.Drawing.Point(260, 135);
            this.btnClientes.Size = new System.Drawing.Size(200, 100);
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVendedores
            // 
            this.btnVendedores.BackColor = System.Drawing.Color.FromArgb(142, 68, 173);
            this.btnVendedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVendedores.FlatAppearance.BorderSize = 0;
            this.btnVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendedores.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVendedores.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnVendedores.Location = new System.Drawing.Point(480, 135);
            this.btnVendedores.Size = new System.Drawing.Size(200, 100);
            this.btnVendedores.Text = "Vendedores";
            this.btnVendedores.UseVisualStyleBackColor = false;
            this.btnVendedores.Name = "btnVendedores";
            this.btnVendedores.TabIndex = 6;
            this.btnVendedores.Click += new System.EventHandler(this.btnVendedores_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVentas.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnVentas.Location = new System.Drawing.Point(40, 250);
            this.btnVentas.Size = new System.Drawing.Size(200, 100);
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.TabIndex = 7;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.btnFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturas.FlatAppearance.BorderSize = 0;
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFacturas.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnFacturas.Location = new System.Drawing.Point(260, 250);
            this.btnFacturas.Size = new System.Drawing.Size(200, 100);
            this.btnFacturas.Text = "Facturación";
            this.btnFacturas.UseVisualStyleBackColor = false;
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.TabIndex = 8;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReportes.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnReportes.Location = new System.Drawing.Point(480, 250);
            this.btnReportes.Size = new System.Drawing.Size(200, 100);
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.TabIndex = 9;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(110, 122, 135);
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnSalir.Location = new System.Drawing.Point(260, 370);
            this.btnSalir.Size = new System.Drawing.Size(200, 42);
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblResumen.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblResumen.Location = new System.Drawing.Point(40, 440);
            this.lblResumen.Text = "Productos: 0   Clientes: 0   Vendedores: 0   Ventas: 0";
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.TabIndex = 11;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblRuta.ForeColor = System.Drawing.Color.FromArgb(110, 122, 135);
            this.lblRuta.Location = new System.Drawing.Point(40, 468);
            this.lblRuta.Text = "Datos guardados en: ";
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.TabIndex = 12;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(240, 243, 248);
            this.ClientSize = new System.Drawing.Size(720, 520);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnVendedores);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnFacturas);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.lblRuta);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Ventas";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVendedores;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Label lblRuta;
    }
}
