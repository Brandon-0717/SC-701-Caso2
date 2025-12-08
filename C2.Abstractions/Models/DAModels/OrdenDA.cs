
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C2.Abstractions.Models.DAModels
{
    [Table("ORDEN")]
    public class OrdenDA
    {
        [Key]
        [Column("ORDEN_PK")]
        public Guid OrdenDetallePK { get; set; }

        [Column("Fecha")]
        public DateTime Fecha { get; set; }

        [Column("Total")]
        public decimal Total { get; set; }
    }
}
