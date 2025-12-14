
using Abstracciones.Interfaces.DA;
using Abstracciones.Interfaces.Flujo;
using Abstracciones.Modelos;

namespace Flujo
{
    public class ProductoFlujo : IProductoFlujo
    {
        private readonly IProductoDA _productoDA;
        public ProductoFlujo(IProductoDA productoDA)
        {
            _productoDA = productoDA;
        }
        public Task<Guid> Crear(ProductoRequest producto)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> Editar(int id, ProductoRequest producto)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductoResponse>> Obtener()
        {
            throw new NotImplementedException();
        }

        public Task<ProductoResponse> Obtener(int id)
        {
            throw new NotImplementedException();
        }
    }
}
