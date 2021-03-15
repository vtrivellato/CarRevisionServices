using System;
using System.Collections.Generic;
using System.Linq;
using api.Data.Contexts;
using api.Models;

namespace api.Data.Repositories
{
    public class SqlFabricanteRepository : IFabricanteRepository
    {
        private readonly ApiDBContext _context;

        public SqlFabricanteRepository(ApiDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Fabricante> GetAllFabricantes()
        {
            return _context.Fabricantes.ToList();
        }
    }
}