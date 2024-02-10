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
    public interface IAplicacaoVeiculo:IGenericaAplicacao<Veiculo>
    {
        void AdicionarVeiculo(Veiculo veiculo);
        bool ExisteVeiculo(string placa);
        Task AtualizarVeiculo(Veiculo veiculo);
        Task<List<Veiculo>> BuscarVeiculosPertoTrocarOleo();
        List<ModelViewVeiculo> BuscarVeiculosCustomizada(int idAutoEscola);
    }
}
