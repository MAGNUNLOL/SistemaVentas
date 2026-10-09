namespace SistemaVentas.Formularios
{
    partial class FrmReportes
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
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblResumen = new System.Windows.Forms.Label();
            this.lblTituloVentas = new System.Windows.Forms.Label();
            this.lblTituloProductos = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
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
            this.lblTitulo.Text = "Reportes del Sistema";
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 2;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(190, 208, 230);
            this.lblSubtitulo.Location = new System.Drawing.Point(25, 46);
            this.lblSubtitulo.Text = "Ventas por período, productos más vendidos e ingresos";
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 3;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.lblDesde);
            this.pnlFiltro.Controls.Add(this.dtpDesde);
            this.pnlFiltro.Controls.Add(this.lblHasta);
            this.pnlFiltro.Controls.Add(this.dtpHasta);
            this.pnlFiltro.Controls.Add(this.btnGenerar);
            this.pnlFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.pnlFiltro.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlFiltro.Location = new System.Drawing.Point(20, 92);
            this.pnlFiltro.Size = new System.Drawing.Size(960, 66);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.TabIndex = 4;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(70, 80, 100);
            this.lblDesde.Location = new System.Drawing.Point(15, 22);
            this.lblDesde.Text = "Desde:";
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.TabIndex = 5;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(75, 18);
            this.dtpDesde.Size = new System.Drawing.Size(140, 27);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.TabIndex = 6;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(70, 80, 100);
            this.lblHasta.Location = new System.Drawing.Point(240, 22);
            this.lblHasta.Text = "Hasta:";
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.TabIndex = 7;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(300, 18);
            this.dtpHasta.Size = new System.Drawing.Size(140, 27);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.TabIndex = 8;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnGenerar.Location = new System.Drawing.Point(470, 14);
            this.btnGenerar.Size = new System.Drawing.Size(150, 36);
            this.btnGenerar.Text = "Generar reporte";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResumen.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblResumen.Location = new System.Drawing.Point(20, 172);
            this.lblResumen.Text = "Ventas: 0     Ingresos: 0.00";
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.TabIndex = 10;
            // 
            // lblTituloVentas
            // 
            this.lblTituloVentas.AutoSize = true;
            this.lblTituloVentas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloVentas.ForeColor = System.Drawing.Color.FromArgb(70, 80, 100);
            this.lblTituloVentas.Location = new System.Drawing.Point(20, 208);
            this.lblTituloVentas.Text = "Ventas del período";
            this.lblTituloVentas.Name = "lblTituloVentas";
            this.lblTituloVentas.TabIndex = 11;
            // 
            // lblTituloProductos
            // 
            this.lblTituloProductos.AutoSize = true;
            this.lblTituloProductos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloProductos.ForeColor = System.Drawing.Color.FromArgb(70, 80, 100);
            this.lblTituloProductos.Location = new System.Drawing.Point(600, 208);
            this.lblTituloProductos.Text = "Productos más vendidos";
            this.lblTituloProductos.Name = "lblTituloProductos";
            this.lblTituloProductos.TabIndex = 12;
            // 
            // dgvVentas
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
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AllowUserToResizeRows = false;
            this.dgvVentas.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVentas.ColumnHeadersHeight = 36;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.GridColor = System.Drawing.Color.FromArgb(225, 230, 238);
            this.dgvVentas.Location = new System.Drawing.Point(20, 236);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.RowTemplate.Height = 28;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(560, 384);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.TabIndex = 13;
            // 
            // dgvProductos
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
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductos.ColumnHeadersHeight = 36;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(225, 230, 238);
            this.dgvProductos.Location = new System.Drawing.Point(600, 236);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(380, 384);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.TabIndex = 14;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(240, 243, 248);
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFiltro);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.lblTituloVentas);
            this.Controls.Add(this.lblTituloProductos);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.dgvProductos);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FrmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reportes del Sistema";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Label lblTituloVentas;
        private System.Windows.Forms.Label lblTituloProductos;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}
