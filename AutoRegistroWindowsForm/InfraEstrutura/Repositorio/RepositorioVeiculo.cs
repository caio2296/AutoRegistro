using Dominio.Interfaces;
using Entidades.Entidades;
using InfraEstrutura.Configuracao;
using InfraEstrutura.Repositorio.Generico;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InfraEstrutura.Repositorio
{
    public class RepositorioVeiculo : RepositorioGenerico<Veiculo>, IVeiculo
    {
        private readonly DbContextOptions<Contexto> _optionsBuilder;
        public RepositorioVeiculo()
        {
            _optionsBuilder = new DbContextOptions<Contexto>();
        }

        public async Task<List<Veiculo>> ListarVeiculos(Expression<Func<Veiculo, bool>> exVeiculo)
        {
            using (var banco = new Contexto(_optionsBuilder))
            {
              return await  banco.veiculos.Where(exVeiculo).AsNoTracking().ToListAsync();
            }
        }

        public async Task<List<Veiculo>> ListarVeiculosCustomizada()
        {
            using (var banco = new Contexto(_optionsBuilder))
            {
                var listaVeiculos = await (from Veiculo in banco.veiculos
                                           select new Veiculo
                                           {
                                               Id = Veiculo.Id,
                                               Modelo = Veiculo.Modelo,
                                               Placa = Veiculo.Placa,
                                               KmAtual = Veiculo.KmAtual,
                                               KmTrocaOleo = Veiculo.KmTrocaOleo,
                                               IdAutoEscola = Veiculo.IdAutoEscola,

                                           }).AsNoTracking().ToListAsync();
                return listaVeiculos;
            }
        }
    }
}
