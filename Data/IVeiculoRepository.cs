using System.Collections.Generic;
using api.Models;

namespace api.Data
{
    public interface IVeiculoRepository
    {
        IEnumerable<Veiculo> GetAllVeiculos();

        Veiculo GetveiculoById(int id);

        Veiculo GetveiculoByPK(string chassi);  
    }
}