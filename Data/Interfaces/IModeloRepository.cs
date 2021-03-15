using System.Collections.Generic;
using api.Models;

namespace api.Data.Repositories
{
    public interface IModeloRepository
    {
        IEnumerable<Modelo> GetAllModelos(int? fabricante);
    }
}