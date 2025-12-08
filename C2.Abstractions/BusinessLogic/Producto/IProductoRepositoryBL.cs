
using C2.Abstractions.Modelos;
using C2.Abstractions.Models.DTOModels;

namespace C2.Abstractions.BusinessLogic.Producto
{
    public interface IProductoRepositoryBL
    {
        Task<CustomResponse<List<ProductoDTO>>> Listar();
        Task<CustomResponse<ProductoDTO>> Crear(ProductoDTO producto);
        Task<CustomResponse<ProductoDTO>> ObtenerProductoPorCodigo(string codigoProducto);
        Task<CustomResponse<ProductoDTO>> Modificar(ProductoDTO producto);
        Task<CustomResponse<ProductoDTO>> ActualizarStock(string codigoProducto, int cantidad);
        Task<CustomResponse<int>> VerificarStock(string codigoProducto);
    }
}
