using Aplicacao.Interfaces;
using Entidades.Entidades;
using Entidades.Entidades.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRegistro.Controllers
{
    public class VeiculoController
    {
        private readonly IAplicacaoVeiculo _IaplicacaoVeiculo;
        public VeiculoController(IAplicacaoVeiculo aplicacaoVeiculo)
        {
                _IaplicacaoVeiculo = aplicacaoVeiculo;
        }

        public async Task<List<ModelViewVeiculo>> BuscarVeiculosCustomizada(int idAutoEscola)
        {
            return await _IaplicacaoVeiculo.BuscarVeiculosCustomizada(idAutoEscola);
        }

        public async Task AtualizarVeiculo(Veiculo novoVeiculo)
        {
             await _IaplicacaoVeiculo.AtualizarVeiculo(novoVeiculo);
        }

        public async Task AdicionarVeiculo(Veiculo veiculo)
        {
            await _IaplicacaoVeiculo.Adicionar(veiculo);
        }

    }
}
