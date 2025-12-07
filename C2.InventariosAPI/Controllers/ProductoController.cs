using C2.Abstractions.BusinessLogic.Producto;
using Microsoft.AspNetCore.Mvc;

namespace C2.InventariosAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController : Controller
    {
        private readonly IListarProductosBL _listarProductosBL;
        public ProductoController(IListarProductosBL listarProductosBL)
        {
            _listarProductosBL = listarProductosBL;
        }

        [HttpGet("Listar")]
        public async Task<IActionResult> Listar()
        {
            var response = await _listarProductosBL.Listar();
            if (response.IsError)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}
