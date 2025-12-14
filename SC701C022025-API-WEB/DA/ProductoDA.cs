
using Abstracciones.Interfaces.DA;
using Abstracciones.Modelos;
using Microsoft.Data.SqlClient;

namespace DA
{
    public class ProductoDA : IProductoDA
    {

        private readonly IRepositorioDapper _repositorioDapper;
        private readonly SqlConnection _sqlConnection;
        public ProductoDA(IRepositorioDapper repositorioDapper)
        {
            _repositorioDapper = repositorioDapper;
            _sqlConnection = _repositorioDapper.ObtenerRepositorio();
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
