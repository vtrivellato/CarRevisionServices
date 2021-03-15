using System.Collections.Generic;
using api.Models;

namespace api.Data.Repositories
{
    public interface IFabricanteRepository
    {
        IEnumerable<Fabricante> GetAllFabricantes();
    }
}