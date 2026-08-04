namespace SGA.Desktop.Modulos.RutaHorarios
{
    partial class FrmNuevoHorario
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.lblDiasOperacion = new System.Windows.Forms.Label();
            this.cmbDiasOperacion = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(15, 33, 55);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(380, 60);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(182, 21);
            this.lblTitulo.Text = "Agregar Nuevo Horario";

            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblHoraSalida.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblHoraSalida.Location = new System.Drawing.Point(25, 80);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(102, 17);
            this.lblHoraSalida.Text = "Hora de Salida:";

            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.CustomFormat = "hh:mm tt";
            this.dtpHoraSalida.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraSalida.ShowUpDown = true;
            this.dtpHoraSalida.Location = new System.Drawing.Point(28, 105);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.Size = new System.Drawing.Size(320, 25);
            this.dtpHoraSalida.TabIndex = 1;

            // 
            // lblDiasOperacion
            // 
            this.lblDiasOperacion.AutoSize = true;
            this.lblDiasOperacion.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDiasOperacion.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblDiasOperacion.Location = new System.Drawing.Point(25, 145);
            this.lblDiasOperacion.Name = "lblDiasOperacion";
            this.lblDiasOperacion.Size = new System.Drawing.Size(127, 17);
            this.lblDiasOperacion.Text = "Días de Operación:";

            // 
            // cmbDiasOperacion
            // 
            this.cmbDiasOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiasOperacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDiasOperacion.FormattingEnabled = true;
            this.cmbDiasOperacion.Items.AddRange(new object[] {
            "Lunes a Viernes",
            "Sábados y Domingos",
            "Diario (Lunes a Domingo)",
            "Lunes a Sábado"});
            this.cmbDiasOperacion.Location = new System.Drawing.Point(28, 170);
            this.cmbDiasOperacion.Name = "cmbDiasOperacion";
            this.cmbDiasOperacion.Size = new System.Drawing.Size(320, 25);
            this.cmbDiasOperacion.TabIndex = 2;

            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(140, 220);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 35);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(248, 220);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // 
            // FrmNuevoHorario
            // 
            this.ClientSize = new System.Drawing.Size(380, 280);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbDiasOperacion);
            this.Controls.Add(this.lblDiasOperacion);
            this.Controls.Add(this.dtpHoraSalida);
            this.Controls.Add(this.lblHoraSalida);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SGA - Nuevo Horario";
            this.Load += new System.EventHandler(this.FrmNuevoHorario_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.Label lblDiasOperacion;
        private System.Windows.Forms.ComboBox cmbDiasOperacion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}