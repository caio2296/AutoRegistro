using Aplicacao.Aplicacoes;
using Aplicacao.Interfaces;
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

        public async Task<List<ViewModelManutencao>> BuscarManutencoesCustomizadas(int idVeiculo)
        {
            return await _IaplicacaoManutencao.BuscarManutencoesCustomizadas(idVeiculo);
        }
    }
}
