
using C2.Abstractions.DataAccess.Producto;
using C2.Abstractions.Models.DAModels;
using Microsoft.EntityFrameworkCore;

namespace C2.DataAccess.Producto
{
    public class ObtenerProductoPorCodigoDA : IObtenerProductoPorCodigoDA
    {
        private readonly Context _context;
        public ObtenerProductoPorCodigoDA(Context context)
        {
            _context = context;
        }

        public async Task<ProductoDA?> ObtenerPorCodigo(string codigoProducto)
        {
            return await _context.Productos.Where(p => p.CodigoProducto == codigoProducto).FirstOrDefaultAsync();
        }
    }
}
