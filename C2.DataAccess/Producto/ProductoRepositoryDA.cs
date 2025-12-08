
using C2.Abstractions.DataAccess.Producto;
using C2.Abstractions.Models.DAModels;
using C2.Abstractions.Models.DTOModels;
using Microsoft.EntityFrameworkCore;

namespace C2.DataAccess.Producto
{
    public class ProductoRepositoryDA : IProductoRepositoryDA
    {
        private readonly Context _context;

        public ProductoRepositoryDA(Context context)
        {
            _context = context;
        }

        public async Task<List<ProductoDA>> Listar()
        {
            return await _context.Productos.ToListAsync();
        }

        public async Task<ProductoDA?> Crear(ProductoDA producto)
        {
            _context.Productos.Add(producto);
            var datosAfectado = await _context.SaveChangesAsync();
            return datosAfectado > 0 ? producto : null;
        }

        public async Task<bool> Modificar(ProductoDA producto)
        { 
            var productoExistente = await _context.Productos.FirstOrDefaultAsync(p => p.CodigoProducto == producto.CodigoProducto);
            if (productoExistente == null)
            {
                return false;
            }

            productoExistente.CodigoProducto = producto.CodigoProducto;
            productoExistente.Nombre = producto.Nombre;
            productoExistente.Descripcion = producto.Descripcion;
            productoExistente.Cantidad = producto.Cantidad;
            productoExistente.Precio = producto.Precio;
            productoExistente.Estado = producto.Estado;
            productoExistente.Marca = producto.Marca;
            productoExistente.FechaIngreso = producto.FechaIngreso;

            _context.Productos.Update(productoExistente);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> ActualizarStock(string codigoProducto, int cantidad)
        {
            var producto = _context.Productos.FirstOrDefault(p => p.CodigoProducto == codigoProducto);
            if (producto == null)
            {
                return false;
            }

            producto.Cantidad = cantidad;
            _context.Productos.Update(producto);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
