namespace SGA.Desktop.Modulos.Viaje
{
    partial class FrmNuevoViajeModal
    {
        private System.ComponentModel.IContainer components = null;

        // Controles de la Interfaz
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTituloModal;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlBody;

        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.ComboBox cmbRuta;

        private System.Windows.Forms.Label lblAutobus;
        private System.Windows.Forms.ComboBox cmbAutobus;

        private System.Windows.Forms.Label lblConductor;
        private System.Windows.Forms.ComboBox cmbConductor;

        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.ComboBox cmbHorario;

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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTituloModal = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblRuta = new System.Windows.Forms.Label();
            this.cmbRuta = new System.Windows.Forms.ComboBox();
            this.lblAutobus = new System.Windows.Forms.Label();
            this.cmbAutobus = new System.Windows.Forms.ComboBox();
            this.lblConductor = new System.Windows.Forms.Label();
            this.cmbConductor = new System.Windows.Forms.ComboBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.cmbHorario = new System.Windows.Forms.ComboBox();

            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.pnlHeader.Controls.Add(this.lblTituloModal);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(480, 60);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblTituloModal
            // 
            this.lblTituloModal.AutoSize = true;
            this.lblTituloModal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloModal.ForeColor = System.Drawing.Color.White;
            this.lblTituloModal.Location = new System.Drawing.Point(20, 18);
            this.lblTituloModal.Name = "lblTituloModal";
            this.lblTituloModal.Size = new System.Drawing.Size(210, 21);
            this.lblTituloModal.Text = "PROGRAMAR NUEVO VIAJE";

            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlFooter.Controls.Add(this.btnGuardar);
            this.pnlFooter.Controls.Add(this.btnCancelar);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 370);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(480, 60);
            this.pnlFooter.TabIndex = 1;

            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(250, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(360, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 35);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.lblRuta);
            this.pnlBody.Controls.Add(this.cmbRuta);
            this.pnlBody.Controls.Add(this.lblHorario);
            this.pnlBody.Controls.Add(this.cmbHorario);
            this.pnlBody.Controls.Add(this.lblAutobus);
            this.pnlBody.Controls.Add(this.cmbAutobus);
            this.pnlBody.Controls.Add(this.lblConductor);
            this.pnlBody.Controls.Add(this.cmbConductor);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 60);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(20);
            this.pnlBody.Size = new System.Drawing.Size(480, 310);
            this.pnlBody.TabIndex = 2;

            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblRuta.Location = new System.Drawing.Point(20, 15);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(111, 15);
            this.lblRuta.Text = "Ruta Asignada:";

            // 
            // cmbRuta
            // 
            this.cmbRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRuta.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbRuta.FormattingEnabled = true;
            this.cmbRuta.Location = new System.Drawing.Point(20, 35);
            this.cmbRuta.Name = "cmbRuta";
            this.cmbRuta.Size = new System.Drawing.Size(440, 25);
            this.cmbRuta.TabIndex = 0;

            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblHorario.Location = new System.Drawing.Point(20, 85);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(126, 15);
            this.lblHorario.Text = "Horario de Salida:";

            // 
            // cmbHorario
            // 
            this.cmbHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorario.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Location = new System.Drawing.Point(20, 105);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(440, 25);
            this.cmbHorario.TabIndex = 1;

            // 
            // lblAutobus
            // 
            this.lblAutobus.AutoSize = true;
            this.lblAutobus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAutobus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblAutobus.Location = new System.Drawing.Point(20, 155);
            this.lblAutobus.Name = "lblAutobus";
            this.lblAutobus.Size = new System.Drawing.Size(123, 15);
            this.lblAutobus.Text = "Autobús Asignado:";

            // 
            // cmbAutobus
            // 
            this.cmbAutobus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutobus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbAutobus.FormattingEnabled = true;
            this.cmbAutobus.Location = new System.Drawing.Point(20, 175);
            this.cmbAutobus.Name = "cmbAutobus";
            this.cmbAutobus.Size = new System.Drawing.Size(440, 25);
            this.cmbAutobus.TabIndex = 2;

            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConductor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblConductor.Location = new System.Drawing.Point(20, 225);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(133, 15);
            this.lblConductor.Text = "Conductor Asignado:";

            // 
            // cmbConductor
            // 
            this.cmbConductor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConductor.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbConductor.FormattingEnabled = true;
            this.cmbConductor.Location = new System.Drawing.Point(20, 245);
            this.cmbConductor.Name = "cmbConductor";
            this.cmbConductor.Size = new System.Drawing.Size(440, 25);
            this.cmbConductor.TabIndex = 3;

            // 
            // FrmNuevoViajeModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 430);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevoViajeModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Programar Nuevo Viaje";
            this.Load += new System.EventHandler(this.FrmNuevoViajeModal_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}