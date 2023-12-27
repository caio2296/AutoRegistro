using Dominio.Interfaces;
using Entidades.Entidades;
using InfraEstrutura.Configuracao;
using InfraEstrutura.Repositorio.Generico;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InfraEstrutura.Repositorio
{
    public class RepositorioAutoEscola : RepositorioGenerico<AutoEscola>, IAutoEscola
    {
        private readonly DbContextOptions<Contexto> _optionsBuilder;
        public RepositorioAutoEscola()
        {
                _optionsBuilder= new DbContextOptions<Contexto>();
        }
        public async Task<List<AutoEscola>> ListarAutoEscola(Expression<Func<AutoEscola, bool>> exAutoEscola)
        {
            using (var banco = new Contexto(_optionsBuilder))
            {
                return await banco.autoEscolas.Where(exAutoEscola).AsNoTracking().ToListAsync();
            }
        }

        public Task<List<AutoEscola>> ListarAutoEscolasCustomizada()
        {
            using (var banco = new Contexto(_optionsBuilder))
            {
                var listarAutoEscola = (from AutoEscola in banco.autoEscolas
                                        select new AutoEscola
                                        {
                                            Id=AutoEscola.Id,
                                            NomeAutoEscola=AutoEscola.NomeAutoEscola,
                                            Senha =AutoEscola.Senha
                                        }).AsNoTracking().ToListAsync();
                return listarAutoEscola;
            }
        }
    }
}
