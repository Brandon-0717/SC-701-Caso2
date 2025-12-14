
using Abstracciones.Interfaces.DA;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DA.Repositorios
{
    public class RepositorioDapper : IRepositorioDapper
    {
        private readonly IConfiguration _configuration;
        private readonly SqlConnection _conexionBD;
        public RepositorioDapper(IConfiguration configuration)
        {
            _configuration = configuration;
            _conexionBD = new SqlConnection(_configuration.GetConnectionString("ConexionBD"));
        }
        public SqlConnection ObtenerRepositorio()
        {
            throw new NotImplementedException();
        }
    }
}
