
namespace Abstracciones.Modelos
{
    public class Producto
    {
        public string CodigoProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public bool Estado { get; set; }
        public string Marca { get; set; }
        public DateTime FechaIngreso { get; set; }
    }

    public class ProductoRequest : Producto
    {
        public Guid ProductoID { get; set; }
    }

    public class ProductoResponse
    {
        public Guid ProductoID { get; set; }
    }
}
