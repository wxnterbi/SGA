using SGA.Application.Dtos.Autobus;
using SGA.Presentation.Desktop.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http.HttpResults;

namespace SGA.Presentation.Desktop.Forms.Autobus
{
    public partial class FrmAutobusPrincipal : Form
    {

        private readonly IAutobusApiService _autobusApiService;

        private List<AutobusDto> _autobuses = new();

        public FrmAutobusPrincipal(
            IAutobusApiService autobusApiService)
        {
            InitializeComponent();


            _autobusApiService = autobusApiService;
            

            Load += FrmAutobusPrincipal_Load;


            btnNuevoAutobus.Click += btnNuevoAutobus_Click;

            btnDetalle.Click += btnDetalle_Click;

            btnEditar.Click += btnEditar_Click;

            btnEliminar.Click += btnEliminar_Click;

        }
        private async void FrmAutobusPrincipal_Load(
            object sender,
            EventArgs e)
        {
            await CargarAutobuses();
        }

        private async Task CargarAutobuses()
        {

            try
            {

                _autobuses =
                    await _autobusApiService.GetAllAsync();

                dgvAutobuses.DataSource = null;


                dgvAutobuses.DataSource =
                    _autobuses.Select(a => new
                    {

                        a.Id,

                        a.Placa,

                        a.Marca,

                        a.Modelo,

                        Capacidad = a.Capacidad,

                        Estado = a.EstadoDescripcion


                    }).ToList();

                ConfigurarGrid();

            }

            catch (Exception ex)
            {

                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }

        }


        private void ConfigurarGrid()
        {

            dgvAutobuses.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;



            dgvAutobuses.Columns["Id"]
                .HeaderText = "ID";


            dgvAutobuses.Columns["Placa"]
                .HeaderText = "Placa";


            dgvAutobuses.Columns["Marca"]
                .HeaderText = "Marca";


            dgvAutobuses.Columns["Modelo"]
                .HeaderText = "Modelo";


            dgvAutobuses.Columns["Capacidad"]
                .HeaderText = "Capacidad";


            dgvAutobuses.Columns["Estado"]
                .HeaderText = "Estado";



            dgvAutobuses.ClearSelection();

        }

        private void btnNuevoAutobus_Click(
            object sender,
            EventArgs e)
        {

            var formulario =
                Program.ServiceProvider
                .GetRequiredService<FrmNuevoAutobus>();


            if (formulario.ShowDialog() == DialogResult.OK)
            {
                _ = CargarAutobuses();
            }

        }

        private void btnDetalle_Click(
    object sender,
    EventArgs e)
        {
            if (dgvAutobuses.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un autobús para ver el detalle.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }


            int id = Convert.ToInt32(
                dgvAutobuses.CurrentRow.Cells["Id"].Value
            );


            var autobus = _autobuses
                .FirstOrDefault(a => a.Id == id);


            if (autobus == null)
            {
                MessageBox.Show(
                    "No se encontró la información del autobús.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }


            using var formulario =
                new FrmDetalleAutobus(autobus);


            formulario.ShowDialog();
        }

        private void btnEditar_Click(
            object sender,
            EventArgs e)
        {

            MessageBox.Show(
                "Editar autobús próximamente.");

        }

        private void btnEliminar_Click(
            object sender,
            EventArgs e)
        {

            MessageBox.Show(
                "Eliminar autobús próximamente.");

        }


    }
}