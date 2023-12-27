using Dominio.Interfaces.Generico;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IAutoEscola:IGenerico<AutoEscola>
    {
        Task<List<AutoEscola>> ListarAutoEscola(Expression<Func<AutoEscola, bool>> exAutoEscola);
        Task<List<AutoEscola>> ListarAutoEscolasCustomizada();
    }
}
