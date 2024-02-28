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
    public interface IAplicacaoAutoEscola:IGenericaAplicacao<AutoEscola>
    {
        void AdicionarAutoEscola(AutoEscola AutoEscola);
        void AtualizarAutoEscola(AutoEscola AutoEscola);
        List<AutoEscola> BuscarAutoEscolas();
        List<ViewModelAutoEscola> BuscarAutoEscolaCustomizada();
        bool ExisteAutoEscola(string nome, string senha);
        string RetornarIdAutoEscola(string nome);
    }
}
