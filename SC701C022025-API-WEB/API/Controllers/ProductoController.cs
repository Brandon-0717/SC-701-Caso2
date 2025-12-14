using Abstracciones.Interfaces.API;
using Abstracciones.Interfaces.Flujo;
using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase, IProductoController
    {
        private readonly IProductoFlujo _productoFlujo;
        private readonly ILogger<ProductoController> _logger;
        public ProductoController(IProductoFlujo productoFlujo, ILogger<ProductoController> logger)
        {
            _productoFlujo = productoFlujo;
            _logger = logger;
        }
        public Task<IActionResult> Crear(ProductoRequest producto)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Editar(int id, ProductoRequest producto)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Obtener()
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Obtener(int id)
        {
            throw new NotImplementedException();
        }
    }
}
