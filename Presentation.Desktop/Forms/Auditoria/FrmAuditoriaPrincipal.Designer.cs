namespace SGA.Presentation.Desktop.Forms.Auditoria
{
    partial class FrmAuditoriaPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;

        private TextBox txtBuscarActor;
        private TextBox txtBuscarAccion;

        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnDetalles;

        private DataGridView dgvAuditorias;

        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            txtBuscarActor = new TextBox();
            txtBuscarAccion = new TextBox();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            btnDetalles = new Button();
            dgvAuditorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAuditorias).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(40, 40, 40);
            lblTitulo.Location = new Point(25, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(366, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE AUDITORÍA";
            // 
            // txtBuscarActor
            // 
            txtBuscarActor.Location = new Point(30, 85);
            txtBuscarActor.Name = "txtBuscarActor";
            txtBuscarActor.PlaceholderText = "Buscar actor...";
            txtBuscarActor.Size = new Size(250, 30);
            txtBuscarActor.TabIndex = 1;
            // 
            // txtBuscarAccion
            // 
            txtBuscarAccion.Location = new Point(300, 85);
            txtBuscarAccion.Name = "txtBuscarAccion";
            txtBuscarAccion.PlaceholderText = "Buscar acción...";
            txtBuscarAccion.Size = new Size(250, 30);
            txtBuscarAccion.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 120, 215);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(570, 82);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(95, 38);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Gray;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(680, 82);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(95, 38);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnDetalles
            // 
            btnDetalles.BackColor = Color.FromArgb(0, 120, 215);
            btnDetalles.FlatStyle = FlatStyle.Flat;
            btnDetalles.ForeColor = Color.White;
            btnDetalles.Location = new Point(30, 640);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(120, 42);
            btnDetalles.TabIndex = 6;
            btnDetalles.Text = "Detalles";
            btnDetalles.UseVisualStyleBackColor = false;
            // 
            // dgvAuditorias
            // 
            dgvAuditorias.AllowUserToAddRows = false;
            dgvAuditorias.AllowUserToDeleteRows = false;
            dgvAuditorias.AllowUserToResizeRows = false;
            dgvAuditorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAuditorias.BackgroundColor = Color.White;
            dgvAuditorias.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAuditorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAuditorias.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(210, 230, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAuditorias.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAuditorias.EnableHeadersVisualStyles = false;
            dgvAuditorias.Location = new Point(30, 145);
            dgvAuditorias.MultiSelect = false;
            dgvAuditorias.Name = "dgvAuditorias";
            dgvAuditorias.ReadOnly = true;
            dgvAuditorias.RowHeadersVisible = false;
            dgvAuditorias.RowHeadersWidth = 51;
            dgvAuditorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuditorias.Size = new Size(1100, 470);
            dgvAuditorias.TabIndex = 5;
            // 
            // FrmAuditoriaPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1180, 720);
            Controls.Add(lblTitulo);
            Controls.Add(txtBuscarActor);
            Controls.Add(txtBuscarAccion);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvAuditorias);
            Controls.Add(btnDetalles);
            Font = new Font("Segoe UI", 10F);
            Name = "FrmAuditoriaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Auditoría";
            Load += FrmAuditoriaPrincipal_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvAuditorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}