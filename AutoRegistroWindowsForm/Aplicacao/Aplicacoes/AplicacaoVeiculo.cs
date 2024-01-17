using Aplicacao.Interfaces;
using Dominio.Interfaces;
using Dominio.Interfaces.InterfacesServicos;
using Entidades.Entidades;
using Entidades.Entidades.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Aplicacoes
{
    public class AplicacaoVeiculo : IAplicacaoVeiculo
    {
        private IVeiculoServico _veiculoServico;
        private IVeiculo _veiculo;
        public AplicacaoVeiculo(IVeiculoServico veiculoServico,IVeiculo veiculo)
        {
            _veiculoServico=veiculoServico;
            _veiculo=veiculo;    
        }
        public async Task Adicionar(Veiculo Objeto)
        {
           await _veiculo.Adicionar(Objeto);
        }

        public async Task AdicionarVeiculo(Veiculo veiculo)
        {
            await _veiculoServico.AdicionarVeiculo(veiculo);
        }

        public async Task Atualizar(Veiculo Objeto)
        {
            await _veiculo.Atualizar(Objeto);
        }

        public async Task AtualizarVeiculo(Veiculo veiculo)
        {
            await _veiculoServico.AtualizarVeiculo(veiculo);
        }

        public async Task<Veiculo> BuscarPorId(int id)
        {
            return await _veiculo.BuscarPorId(id);
        }

        public async Task<List<ModelViewVeiculo>> BuscarVeiculosCustomizada()
        {
            return await _veiculoServico.BuscarVeiculosCustomizada();
        }

        public async Task<List<Veiculo>> BuscarVeiculosPertoTrocarOleo()
        {
            return await _veiculoServico.BuscarVeiculosPertoTrocarOleo();
        }

        public async Task Excluir(Veiculo Objeto)
        {
             await _veiculo.Excluir(Objeto);
        }

        public async Task<List<Veiculo>> Listar()
        {
           return await _veiculo.Listar();
        }
    }
}
