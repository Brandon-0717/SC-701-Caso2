
using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace Abstracciones.Interfaces.API
{
    public interface IProductoController
    {
        Task<IActionResult> Obtener();
        Task<IActionResult> Obtener(int id);
        Task<IActionResult> Crear(ProductoRequest producto);
        Task<IActionResult> Editar(int id, ProductoRequest producto);
        Task<IActionResult> Eliminar(int id);
    }
}
