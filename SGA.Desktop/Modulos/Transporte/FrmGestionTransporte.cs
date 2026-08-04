using Microsoft.Extensions.DependencyInjection;
using SGA.Desktop.Interfaces.Autobus;
using SGA.Desktop.Modulos.Transporte;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGA.Desktop.Modulos.Transporte
{
    public partial class FrmGestionTransporte : Form
    {
        private readonly IAutobusApiService _autobusApiService;
        private readonly IServiceProvider _serviceProvider;

        public FrmGestionTransporte(IAutobusApiService autobusApiService = null, IServiceProvider serviceProvider = null)
        {
            InitializeComponent();

            _autobusApiService = autobusApiService ?? Program.ServiceProvider.GetRequiredService<IAutobusApiService>();
            _serviceProvider = serviceProvider ?? Program.ServiceProvider;

            this.Load += FrmGestionTransporte_Load;
        }

        private async void FrmGestionTransporte_Load(object sender, EventArgs e)
        {
            await CargarAutobusesAsync();
        }

        public async Task CargarAutobusesAsync()
        {
            try
            {
                var autobuses = await _autobusApiService.GetAllAsync();

                if (dgvAutobuses != null && autobuses != null)
                {
                    dgvAutobuses.DataSource = autobuses.ToList();
                    FormatearGrillaAutobuses();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el listado de autobuses desde la API:\n{ex.Message}",
                                "SGA ITLA",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void FormatearGrillaAutobuses()
        {
            // Ocultar ID de estado si existe
            if (dgvAutobuses.Columns.Contains("EstadoAutobusId"))
                dgvAutobuses.Columns["EstadoAutobusId"].Visible = false;

            // Nombres legibles en encabezados
            if (dgvAutobuses.Columns.Contains("EstadoDescripcion"))
                dgvAutobuses.Columns["EstadoDescripcion"].HeaderText = "Estado";

            if (dgvAutobuses.Columns.Contains("Capacidad"))
                dgvAutobuses.Columns["Capacidad"].HeaderText = "Capacidad";

            // Formato visual equilibrado
            dgvAutobuses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgvAutobuses.Columns.Contains("Id"))
            {
                dgvAutobuses.Columns["Id"].Width = 50;
                dgvAutobuses.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
        }

        private async void btnNuevoAutobus_Click(object sender, EventArgs e)
        {
            using (var modal = _serviceProvider.GetRequiredService<FrmNuevoAutobusModal>())
            {
                if (modal.ShowDialog() == DialogResult.OK)
                {
                    await CargarAutobusesAsync();
                }
            }
        }
    }
}