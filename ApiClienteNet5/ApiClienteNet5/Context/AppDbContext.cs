using Microsoft.EntityFrameworkCore;

namespace ApiClienteNet5.Context
{
    public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Telefone> Telefones { get; set; }

        //public DbSet<ApiClienteNet5.Models.Telefone> Telefone { get; set; }

            
        }

 }
