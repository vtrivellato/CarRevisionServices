using System;
using System.Collections.Generic;
using System.Linq;
using api.Data.Contexts;
using api.Models;

namespace api.Data.Repositories
{
    public class SqlModeloRepository : IModeloRepository
    {
        private readonly ApiDBContext _context;

        public SqlModeloRepository(ApiDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Modelo> GetAllModelos(int? fabricante)
        {
            var modelos = _context.Modelos.ToList();

            if (fabricante == null)
            {
                return modelos;
            }
            else
            {
                return modelos.Where(r => r.Fabricante == fabricante);
            }
        }
    }
}