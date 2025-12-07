
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C2.Abstractions.Models.DAModels
{
    [Table("PRODUCTO")]
    public class ProductoDA
    {
        [Key]
        [Column("PRODUCTO_PK")]
        public Guid ProductoPK { get; set; }

        [Column("Codigo_Producto")]
        public string CodigoProducto { get; set; }

        [Column("Nombre")]
        public string Nombre { get; set; }

        [Column("Descripcion")]
        public string Descripcion { get; set; }

        [Column("Cantidad")]
        public int Cantidad { get; set; }

        [Column("Precio")]
        public decimal Precio { get; set; }

        [Column("Estado")]
        public bool Estado { get; set; }

        [Column("Marca")]
        public string Marca { get; set; }
        
        [Column("Fecha_Ingreso")]
        public DateTime FechaIngreso { get; set; }
    }
}
