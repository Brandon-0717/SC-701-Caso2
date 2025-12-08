
using C2.Abstractions.Modelos;
using C2.Abstractions.Models.DTOModels;

namespace C2.Abstractions.BusinessLogic.Orden
{
    public interface IOrdenRepositoryBL
    {
        Task<CustomResponse<List<OrdenDetalleDTO>>> Listar();
    }
}
