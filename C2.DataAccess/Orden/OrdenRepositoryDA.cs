
using C2.Abstractions.DataAccess.Orden;
using C2.Abstractions.Models.DAModels;
using Microsoft.EntityFrameworkCore;

namespace C2.DataAccess.Orden
{
    public class OrdenRepositoryDA : IOrdenRepositoryDA
    {
        private readonly Context _context;
        public OrdenRepositoryDA(Context context)
        {
            _context = context;
        }

        public async Task<List<OrdenDA>> Listar()
        {
            return await _context.Ordenes.ToListAsync();
        }
    }
}
