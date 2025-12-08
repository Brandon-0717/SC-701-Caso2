using C2.Abstractions.BusinessLogic.Orden;
using Microsoft.AspNetCore.Mvc;

namespace C2.OrdersAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdenController : Controller
    {
        private readonly IOrdenRepositoryBL _ordenRepositoryBL;
        public OrdenController(IOrdenRepositoryBL ordenRepositoryBL)
        {
            _ordenRepositoryBL = ordenRepositoryBL;
        }

        [HttpGet("Listar")]
        public async Task<IActionResult> Listar()
        {
            var response = await _ordenRepositoryBL.Listar();
            if (response.IsError)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}
