
using AutoMapper;
using C2.Abstractions.BusinessLogic.Orden;
using C2.Abstractions.DataAccess.Orden;
using C2.Abstractions.Modelos;
using C2.Abstractions.Models.DAModels;
using C2.Abstractions.Models.DTOModels;

namespace C2.BusinessLogic.Orden
{
    public class OrdenRepositoryBL : IOrdenRepositoryBL
    {
        private readonly IOrdenRepositoryDA _ordenRepositoryDA;
        private readonly IMapper _mapper;
        public OrdenRepositoryBL(IOrdenRepositoryDA ordenRepositoryDA, IMapper mapper)
        {
            _ordenRepositoryDA = ordenRepositoryDA;
            _mapper = mapper;
        }

        public async Task<CustomResponse<List<OrdenDTO>>> Listar()
        {
            var response = new CustomResponse<List<OrdenDTO>>();

            var ordenes = await _ordenRepositoryDA.Listar();

            if (ordenes.Count == 0)
            {
                response.IsError = true;
                response.Message = "No se encontraron ordenes.";
                return response;
            }

            response.Data = _mapper.Map<List<OrdenDTO>>(ordenes);
            response.Message = "Ordenes obtenidas correctamente.";
            return response;
        }
    }
}
