using System.Collections.Generic;
using api.Models;

namespace api.Data.Repositories
{
    public interface IRevisaoRepository
    {
        bool SaveChanges();

        IEnumerable<Revisao> GetAllRevisoes(string chassi = null);

        Revisao GetRevisaoById(int id);

        Revisao GetRevisaoByPK(string chassi, double km);

        void Create(Revisao revisao);

        void Update(Revisao revisao);

        void Delete(Revisao revisao);
    }
}