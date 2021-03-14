using System.Collections.Generic;
using api.Models;

namespace api.Data.Repositories
{
    public interface IVeiculoRepository
    {
        bool SaveChanges();

        IEnumerable<Veiculo> GetAllVeiculos();

        Veiculo GetVeiculoById(int id);

        Veiculo GetVeiculoByPK(string chassi);

        void Create(Veiculo veiculo);

        void Update(Veiculo veiculo);

        void Delete(Veiculo veiculo);
    }
}