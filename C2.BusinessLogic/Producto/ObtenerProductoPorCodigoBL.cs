
using AutoMapper;
using C2.Abstractions.BusinessLogic.Producto;
using C2.Abstractions.DataAccess.Producto;
using C2.Abstractions.Modelos;
using C2.Abstractions.Models.DTOModels;

namespace C2.BusinessLogic.Producto
{
    public class ObtenerProductoPorCodigoBL : IObtenerProductoPorCodigoBL
    {
        private readonly IObtenerProductoPorCodigoDA _obtenerProductoPorCodigoDA;
        private readonly IMapper _mapper;
        public ObtenerProductoPorCodigoBL(IObtenerProductoPorCodigoDA obtenerProductoPorCodigoDA, IMapper mapper)
        {
            _obtenerProductoPorCodigoDA = obtenerProductoPorCodigoDA;
            _mapper = mapper;
        }
        public async Task<CustomResponse<ProductoDTO>> ObtenerPorCodigo(string codigoProducto)
        {
            var response = new CustomResponse<ProductoDTO>();

            var producto = await _obtenerProductoPorCodigoDA.ObtenerPorCodigo(codigoProducto);

            if (producto == null)
            {
                response.IsError = true;
                response.Message = "Producto no encontrado.";
                return response;
            }

            response.Data = _mapper.Map<ProductoDTO>(producto);
            response.Message = "Producto obtenido exitosamente.";
            return response;
        }
    }
}
