using Dominio.Interfaces;
using Dominio.Interfaces.InterfacesServicos;
using Entidades.Entidades;
using Entidades.Entidades.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Servicos
{
    public class ManutencaoServico : IManutencaoServico
    {
        private readonly IManutencao _iManutencao;
        public ManutencaoServico(IManutencao manutencao)
        {
                _iManutencao = manutencao;
        }
        public void  AdicionarManutencao(Manutencao manutencao)
        {
            var validarPeca = manutencao.ValidarPropriedadeString(manutencao.NomePeca,"Nome da Peca");
            var validarPreco = manutencao.ValidarPropriedadeDecimal(manutencao.Preco, "Preço");
            var validarFabricante = manutencao.ValidarPropriedadeString(manutencao.Fabricante, "Fabricante");
            if (validarPeca && validarPreco && validarFabricante)
            {
                
                 _iManutencao.Adicionar(manutencao);
            }
        }

        public async Task AtualizarManutencao(Manutencao manutencao)
        {
            var validarPeca = manutencao.ValidarPropriedadeString(manutencao.NomePeca, "Nome da Peca");
            var validarPreco = manutencao.ValidarPropriedadeDecimal(manutencao.Preco, "Preço");
            var validarFabricante = manutencao.ValidarPropriedadeString(manutencao.Fabricante, "Fabricante");
            if (validarPeca && validarPreco && validarFabricante)
            {

                await _iManutencao.Atualizar(manutencao);
            }
        }

        public async Task<List<Manutencao>> BuscarManutencoes()
        {
            return await _iManutencao.ListarManutencoes(m=> m.DataDaInstalacao == DateTime.MinValue);
        }

        public  List<ViewModelManutencao> BuscarManutencoesCustomizadas(int idVeiculo)
        {
            var listaManutencoesCustomizadas = _iManutencao.ListarManutencoesCustomizada(idVeiculo);

            var retorno = (from Manutencao in listaManutencoesCustomizadas
                           select new ViewModelManutencao
                           {
                               Id = Manutencao.Id,
                               NomePeca = Manutencao.NomePeca,
                               Fabricante = Manutencao.Fabricante,
                               Preco = Manutencao.Preco,
                               DataDaCompra = Manutencao.DataDaCompra,
                               DataDaInstalacao = Manutencao.DataDaInstalacao,
                               IdVeiculo= Manutencao.IdVeiculo
                           }).ToList();
            return retorno;
        }
    }
}
