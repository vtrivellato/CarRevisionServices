using System;
using System.Collections.Generic;
using System.Linq;
using api.Data.Contexts;
using api.Models;

namespace api.Data.Repositories
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

        public void Create(Veiculo veiculo)
        {
            if (veiculo == null)
            {
                throw new ArgumentNullException(nameof(veiculo));
            }

            veiculo.CreatedAt = DateTime.Now;
            _context.Veiculos.Add(veiculo);
        }
        
        public void Update(Veiculo veiculo)
        {
            veiculo.ModifiedAt = DateTime.Now;
        }
        
        public void Delete(Veiculo veiculo)
        {
            if (veiculo == null)
            {
                throw new ArgumentNullException(nameof(veiculo));
            }

            _context.Veiculos.Remove(veiculo);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}