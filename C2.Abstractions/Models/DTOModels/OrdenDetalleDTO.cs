
namespace C2.Abstractions.Models.DTOModels
{
    public class OrdenDetalleDTO
    {
        public Guid OrdenDetallePK { get; set; }
        public Guid ProductoFK { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }
}
