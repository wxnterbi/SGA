using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using SGA.Application.Dtos.TarjetaRecargable;
using SGA.Application.Interfaces;

namespace SGA.Desktop.Modulos.Usuario
{
    public partial class FrmRecargarTarjetaModal : Form
    {
        private readonly int _usuarioId;
        private readonly ITarjetaRecargableService _tarjetaService;

        public FrmRecargarTarjetaModal(
            int usuarioId,
            string nombreUsuario,
            ITarjetaRecargableService tarjetaService = null)
        {
            InitializeComponent();
            _usuarioId = usuarioId;
            _tarjetaService = tarjetaService ?? Program.ServiceProvider.GetRequiredService<ITarjetaRecargableService>();

            lblNombreUsuario.Text = $"Usuario: {nombreUsuario}";
            btnConfirmar.Click += BtnConfirmar_Click;
            btnCancelar.Click += (s, e) => this.Close();
        }

        private async void BtnConfirmar_Click(object sender, EventArgs e)
        {
            decimal montoRecarga = numMonto.Value;

            if (montoRecarga <= 0)
            {
                MessageBox.Show("Ingrese un monto mayor a cero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var tarjetas = await _tarjetaService.GetAllAsync();
                var tarjeta = tarjetas.FirstOrDefault(t => t.UsuarioId == _usuarioId);

                if (tarjeta != null)
                {
                    // Sumamos el saldo y actualizamos
                    tarjeta.Saldo += montoRecarga;
                    await _tarjetaService.UpdateAsync(tarjeta);
                }
                else
                {
                    // Si el usuario no tenía registro de tarjeta previa, creamos una activa (Estado = 1)
                    var nuevaTarjeta = new TarjetaRecargableDto
                    {
                        UsuarioId = _usuarioId,
                        Saldo = montoRecarga,
                        Estado = 1
                    };
                    await _tarjetaService.AddAsync(nuevaTarjeta);
                }

                MessageBox.Show($"¡Recarga realizada con éxito!\nMonto acreditado: RD$ {montoRecarga:N2}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar la recarga: {ex.Message}", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}