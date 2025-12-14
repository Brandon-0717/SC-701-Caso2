
namespace Abstracciones.Modelos
{
    public class Orden
    {
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
    }

    public class OrdenRequest : Orden
    {
        public Guid OrdenID { get; set; }
    }
  
    public class OrdenResponse : Orden
    {
        public Guid OrdenID { get; set; }
    }
}
