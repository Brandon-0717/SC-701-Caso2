
using Abstracciones.Modelos;

namespace Abstracciones.Interfaces.Flujo
{
    public interface IProductoFlujo
    {
        Task<IEnumerable<ProductoResponse>> Obtener();
        Task<ProductoResponse> Obtener(int id);
        Task<Guid> Crear(ProductoRequest producto);
        Task<Guid> Editar(int id, ProductoRequest producto);
        Task<Guid> Eliminar(int id);
    }
}
