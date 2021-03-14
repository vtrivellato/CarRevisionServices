using System.Collections.Generic;
using System.Linq;
using api.Models;

namespace api.Data
{
    public class SqlVeiculoRepository : IVeiculoRepository
    {
        private readonly VeiculoContext _context;

        public SqlVeiculoRepository(VeiculoContext context)
        {
            _context = context;
        }

        public IEnumerable<Veiculo> GetAllVeiculos()
        {
            return _context.Veiculos.ToList();
        }

        public Veiculo GetveiculoById(int id)
        {
            return _context.Veiculos.FirstOrDefault(p => p.Id == id);
        }

        public Veiculo GetveiculoByPK(string chassi)
        {
            return _context.Veiculos.FirstOrDefault(p => p.Chassi == chassi);
        }
    }
}