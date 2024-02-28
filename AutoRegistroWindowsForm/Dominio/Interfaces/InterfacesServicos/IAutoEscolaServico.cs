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
        void AtualizarAutoEscola(AutoEscola AutoEscola);
        List<AutoEscola> BuscarAutoEscolas();
        List<ViewModelAutoEscola> BuscarAutoEscolaCustomizada();
    }
}
