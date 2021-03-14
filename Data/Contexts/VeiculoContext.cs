using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data.Contexts
{
    public class VeiculoContext : DbContext
    {
        public VeiculoContext(DbContextOptions<VeiculoContext> options) : base(options)
        {
            
        }

        public DbSet<Veiculo> Veiculos { get; set; }

        
    }
}