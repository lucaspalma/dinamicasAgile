using dinamicasAgile.Models;
using Microsoft.EntityFrameworkCore;

namespace dinamicasAgile.Banco
{
    public class DinamicaContext : DbContext
    {
        public DinamicaContext(DbContextOptions<DinamicaContext> options) : base(options)
        {
        }

        public DbSet<Dinamica> Dinamicas { get; set; }
        public DbSet<Exemplo> Exemplos { get; set; }
        public DbSet<Fluxo> Fluxos { get; set; }
        public DbSet<Passo> Passos { get; set; }
        public DbSet<InformacoesBasicas> InformacoesBasicas { get; set; }
        public DbSet<Referencia> Referencias { get; set; }
    }
}