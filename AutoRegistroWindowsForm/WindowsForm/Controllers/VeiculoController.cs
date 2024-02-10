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

        public  List<ModelViewVeiculo> BuscarVeiculosCustomizada(int idAutoEscola)
        {
            return  _IaplicacaoVeiculo.BuscarVeiculosCustomizada(idAutoEscola);
        }

        public async Task AtualizarVeiculo(Veiculo novoVeiculo)
        {
             await _IaplicacaoVeiculo.AtualizarVeiculo(novoVeiculo);
        }

        public void  AdicionarVeiculo(Veiculo veiculo)
        {
             _IaplicacaoVeiculo.Adicionar(veiculo);
        }
        public bool ExisteVeiculo(string placa)
        {
           return _IaplicacaoVeiculo.ExisteVeiculo(placa);
        }

    }
}
