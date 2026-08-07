namespace SGA.Web.Models.Pago
{
    public class ParadaCompraViewModel
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Ubicacion { get; set; } = string.Empty;

        public int Orden { get; set; }
    }
}
