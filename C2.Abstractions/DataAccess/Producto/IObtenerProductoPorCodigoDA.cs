
using C2.Abstractions.Models.DAModels;

namespace C2.Abstractions.DataAccess.Producto
{
    public interface IObtenerProductoPorCodigoDA
    {
        Task<ProductoDA?> ObtenerPorCodigo(string codigoProducto);
    }
}
