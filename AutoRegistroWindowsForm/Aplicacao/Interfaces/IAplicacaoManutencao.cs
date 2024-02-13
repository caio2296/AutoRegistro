using Aplicacao.Interfaces.Generico;
using Entidades.Entidades;
using Entidades.Entidades.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Interfaces
{
    public interface IAplicacaoManutencao:IGenericaAplicacao<Manutencao>
    {
        void AdicionarManutencao(Manutencao manutencao);
        Task AtualizarManutencao(Manutencao manutencao);
        Task<List<Manutencao>> BuscarManutencoes();
        List<ViewModelManutencao> BuscarManutencoesCustomizadas(int idVeiculo);
    }
}
