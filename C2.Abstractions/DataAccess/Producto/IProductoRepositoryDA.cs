
using C2.Abstractions.Models.DAModels;

namespace C2.Abstractions.DataAccess.Producto
{
    public interface IProductoRepositoryDA
    {
        Task<List<ProductoDA>> Listar();
        Task<ProductoDA?> Crear(ProductoDA producto);
        //EL VER DETALLES DE PRODUCTO SE HACE CON EL CODIGO DEL PRODUCTO, POR ELLO ES OTRA INTERFAZ
        Task<bool> Modificar(ProductoDA producto);
        Task<bool> ActualizarStock(string codigoProducto, int cantidad);

    }
}
