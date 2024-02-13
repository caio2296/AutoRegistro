using Entidades.Entidades.ViewModel;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.InterfacesServicos
{
    public interface IManutencaoServico
    {
        void AdicionarManutencao(Manutencao manutencao);
        Task AtualizarManutencao(Manutencao manutencao);
        Task<List<Manutencao>> BuscarManutencoes();
        List<ViewModelManutencao> BuscarManutencoesCustomizadas(int idVeiculo);
    }
}
