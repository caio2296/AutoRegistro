using Entidades.Entidades;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace InfraEstrutura.Configuracao
{
    public class Contexto: IdentityDbContext<Usuario>
    {
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }
        public DbSet<AutoEscola> autoEscolas { get; set; }
        public DbSet<Veiculo> veiculos { get; set; }
        public DbSet<Manutencao> manutencao { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ObterStringConexao());
                base.OnConfiguring(optionsBuilder);
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Usuario>().ToTable("Usuario").HasKey(t => t.Id);
            builder.Entity<AutoEscola>().ToTable("AutoEscola").HasKey(t => t.Id);
            
            builder.Entity<Veiculo>().ToTable("Veiculo")
                .HasOne(a=>a.AutoEscola)
                .WithMany(v=>v.Veiculos)
                .HasForeignKey(a=>a.IdAutoEscola);
            builder.Entity<Manutencao>().ToTable("Manutencao")
                .HasOne(v=> v.Veiculo)
                .WithMany(m=>m.Manutencoes);
            base.OnModelCreating(builder);
        }

        private string ObterStringConexao()
        {
            string strcon =
                "Server = tcp:profilecaio.database.windows.net,1433; Initial Catalog = AutoRegistro; Persist Security Info = False; User ID = caio; Password =zxcasd384!A; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30";
            return strcon;
        }
    }
}
