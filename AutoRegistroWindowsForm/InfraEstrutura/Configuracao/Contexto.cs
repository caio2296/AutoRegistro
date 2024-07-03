using Entidades.Entidades;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
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
                optionsBuilder.UseMySql(ObterStringConexaoMySql(),
                     new MySqlServerVersion(new Version(10, 2, 36)));
                //optionsBuilder.UseSqlServer(ObterStringConexao());
                base.OnConfiguring(optionsBuilder);
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Usuario>().ToTable("Usuario").HasKey(t => t.Id);
            builder.Entity<AutoEscola>().ToTable("autoescola").HasKey(t => t.Id);
            
            builder.Entity<Veiculo>().ToTable("veiculo")
                .HasOne(a=>a.AutoEscola)
                .WithMany(v=>v.Veiculos)
                .HasForeignKey(a=>a.IdAutoEscola);
            builder.Entity<Manutencao>().ToTable("manutencao")
                .HasOne(v=> v.Veiculo)
                .WithMany(m=>m.Manutencoes).HasForeignKey(m=> m.IdVeiculo);
            base.OnModelCreating(builder);
        }

        private string ObterStringConexao()
        {
            string strcon =
                "Server = tcp:profilecaio.database.windows.net,1433; Initial Catalog = AutoRegistro; Persist Security Info = False; User ID = caio; Password =zxcasd384!A; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30";
            return strcon;
        }
        private string ObterStringConexaoMySql()
        {
            //string strcon = "Server=localhost;DataBase=autoregistro;Uid=root;Pwd=zxcasd384!A";
            string strcon = "Server=mysql.autoregistro.kinghost.net;DataBase=autoregistro;User=autoregistro;Password=zxcasd384";

            return strcon;
        }
    }
}
