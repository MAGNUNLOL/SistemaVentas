namespace SistemaVentas.Formularios
{
    partial class FrmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlNueva = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.cboVendedor = new System.Windows.Forms.ComboBox();
            this.lblPago = new System.Windows.Forms.Label();
            this.cboPago = new System.Windows.Forms.ComboBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDescuentoMonto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlNueva.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1000, 76);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblTitulo.Location = new System.Drawing.Point(22, 10);
            this.lblTitulo.Text = "Gestión de Ventas";
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 2;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(190, 208, 230);
            this.lblSubtitulo.Location = new System.Drawing.Point(25, 46);
            this.lblSubtitulo.Text = "Seleccione productos, aplique descuentos, elija el pago y registre la venta";
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 3;
            // 
            // pnlNueva
            // 
            this.pnlNueva.Controls.Add(this.lblCliente);
            this.pnlNueva.Controls.Add(this.cboCliente);
            this.pnlNueva.Controls.Add(this.lblVendedor);
            this.pnlNueva.Controls.Add(this.cboVendedor);
            this.pnlNueva.Controls.Add(this.lblPago);
            this.pnlNueva.Controls.Add(this.cboPago);
            this.pnlNueva.Controls.Add(this.lblDescuento);
            this.pnlNueva.Controls.Add(this.txtDescuento);
            this.pnlNueva.Controls.Add(this.lblProducto);
            this.pnlNueva.Controls.Add(this.cboProducto);
            this.pnlNueva.Controls.Add(this.lblCantidad);
            this.pnlNueva.Controls.Add(this.nudCantidad);
            this.pnlNueva.Controls.Add(this.btnAgregar);
            this.pnlNueva.Controls.Add(this.btnQuitar);
            this.pnlNueva.Controls.Add(this.dgvDetalle);
            this.pnlNueva.Controls.Add(this.lblSubtotal);
            this.pnlNueva.Controls.Add(this.lblDescuentoMonto);
            this.pnlNueva.Controls.Add(this.lblTotal);
            this.pnlNueva.Controls.Add(this.btnRegistrar);
            this.pnlNueva.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.pnlNueva.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlNueva.Location = new System.Drawing.Point(20, 92);
            this.pnlNueva.Size = new System.Drawing.Size(960, 340);
            this.pnlNueva.Name = "pnlNueva";
            this.pnlNueva.TabIndex = 4;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(70, 80, 100);
            this.lblCliente.Location = new System.Drawing.Point(15, 12);
            this.lblCliente.Text = "Cliente";
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.TabIndex = 5;
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(15, 35);
            this.cboCliente.Size = new System.Drawing.Size(230, 28);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.TabIndex = 6;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.ForeColor = System.Drawing.Color.FromArgb(70, 80, 100);
            this.lblVendedor.Location = new System.Drawing.Point(265, 12);
            this.lblVendedor.Text = "Vendedor";
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.TabIndex = 7;
            // 
            // cboVendedor
            // 
            this.cboVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendedor.FormattingEnabled = true;
            this.cboVendedor.Location = new System.Drawing.Point(265, 35);
            this.cboVendedor.Size = new System.Drawing.Size(230, 28);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.TabIndex = 8;
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.ForeColor = System.Drawing.Color.FromArgb(70, 80, 100);
            this.lblPago.Location = new System.Drawing.Point(515, 12);
            this.lblPago.Text = "Método de pago";
            this.lblPago.Name = "lblPago";
            this.lblPago.TabIndex = 9;
            // 
            // cboPago
            // 
            this.cboPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPago.FormattingEnabled = true;
            this.cboPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencia" });
            this.cboPago.Location = new System.Drawing.Point(515, 35);
            this.cboPago.Size = new System.Drawing.Size(170, 28);
            this.cboPago.Name = "cboPago";
            this.cboPago.TabIndex = 10;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.ForeColor = System.Drawing.Color.FromArgb(70, 80, 100);
            this.lblDescuento.Location = new System.Drawing.Point(705, 12);
            this.lblDescuento.Text = "Descuento (%)";
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.TabIndex = 11;
            // 
            // txtDescuento
            // 
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescuento.Location = new System.Drawing.Point(705, 35);
            this.txtDescuento.Size = new System.Drawing.Size(100, 27);
            this.txtDescuento.Text = "0";
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.TabIndex = 12;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.ForeColor = System.Drawing.Color.FromArgb(70, 80, 100);
            this.lblProducto.Location = new System.Drawing.Point(15, 80);
            this.lblProducto.Text = "Producto";
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.TabIndex = 13;
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(15, 103);
            this.cboProducto.Size = new System.Drawing.Size(330, 28);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.TabIndex = 14;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(70, 80, 100);
            this.lblCantidad.Location = new System.Drawing.Point(365, 80);
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.TabIndex = 15;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(365, 103);
            this.nudCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0});
            this.nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0});
            this.nudCantidad.Size = new System.Drawing.Size(80, 27);
            this.nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.TabIndex = 16;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnAgregar.Location = new System.Drawing.Point(465, 100);
            this.btnAgregar.Size = new System.Drawing.Size(110, 32);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(110, 122, 135);
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuitar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnQuitar.Location = new System.Drawing.Point(585, 100);
            this.btnQuitar.Size = new System.Drawing.Size(110, 32);
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.TabIndex = 18;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // dgvDetalle
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(40, 50, 70);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(207, 226, 250);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(20, 30, 50);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalle.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AllowUserToResizeRows = false;
            this.dgvDetalle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalle.ColumnHeadersHeight = 36;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetalle.EnableHeadersVisualStyles = false;
            this.dgvDetalle.GridColor = System.Drawing.Color.FromArgb(225, 230, 238);
            this.dgvDetalle.Location = new System.Drawing.Point(15, 150);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.RowTemplate.Height = 28;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(640, 175);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.TabIndex = 19;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(70, 80, 100);
            this.lblSubtotal.Location = new System.Drawing.Point(680, 155);
            this.lblSubtotal.Text = "Subtotal: 0.00";
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.TabIndex = 20;
            // 
            // lblDescuentoMonto
            // 
            this.lblDescuentoMonto.AutoSize = true;
            this.lblDescuentoMonto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDescuentoMonto.ForeColor = System.Drawing.Color.FromArgb(70, 80, 100);
            this.lblDescuentoMonto.Location = new System.Drawing.Point(680, 185);
            this.lblDescuentoMonto.Text = "Descuento: 0.00";
            this.lblDescuentoMonto.Name = "lblDescuentoMonto";
            this.lblDescuentoMonto.TabIndex = 21;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblTotal.Location = new System.Drawing.Point(680, 215);
            this.lblTotal.Text = "Total: 0.00";
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.TabIndex = 22;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnRegistrar.Location = new System.Drawing.Point(680, 268);
            this.btnRegistrar.Size = new System.Drawing.Size(265, 50);
            this.btnRegistrar.Text = "Registrar venta";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.TabIndex = 23;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHistorial.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblHistorial.Location = new System.Drawing.Point(20, 448);
            this.lblHistorial.Text = "Ventas registradas";
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.TabIndex = 24;
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnCancelarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarVenta.FlatAppearance.BorderSize = 0;
            this.btnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarVenta.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnCancelarVenta.Location = new System.Drawing.Point(840, 442);
            this.btnCancelarVenta.Size = new System.Drawing.Size(140, 34);
            this.btnCancelarVenta.Text = "Cancelar venta";
            this.btnCancelarVenta.UseVisualStyleBackColor = false;
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.TabIndex = 25;
            this.btnCancelarVenta.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // dgvVentas
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(30, 58, 95);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(40, 50, 70);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(207, 226, 250);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(20, 30, 50);
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AllowUserToResizeRows = false;
            this.dgvVentas.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVentas.ColumnHeadersHeight = 36;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.GridColor = System.Drawing.Color.FromArgb(225, 230, 238);
            this.dgvVentas.Location = new System.Drawing.Point(20, 485);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.RowTemplate.Height = 28;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(960, 235);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.TabIndex = 26;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(240, 243, 248);
            this.ClientSize = new System.Drawing.Size(1000, 740);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlNueva);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.dgvVentas);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de Ventas";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlNueva.ResumeLayout(false);
            this.pnlNueva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlNueva;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.ComboBox cboVendedor;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.ComboBox cboPago;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDescuentoMonto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.DataGridView dgvVentas;
    }
}
