using C2.Abstractions.BusinessLogic.Producto;
using C2.Abstractions.Models.DTOModels;
using Microsoft.AspNetCore.Mvc;

namespace C2.InventariosAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController : Controller
    {
        private readonly IProductoRepositoryBL _productoRepositoryBL;
        public ProductoController(IProductoRepositoryBL productoRepositoryBL)
        {
            _productoRepositoryBL = productoRepositoryBL;
        }

        [HttpGet("Listar")]
        public async Task<IActionResult> Listar()
        {
            var response = await _productoRepositoryBL.Listar();
            if (response.IsError)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("Crear")]
        public async Task<IActionResult> Crear(ProductoDTO producto)
        {
            var response = await _productoRepositoryBL.Crear(producto);
            if (response.IsError)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpGet("Detalle/{codigoProducto}")]
        public async Task<IActionResult> DetalleProducto(string codigoProducto)
        {
            var response = await _productoRepositoryBL.ObtenerProductoPorCodigo(codigoProducto);
            if (response.IsError)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPut("Modificar")]
        public async Task<IActionResult> Modificar(ProductoDTO producto)
        {
            var response = await _productoRepositoryBL.Modificar(producto);
            if (response.IsError)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPut("ActualizarStock/{codigoProducto}/{cantidad}")]
        public async Task<IActionResult> ActualizarStock(string codigoProducto, int cantidad)
        {
            var response = await _productoRepositoryBL.ActualizarStock(codigoProducto, cantidad);
            if (response.IsError)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpGet("VerificarStock/{codigoProducto}")]
        public async Task<IActionResult> VerificarStock(string codigoProducto)
        {
            var response = await _productoRepositoryBL.VerificarStock(codigoProducto);
            if (response.IsError)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}
