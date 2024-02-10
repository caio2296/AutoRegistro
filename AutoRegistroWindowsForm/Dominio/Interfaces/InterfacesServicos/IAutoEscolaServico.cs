using Entidades.Entidades.ViewModel;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.InterfacesServicos
{
    public interface IAutoEscolaServico
    {
        void AdicionarAutoEscola(AutoEscola AutoEscola);
        Task AtualizarAutoEscola(AutoEscola AutoEscola);
        Task<List<AutoEscola>> BuscarAutoEscolas();
        Task<List<ViewModelAutoEscola>> BuscarAutoEscolaCustomizada();
    }
}
