
using AutoMapper;
using C2.Abstractions.BusinessLogic.Producto;
using C2.Abstractions.DataAccess.Producto;
using C2.Abstractions.Modelos;
using C2.Abstractions.Models.DTOModels;

namespace C2.BusinessLogic.Producto
{
    public class ListarProductosBL : IListarProductosBL
    {
        private readonly IListarProductosDA _listarProductosDA;
        private readonly IMapper _mapper;
        public ListarProductosBL(IListarProductosDA listarProductosDA, IMapper mapper)
        {
            _listarProductosDA = listarProductosDA;
            _mapper = mapper;
        }

        public async Task<CustomResponse<List<ProductoDTO>>> Listar()
        {
            var response = new CustomResponse<List<ProductoDTO>>();

            var productos = await _listarProductosDA.Listar();

            if(productos.Count == 0)
            {
                response.IsError = true;
                response.Message = "No se encontraron productos.";
                return response;
            }

            response.Data = _mapper.Map<List<ProductoDTO>>(productos);
            response.Message = "Productos encontrados exitosamente.";
            return response;
        }
    }
}
