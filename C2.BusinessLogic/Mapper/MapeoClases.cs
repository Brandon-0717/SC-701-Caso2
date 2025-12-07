
using AutoMapper;
using C2.Abstractions.Models.DAModels;
using C2.Abstractions.Models.DTOModels;

namespace C2.BusinessLogic.Mapper
{
    public class MapeoClases : Profile
    {
        public MapeoClases()
        {
            CreateMap<ProductoDA, ProductoDTO>();
            CreateMap<ProductoDTO, ProductoDA>();
        }
    }
}
