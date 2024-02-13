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
        public void Adicionar(Veiculo Objeto)
        {
            _veiculo.Adicionar(Objeto);
        }

        public void AdicionarVeiculo(Veiculo veiculo)
        {
             _veiculoServico.AdicionarVeiculo(veiculo);
        }

        public async Task Atualizar(Veiculo Objeto)
        {
            await _veiculo.Atualizar(Objeto);
        }

        public async Task AtualizarVeiculo(Veiculo veiculo)
        {
            await _veiculoServico.AtualizarVeiculo(veiculo);
        }

        public  Veiculo BuscarPorId(int id)
        {
            return  _veiculo.BuscarPorId(id);
        }

        public  List<ModelViewVeiculo> BuscarVeiculosCustomizada(int idAutoEscola)
        {
            return  _veiculoServico.BuscarVeiculosCustomizada(idAutoEscola);
        }

        public async Task<List<Veiculo>> BuscarVeiculosPertoTrocarOleo()
        {
            return await _veiculoServico.BuscarVeiculosPertoTrocarOleo();
        }

        public void Excluir(Veiculo Objeto)
        {
              _veiculo.Excluir(Objeto);
        }

        public async Task<List<Veiculo>> Listar()
        {
           return await _veiculo.Listar();
        }

        public bool ExisteVeiculo(string placa)
        {
            return _veiculo.ExisteVeiculo(placa);
        }
    }
}
