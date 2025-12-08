
using System.ComponentModel.DataAnnotations;

namespace C2.Abstractions.Models.DTOModels
{
    public class ProductoDTO
    {
        public Guid ProductoPK { get; set; }

        [Required(ErrorMessage = "El codigo del producto es requerido")]
        [StringLength(50, ErrorMessage = "El código no puede tener mas de 50 caracteres.")]
        [Display(Name = "Código Producto")]
        public string CodigoProducto { get; set; }

        [Required(ErrorMessage = "El nombre del producto es requerido")]
        [StringLength(50, ErrorMessage = "El nombre no puede tener mas de 50 caracteres.")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La descripción del producto es requerida")]
        [StringLength(300, ErrorMessage = "La descripción no puede tener mas de 200 caracteres.")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La cantidad del producto es requerida")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser al menos 1.")]
        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "El precio del producto es requerido")]
        [Range(1, double.MaxValue, ErrorMessage = "El precio no puede ser menor a 1.")]
        [Display(Name = "Precio")]
        public decimal Precio { get; set; }

        [Display(Name = "Estado")]
        public bool Estado { get; set; }

        [Required(ErrorMessage = "La marca del producto es requerida")]
        [StringLength(50, ErrorMessage = "La marca no puede tener mas de 50 caracteres.")]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "La fecha de ingreso del producto es requerida")]
        [Display(Name = "Fecha de Ingreso")]
        public DateTime FechaIngreso { get; set; }
    }
}
