using System;
using System.Collections.Generic;
using System.Linq;
using api.Data.Contexts;
using api.Models;

namespace api.Data.Repositories
{
    public class SqlRevisaoRepository : IRevisaoRepository
    {
        private readonly ApiDBContext _context;

        public SqlRevisaoRepository(ApiDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Revisao> GetAllRevisoes(string chassi = null)
        {
            var revisoes = _context.Revisoes.ToList();
            
            if (string.IsNullOrWhiteSpace(chassi))
            {
                return revisoes;
            }
            else 
            {
                return revisoes.Where(r => r.Chassi == chassi);
            }
        }

        public Revisao GetRevisaoById(int id)
        {
            return _context.Revisoes.FirstOrDefault(p => p.Id == id);
        }

        public Revisao GetRevisaoByPK(string chassi, double km)
        {
            return _context.Revisoes.FirstOrDefault(p => p.Chassi == chassi && p.Km == km);
        }

        public void Create(Revisao revisao)
        {
            if (revisao == null)
            {
                throw new ArgumentNullException(nameof(revisao));
            }

            revisao.CreatedAt = DateTime.Now;
            _context.Revisoes.Add(revisao);
        }
        
        public void Update(Revisao revisao)
        {
            revisao.ModifiedAt = DateTime.Now;
        }
        
        public void Delete(Revisao revisao)
        {
            if (revisao == null)
            {
                throw new ArgumentNullException(nameof(revisao));
            }

            _context.Revisoes.Remove(revisao);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}