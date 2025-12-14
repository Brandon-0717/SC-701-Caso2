
using Abstracciones.Modelos;

namespace Abstracciones.Interfaces.DA
{
    public interface IProductoDA
    {
        Task<IEnumerable<ProductoResponse>> Obtener();
        Task<ProductoResponse> Obtener(int id);
        Task<Guid>Crear(ProductoRequest producto);
        Task<Guid>Editar(int id, ProductoRequest producto);
        Task<Guid>Eliminar(int id);
    }
}
