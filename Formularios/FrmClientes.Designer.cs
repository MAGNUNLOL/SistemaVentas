namespace SistemaVentas.Formularios
{
    partial class FrmClientes
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
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(940, 76);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblTitulo.Location = new System.Drawing.Point(22, 10);
            this.lblTitulo.Text = "Gestión de Clientes";
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 2;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(190, 208, 230);
            this.lblSubtitulo.Location = new System.Drawing.Point(25, 46);
            this.lblSubtitulo.Text = "Registro, actualización, consulta e historial de compras";
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.TabIndex = 3;
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.lblId);
            this.pnlDatos.Controls.Add(this.txtId);
            this.pnlDatos.Controls.Add(this.lblNombre);
            this.pnlDatos.Controls.Add(this.txtNombre);
            this.pnlDatos.Controls.Add(this.lblTelefono);
            this.pnlDatos.Controls.Add(this.txtTelefono);
            this.pnlDatos.Controls.Add(this.lblEmail);
            this.pnlDatos.Controls.Add(this.txtEmail);
            this.pnlDatos.Controls.Add(this.btnGuardar);
            this.pnlDatos.Controls.Add(this.btnNuevo);
            this.pnlDatos.Controls.Add(this.btnEliminar);
            this.pnlDatos.Controls.Add(this.btnHistorial);
            this.pnlDatos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.pnlDatos.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.pnlDatos.Location = new System.Drawing.Point(20, 92);
            this.pnlDatos.Size = new System.Drawing.Size(360, 391);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(70, 80, 100);
            this.lblId.Location = new System.Drawing.Point(20, 15);
            this.lblId.Text = "ID";
            this.lblId.Name = "lblId";
            this.lblId.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Location = new System.Drawing.Point(20, 38);
            this.txtId.PlaceholderText = "Automático";
            this.txtId.ReadOnly = true;
            this.txtId.BackColor = System.Drawing.Color.FromArgb(236, 239, 244);
            this.txtId.Size = new System.Drawing.Size(320, 27);
            this.txtId.Name = "txtId";
            this.txtId.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(70, 80, 100);
            this.lblNombre.Location = new System.Drawing.Point(20, 80);
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(20, 103);
            this.txtNombre.Size = new System.Drawing.Size(320, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.TabIndex = 8;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(70, 80, 100);
            this.lblTelefono.Location = new System.Drawing.Point(20, 145);
            this.lblTelefono.Text = "Teléfono";
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Location = new System.Drawing.Point(20, 168);
            this.txtTelefono.Size = new System.Drawing.Size(320, 27);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(70, 80, 100);
            this.lblEmail.Location = new System.Drawing.Point(20, 210);
            this.lblEmail.Text = "Correo electrónico";
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(20, 233);
            this.txtEmail.Size = new System.Drawing.Size(320, 27);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnGuardar.Location = new System.Drawing.Point(20, 285);
            this.btnGuardar.Size = new System.Drawing.Size(100, 38);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(110, 122, 135);
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnNuevo.Location = new System.Drawing.Point(130, 285);
            this.btnNuevo.Size = new System.Drawing.Size(100, 38);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnEliminar.Location = new System.Drawing.Point(240, 285);
            this.btnEliminar.Size = new System.Drawing.Size(100, 38);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHistorial.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnHistorial.Location = new System.Drawing.Point(20, 333);
            this.btnHistorial.Size = new System.Drawing.Size(320, 38);
            this.btnHistorial.Text = "Ver historial de compras";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.TabIndex = 16;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(400, 92);
            this.txtBuscar.PlaceholderText = "Buscar por nombre, teléfono o correo";
            this.txtBuscar.Size = new System.Drawing.Size(520, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.TabIndex = 17;
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
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
            this.dgv.Location = new System.Drawing.Point(400, 132);
            this.dgv.MultiSelect = false;
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(520, 488);
            this.dgv.Name = "dgv";
            this.dgv.TabIndex = 18;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(240, 243, 248);
            this.ClientSize = new System.Drawing.Size(940, 640);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de Clientes";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgv;
    }
}
