using System.Collections.Generic;
using api.Models;

namespace api.Data.Repositories
{
    public interface ICorRepository
    {
        IEnumerable<Cor> GetAllCores(int? fabricante);
    }
}