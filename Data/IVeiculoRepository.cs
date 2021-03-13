using System.Collections.Generic;
using api.Models;

namespace api.Data
{
    public interface IVeiculoRepository
    {
        IEnumerable<Veiculo> GetVeiculos();

        Veiculo GetveiculoById(int id);        
    }
}