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
    public class RepositorioManutencao : RepositorioGenerico<Manutencao>, IManutencao
    {
        private readonly DbContextOptions<Contexto> _optionsBuilder;
        public RepositorioManutencao()
        {
                _optionsBuilder = new DbContextOptions<Contexto>();
        }
        public async Task<List<Manutencao>> ListarManutencoes(Expression<Func<Manutencao, bool>> exManutencao)
        {
            using (var banco = new Contexto(_optionsBuilder))
            {
                return await banco.manutencao.Where(exManutencao).AsNoTracking().ToListAsync();
            }
        }

        public Task<List<Manutencao>> ListarManutencoesCustomizada()
        {
            using (var banco = new Contexto(_optionsBuilder))
            {
                var listaManutencao = (from Manutencao in banco.manutencao
                                       select new Manutencao
                                       {
                                           Id= Manutencao.Id,
                                           NomePeca=Manutencao.NomePeca,
                                           Fabricante=Manutencao.Fabricante,
                                           Preco=Manutencao.Preco,
                                           IdVeiculo=Manutencao.IdVeiculo,
                                           DataDaCompra=Manutencao.DataDaCompra,
                                           DataDaInstalacao=Manutencao.DataDaInstalacao
                                       }).AsNoTracking().ToListAsync();
                return listaManutencao;
            }
        }
    }
}
