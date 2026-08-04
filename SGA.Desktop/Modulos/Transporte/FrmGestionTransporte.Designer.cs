namespace SGA.Desktop.Modulos.Transporte
{
    partial class FrmGestionTransporte
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

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            pnlAcciones = new Panel();
            btnRefrescar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnNuevoAutobus = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            pnlGridContainer = new Panel();
            dgvAutobuses = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlAcciones.SuspendLayout();
            pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAutobuses).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblSubtitulo);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1000, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9.5F);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(22, 42);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(366, 17);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Administra la flota vehicular de autobuses y su disponibilidad";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(15, 33, 55);
            lblTitulo.Location = new Point(20, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(239, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Autobuses";
            // 
            // pnlAcciones
            // 
            pnlAcciones.BackColor = Color.FromArgb(248, 249, 250);
            pnlAcciones.Controls.Add(btnRefrescar);
            pnlAcciones.Controls.Add(btnEliminar);
            pnlAcciones.Controls.Add(btnEditar);
            pnlAcciones.Controls.Add(btnNuevoAutobus);
            pnlAcciones.Controls.Add(txtBuscar);
            pnlAcciones.Controls.Add(lblBuscar);
            pnlAcciones.Dock = DockStyle.Top;
            pnlAcciones.Location = new Point(0, 70);
            pnlAcciones.Name = "pnlAcciones";
            pnlAcciones.Size = new Size(1000, 60);
            pnlAcciones.TabIndex = 1;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefrescar.BackColor = Color.FromArgb(108, 117, 125);
            btnRefrescar.FlatAppearance.BorderSize = 0;
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRefrescar.ForeColor = Color.White;
            btnRefrescar.Location = new Point(520, 12);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(95, 35);
            btnRefrescar.TabIndex = 5;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.BackColor = Color.FromArgb(220, 53, 69);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(625, 12);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(95, 35);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.BackColor = Color.FromArgb(0, 122, 255);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(730, 12);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(95, 35);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnNuevoAutobus
            // 
            btnNuevoAutobus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoAutobus.BackColor = Color.FromArgb(40, 167, 69);
            btnNuevoAutobus.FlatAppearance.BorderSize = 0;
            btnNuevoAutobus.FlatStyle = FlatStyle.Flat;
            btnNuevoAutobus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNuevoAutobus.ForeColor = Color.White;
            btnNuevoAutobus.Location = new Point(835, 12);
            btnNuevoAutobus.Name = "btnNuevoAutobus";
            btnNuevoAutobus.Size = new Size(145, 35);
            btnNuevoAutobus.TabIndex = 2;
            btnNuevoAutobus.Text = "+ Registrar Autobús";
            btnNuevoAutobus.UseVisualStyleBackColor = false;
            btnNuevoAutobus.Click += btnNuevoAutobus_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 10F);
            txtBuscar.Location = new Point(75, 17);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(250, 25);
            txtBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBuscar.ForeColor = Color.FromArgb(15, 33, 55);
            lblBuscar.Location = new Point(22, 22);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(0, 15);
            lblBuscar.TabIndex = 6;
            // 
            // pnlGridContainer
            // 
            pnlGridContainer.Controls.Add(dgvAutobuses);
            pnlGridContainer.Dock = DockStyle.Fill;
            pnlGridContainer.Location = new Point(0, 130);
            pnlGridContainer.Name = "pnlGridContainer";
            pnlGridContainer.Padding = new Padding(20);
            pnlGridContainer.Size = new Size(1000, 470);
            pnlGridContainer.TabIndex = 2;
            // 
            // dgvAutobuses
            // 
            dgvAutobuses.AllowUserToAddRows = false;
            dgvAutobuses.AllowUserToDeleteRows = false;
            dgvAutobuses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAutobuses.BackgroundColor = Color.White;
            dgvAutobuses.BorderStyle = BorderStyle.None;
            dgvAutobuses.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 33, 55);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(15, 33, 55);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvAutobuses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAutobuses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(220, 235, 252);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(15, 33, 55);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAutobuses.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAutobuses.Dock = DockStyle.Fill;
            dgvAutobuses.EnableHeadersVisualStyles = false;
            dgvAutobuses.Location = new Point(20, 20);
            dgvAutobuses.MultiSelect = false;
            dgvAutobuses.Name = "dgvAutobuses";
            dgvAutobuses.RowHeadersVisible = false;
            dgvAutobuses.RowTemplate.Height = 35;
            dgvAutobuses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAutobuses.Size = new Size(960, 430);
            dgvAutobuses.TabIndex = 0;
            // 
            // FrmGestionTransporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1000, 600);
            Controls.Add(pnlGridContainer);
            Controls.Add(pnlAcciones);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionTransporte";
            Text = "Gestión de Transporte";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlAcciones.ResumeLayout(false);
            pnlAcciones.PerformLayout();
            pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAutobuses).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnNuevoAutobus;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Panel pnlGridContainer;
        private System.Windows.Forms.DataGridView dgvAutobuses;
    }
}