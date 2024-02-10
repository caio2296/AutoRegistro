using Entidades.Entidades;
using Entidades.Entidades.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.InterfacesServicos
{
    public interface IVeiculoServico
    {
        void AdicionarVeiculo(Veiculo veiculo);
        Task AtualizarVeiculo(Veiculo veiculo);
        Task<List<Veiculo>> BuscarVeiculosPertoTrocarOleo();
        List<ModelViewVeiculo> BuscarVeiculosCustomizada(int idAutoEscola);
    }
}
