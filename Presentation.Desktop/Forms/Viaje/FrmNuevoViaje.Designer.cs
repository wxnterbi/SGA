namespace SGA.Presentation.Desktop.Forms.Viaje
{
    partial class FrmNuevoViaje
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;
        private Label lblRuta;
        private Label lblHorario;
        private Label lblAutobus;
        private Label lblConductor;
        private Label lblEstado;

        private ComboBox cmbRuta;
        private ComboBox cmbHorario;
        private ComboBox cmbAutobus;
        private ComboBox cmbConductor;
        private ComboBox cmbEstado;

        private Button btnGuardar;
        private Button btnCancelar;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }



        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblRuta = new Label();
            lblHorario = new Label();
            lblAutobus = new Label();
            lblConductor = new Label();
            lblEstado = new Label();
            cmbRuta = new ComboBox();
            cmbHorario = new ComboBox();
            cmbAutobus = new ComboBox();
            cmbConductor = new ComboBox();
            cmbEstado = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(183, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(205, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar Viaje";
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Location = new Point(80, 133);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(42, 20);
            lblRuta.TabIndex = 1;
            lblRuta.Text = "Ruta:";
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Location = new Point(80, 200);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(63, 20);
            lblHorario.TabIndex = 3;
            lblHorario.Text = "Horario:";
            // 
            // lblAutobus
            // 
            lblAutobus.AutoSize = true;
            lblAutobus.Location = new Point(80, 267);
            lblAutobus.Name = "lblAutobus";
            lblAutobus.Size = new Size(67, 20);
            lblAutobus.TabIndex = 5;
            lblAutobus.Text = "Autobús:";
            // 
            // lblConductor
            // 
            lblConductor.AutoSize = true;
            lblConductor.Location = new Point(80, 333);
            lblConductor.Name = "lblConductor";
            lblConductor.Size = new Size(81, 20);
            lblConductor.TabIndex = 7;
            lblConductor.Text = "Conductor:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(80, 400);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 20);
            lblEstado.TabIndex = 9;
            lblEstado.Text = "Estado:";
            // 
            // cmbRuta
            // 
            cmbRuta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRuta.Location = new Point(194, 127);
            cmbRuta.Margin = new Padding(3, 4, 3, 4);
            cmbRuta.Name = "cmbRuta";
            cmbRuta.Size = new Size(285, 28);
            cmbRuta.TabIndex = 2;
            // 
            // cmbHorario
            // 
            cmbHorario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHorario.Location = new Point(194, 193);
            cmbHorario.Margin = new Padding(3, 4, 3, 4);
            cmbHorario.Name = "cmbHorario";
            cmbHorario.Size = new Size(285, 28);
            cmbHorario.TabIndex = 4;
            // 
            // cmbAutobus
            // 
            cmbAutobus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAutobus.Location = new Point(194, 260);
            cmbAutobus.Margin = new Padding(3, 4, 3, 4);
            cmbAutobus.Name = "cmbAutobus";
            cmbAutobus.Size = new Size(285, 28);
            cmbAutobus.TabIndex = 6;
            // 
            // cmbConductor
            // 
            cmbConductor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConductor.Location = new Point(194, 327);
            cmbConductor.Margin = new Padding(3, 4, 3, 4);
            cmbConductor.Name = "cmbConductor";
            cmbConductor.Size = new Size(285, 28);
            cmbConductor.TabIndex = 8;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Location = new Point(194, 393);
            cmbEstado.Margin = new Padding(3, 4, 3, 4);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(285, 28);
            cmbEstado.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(171, 507);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(103, 47);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(297, 507);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 47);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmNuevoViaje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 693);
            Controls.Add(lblTitulo);
            Controls.Add(lblRuta);
            Controls.Add(cmbRuta);
            Controls.Add(lblHorario);
            Controls.Add(cmbHorario);
            Controls.Add(lblAutobus);
            Controls.Add(cmbAutobus);
            Controls.Add(lblConductor);
            Controls.Add(cmbConductor);
            Controls.Add(lblEstado);
            Controls.Add(cmbEstado);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmNuevoViaje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Viaje";
            Load += FrmNuevoViaje_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}