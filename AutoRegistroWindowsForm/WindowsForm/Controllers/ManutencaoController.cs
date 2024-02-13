using Aplicacao.Aplicacoes;
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
    public class ManutencaoController
    {
        private readonly IAplicacaoManutencao _IaplicacaoManutencao;
        public ManutencaoController(IAplicacaoManutencao aplicacaoManutencao)
        {
                _IaplicacaoManutencao = aplicacaoManutencao;
        }

        public  List<ViewModelManutencao> BuscarManutencoesCustomizadas(int idVeiculo)
        {
            return  _IaplicacaoManutencao.BuscarManutencoesCustomizadas(idVeiculo);
        }

        public void AdicionarManutencao(Manutencao novaManutencao)
        {
            _IaplicacaoManutencao.AdicionarManutencao(novaManutencao);
        }
        public void AtualizarManutencao(Manutencao novaManutencao)
        {
            _IaplicacaoManutencao.Atualizar(novaManutencao);
        }

        public void Excluir(Manutencao manutencao)
        {
            _IaplicacaoManutencao.Excluir(manutencao);
        }
    }
}
