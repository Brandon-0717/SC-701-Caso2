
namespace Abstracciones.Modelos
{
    public class OrdenDetalle
    {
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }

    public class OrdenDetalleRequest : OrdenDetalle
    {
        public Guid OrdenIdFk { get; set; }
        public Guid ProductoIdFk { get; set; }
    
    }

    public class OrdenDetalleResponse : OrdenDetalle
    {
        public Guid OrdenIdFk { get; set; }
        public Guid ProductoIdFk { get; set; }
    }
}
