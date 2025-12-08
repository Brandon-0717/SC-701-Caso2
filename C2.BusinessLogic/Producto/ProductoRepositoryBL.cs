
using AutoMapper;
using C2.Abstractions.BusinessLogic.Producto;
using C2.Abstractions.DataAccess.Producto;
using C2.Abstractions.Modelos;
using C2.Abstractions.Models.DAModels;
using C2.Abstractions.Models.DTOModels;

namespace C2.BusinessLogic.Producto
{
    public class ProductoRepositoryBL : IProductoRepositoryBL
    {
        private readonly IProductoRepositoryDA _productoRepository;
        private readonly IMapper _mapper;
        private readonly IObtenerProductoPorCodigoBL _obtenerProductoPorCodigoBL;
        public ProductoRepositoryBL(IProductoRepositoryDA productoRepository, IMapper mapper, IObtenerProductoPorCodigoBL obtenerProductoPorCodigoBL)
        {
            _productoRepository = productoRepository;
            _mapper = mapper;
            _obtenerProductoPorCodigoBL = obtenerProductoPorCodigoBL;
        }

        public async Task<CustomResponse<List<ProductoDTO>>> Listar()
        {
            var response = new CustomResponse<List<ProductoDTO>>();

            var productos = await _productoRepository.Listar();

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

        public async Task<CustomResponse<ProductoDTO>> Crear(ProductoDTO producto)
        {
            var response = new CustomResponse<ProductoDTO>();

            var productoExistente = await _obtenerProductoPorCodigoBL.ObtenerPorCodigo(producto.CodigoProducto);

            if (productoExistente.Data != null)
            {
                response.IsError = true;
                response.Message = "El código de producto ya existe.";
                return response;
            }

            var respuesta = await _productoRepository.Crear(_mapper.Map<ProductoDA>(producto));

            if (respuesta == null)
            {
                response.IsError = true;
                response.Message = "No se pudo crear el producto.";
                return response;
            }

            response.Data = _mapper.Map<ProductoDTO>(respuesta);
            response.Message = "Producto creado exitosamente.";
            return response;
        }

        public async Task<CustomResponse<ProductoDTO>> ObtenerProductoPorCodigo(string codigoProducto)
        {
            var response = new CustomResponse<ProductoDTO>();

            var productoResponse = await _obtenerProductoPorCodigoBL.ObtenerPorCodigo(codigoProducto);

            if (productoResponse == null)
            {
                response.IsError = true;
                response.Message = productoResponse.Message;
                return response;
            }

            return productoResponse;
        }

        public async Task<CustomResponse<ProductoDTO>> Modificar(ProductoDTO producto)
        {
            var response = new CustomResponse<ProductoDTO>();

            var productoExistente = await _obtenerProductoPorCodigoBL.ObtenerPorCodigo(producto.CodigoProducto);

            if(productoExistente.IsError)
            {
                response.IsError = true;
                response.Message = productoExistente.Message;
                return response;
            }

            var respuesta = await _productoRepository.Modificar(_mapper.Map<ProductoDA>(producto));

            if (!respuesta)
            {
                response.IsError = true;
                response.Message = "No se pudo modificar el producto.";
                return response;
            }

            var productoAct = await _obtenerProductoPorCodigoBL.ObtenerPorCodigo(producto.CodigoProducto);
            response.Data = productoAct.Data;
            response.Message = "Producto modificado exitosamente.";
            return response;
        }

        public async Task<CustomResponse<ProductoDTO>> ActualizarStock(string codigoProducto, int cantidad)
        {
            var response = new CustomResponse<ProductoDTO>();

            if(cantidad < 0)
            {
                response.IsError = true;
                response.Message = "La cantidad a actualizar no puede ser negativa.";
                return response;
            }

            var producto = await _obtenerProductoPorCodigoBL.ObtenerPorCodigo(codigoProducto);

            if (producto.IsError)
            {
                response.IsError = true;
                response.Message = producto.Message;
                return response;
            }

            var respuesta = await _productoRepository.ActualizarStock(codigoProducto, cantidad);
            
            if (!respuesta)
            {
                response.IsError = true;
                response.Message = "No se pudo actualizar el stock del producto.";
                return response;
            }

            response.Message= "Stock del producto actualizado exitosamente.";
            response.Data = producto.Data;
            return response;
        }

        public async Task<CustomResponse<int>> VerificarStock(string codigoProducto)
        {
            var response = new CustomResponse<int>();

            var producto = await _obtenerProductoPorCodigoBL.ObtenerPorCodigo(codigoProducto);

            if (producto.IsError)
            {
                response.IsError = true;
                response.Message = producto.Message;
                return response;
            }

            if(producto.Data.Cantidad <= 0)
            {
                response.IsError = true;
                response.Message = "No hay stock disponible para el producto.";
                return response;
            }

            response.Data = producto.Data.Cantidad;
            response.Message = "Stock disponible.";
            return response;
        }
    }
}
