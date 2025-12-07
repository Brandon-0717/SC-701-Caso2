
using C2.Abstractions.DataAccess.Producto;
using C2.Abstractions.Models.DAModels;
using C2.Abstractions.Models.DTOModels;
using Microsoft.EntityFrameworkCore;

namespace C2.DataAccess.Producto
{
    public class ListarProductosDA : IListarProductosDA
    {
        private readonly Context _context;

        public ListarProductosDA(Context context)
        {
            _context = context;
        }

        public async Task<List<ProductoDA>> Listar()
        {
            return await _context.Productos.ToListAsync();
        }
    }
}
