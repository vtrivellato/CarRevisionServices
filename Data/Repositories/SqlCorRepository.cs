using System;
using System.Collections.Generic;
using System.Linq;
using api.Data.Contexts;
using api.Models;

namespace api.Data.Repositories
{
    public class SqlCorRepository : ICorRepository
    {
        private readonly ApiDBContext _context;

        public SqlCorRepository(ApiDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Cor> GetAllCores(int? fabricante)
        {
            var cores = _context.Cores.ToList();

            if (fabricante == null)
            {
                return cores;
            }
            else
            {
                return cores.Where(r => r.Fabricante == fabricante);
            }
        }
    }
}