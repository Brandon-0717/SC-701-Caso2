
using C2.Abstractions.Models.DAModels;

namespace C2.Abstractions.DataAccess.Orden
{
    public interface IOrdenRepositoryDA
    {
        Task<List<OrdenDetalleDA>> Listar();
    }
}
