using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data.Contexts
{
    public class ApiDBContext : DbContext
    {
        public ApiDBContext(DbContextOptions<ApiDBContext> options) : base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Revisao> Revisoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veiculo>()
                .HasMany(v => v.Revisoes)
                .WithOne(r => r.Veiculo)
                .HasPrincipalKey(v => v.Chassi)
                .HasForeignKey(r => r.Chassi);

            modelBuilder.Entity<Revisao>()
                .HasIndex(r => new { r.Chassi, r.Km })
                .IsUnique();
        }
    }
}