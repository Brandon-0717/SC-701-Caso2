
using C2.Abstractions.Modelos;
using C2.Abstractions.Models.DTOModels;

namespace C2.Abstractions.BusinessLogic.Producto
{
    public interface IListarProductosBL
    {
        Task<CustomResponse<List<ProductoDTO>>> Listar();
    }
}
