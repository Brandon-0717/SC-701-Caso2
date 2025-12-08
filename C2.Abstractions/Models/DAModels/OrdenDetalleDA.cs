
using System.ComponentModel.DataAnnotations.Schema;

namespace C2.Abstractions.Models.DAModels
{
    [Table("ORDEN_DETALLE")]
    public class OrdenDetalleDA
    {
        [Column("ORDEN_FK_ORDEN_DETALLE")]
        public Guid OrdenDetallePK { get; set; }

        [Column("PRODUCTO_FK_ORDEN_DETALLE")]
        public Guid ProductoFK { get; set; }

        [Column("Cantidad")]
        public int Cantidad { get; set; }

        [Column("Precio_Unitario")]
        public decimal PrecioUnitario { get; set; }

        [Column("Subtotal")]
        public decimal Subtotal { get; set; }

    }
}
