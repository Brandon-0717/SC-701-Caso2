
using C2.Abstractions.Models.DAModels;

namespace C2.Abstractions.DataAccess.Producto
{
    public interface IListarProductosDA
    {
        Task<List<ProductoDA>> Listar();
    }
}
