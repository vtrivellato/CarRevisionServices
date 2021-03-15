using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data.Contexts
{
    public class ApiDBContext : DbContext
    {
        public ApiDBContext(DbContextOptions<ApiDBContext> options) : base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Revisao> Revisoes { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Cor> Cores { get; set; }

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

            modelBuilder.Entity<Fabricante>()
                .HasData(
                    new Fabricante { Id = 100, Codigo = 1, Nome = "Fiat" }, 
                    new Fabricante { Id = 101, Codigo = 2, Nome = "GM" }, 
                    new Fabricante { Id = 102, Codigo = 3, Nome = "Volkswagen" }, 
                    new Fabricante { Id = 103, Codigo = 4, Nome = "Ford" }, 
                    new Fabricante { Id = 104, Codigo = 5, Nome = "Hyundai" }
                );

            modelBuilder.Entity<Modelo>()
                .HasData(
                    new Modelo { Id = 100, Codigo = "1", Nome = "Mobi", Fabricante = 1 }, 
                    new Modelo { Id = 101, Codigo = "2", Nome = "Cronos", Fabricante = 1 }, 
                    new Modelo { Id = 102, Codigo = "3", Nome = "Toro", Fabricante = 1 }, 
                    new Modelo { Id = 103, Codigo = "1", Nome = "Onix", Fabricante = 2 }, 
                    new Modelo { Id = 104, Codigo = "2", Nome = "Cruze", Fabricante = 2 }, 
                    new Modelo { Id = 105, Codigo = "3", Nome = "Captiva", Fabricante = 2 }, 
                    new Modelo { Id = 106, Codigo = "1", Nome = "Up!", Fabricante = 3 }, 
                    new Modelo { Id = 107, Codigo = "2", Nome = "Virtus", Fabricante = 3 }, 
                    new Modelo { Id = 108, Codigo = "3", Nome = "Amarok", Fabricante = 3 }, 
                    new Modelo { Id = 109, Codigo = "1", Nome = "Ka", Fabricante = 4 }, 
                    new Modelo { Id = 110, Codigo = "2", Nome = "Fiesta", Fabricante = 4 }, 
                    new Modelo { Id = 111, Codigo = "3", Nome = "Ranger", Fabricante = 4 }, 
                    new Modelo { Id = 112, Codigo = "1", Nome = "HB20", Fabricante = 5 }, 
                    new Modelo { Id = 113, Codigo = "2", Nome = "Elantra", Fabricante = 5 }, 
                    new Modelo { Id = 114, Codigo = "3", Nome = "Santa Fé", Fabricante = 5 }
                );

            modelBuilder.Entity<Cor>()
                .HasData(
                    new Cor { Id = 100, Codigo = "1", Nome = "Branco", Fabricante = 1 }, 
                    new Cor { Id = 101, Codigo = "2", Nome = "Preto", Fabricante = 1 }, 
                    new Cor { Id = 102, Codigo = "3", Nome = "Vermelho", Fabricante = 1 }, 
                    new Cor { Id = 103, Codigo = "1", Nome = "Branco", Fabricante = 2 }, 
                    new Cor { Id = 104, Codigo = "2", Nome = "Preto", Fabricante = 2 }, 
                    new Cor { Id = 105, Codigo = "3", Nome = "Vermelho", Fabricante = 2 }, 
                    new Cor { Id = 106, Codigo = "1", Nome = "Branco", Fabricante = 3 }, 
                    new Cor { Id = 107, Codigo = "2", Nome = "Preto", Fabricante = 3 }, 
                    new Cor { Id = 108, Codigo = "3", Nome = "Vermelho", Fabricante = 3 }, 
                    new Cor { Id = 109, Codigo = "1", Nome = "Branco", Fabricante = 4 }, 
                    new Cor { Id = 110, Codigo = "2", Nome = "Preto", Fabricante = 4 }, 
                    new Cor { Id = 111, Codigo = "3", Nome = "Vermelho", Fabricante = 4 }, 
                    new Cor { Id = 112, Codigo = "1", Nome = "Branco", Fabricante = 5 }, 
                    new Cor { Id = 113, Codigo = "2", Nome = "Preto", Fabricante = 5 }, 
                    new Cor { Id = 114, Codigo = "3", Nome = "Vermelho", Fabricante = 5 }
                );
        }
    }
}