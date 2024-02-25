using Microsoft.EntityFrameworkCore;
using aplicationAPI_Relatorio.Data.Map;
using aplicationAPI_Relatorio.Models;

namespace aplicationAPI_Relatorio.Data
{
    public class SistemaContaBuscaDBContext : DbContext
    {
        public SistemaContaBuscaDBContext(DbContextOptions<SistemaContaBuscaDBContext> options)
            : base(options) 
        {
        }

        public DbSet<ContaModel> Contas { get; set; }
        public DbSet<UsuarioModel> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new ContaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
