namespace SistemaVentas.Formularios
{
    partial class FrmFacturas
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(900, 76);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblTitulo.Location = new System.Drawing.Point(22, 10);
            this.lblTitulo.Text = "Facturación y Anulaciones";
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 2;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(190, 208, 230);
            this.lblSubtitulo.Location = new System.Drawing.Point(25, 46);
            this.lblSubtitulo.Text = "Las facturas se generan solas al registrar una venta";
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 3;
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalle.FlatAppearance.BorderSize = 0;
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDetalle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnDetalle.Location = new System.Drawing.Point(20, 92);
            this.btnDetalle.Size = new System.Drawing.Size(150, 36);
            this.btnDetalle.Text = "Ver detalle";
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.TabIndex = 4;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnAnular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnular.FlatAppearance.BorderSize = 0;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnular.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnAnular.Location = new System.Drawing.Point(180, 92);
            this.btnAnular.Size = new System.Drawing.Size(150, 36);
            this.btnAnular.Text = "Anular factura";
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.TabIndex = 5;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // dgv
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
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersHeight = 36;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(225, 230, 238);
            this.dgv.Location = new System.Drawing.Point(20, 142);
            this.dgv.MultiSelect = false;
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(860, 438);
            this.dgv.Name = "dgv";
            this.dgv.TabIndex = 6;
            // 
            // FrmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(240, 243, 248);
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FrmFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Facturación y Anulaciones";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.DataGridView dgv;
    }
}
