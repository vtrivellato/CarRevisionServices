using System.Collections.Generic;
using api.Models;

namespace api.Data.Repositories
{
    public interface IVeiculoRepository
    {
        bool SaveChanges();

        IEnumerable<Veiculo> GetAllVeiculos();

        Veiculo GetveiculoById(int id);

        Veiculo GetveiculoByPK(string chassi);

        void Create(Veiculo veiculo);

        void Update(Veiculo veiculo);

        void Delete(Veiculo veiculo);
    }
}