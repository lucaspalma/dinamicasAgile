using System;
using System.Collections.Generic;
using dinamicasAgile.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

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
        public DbSet<TipoDinamica> TiposDinamicas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<TipoDinamica>()
                .Property(e => e.Tipo)
                .HasConversion(
                    v => v.ToString(),
                    v => (Tipo) Enum.Parse(typeof(Tipo), v));
        }
    }
}