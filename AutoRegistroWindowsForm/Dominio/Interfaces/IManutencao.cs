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
    public interface IManutencao:IGenerico<Manutencao>
    {
        List<Manutencao> ListarManutencoes(Expression<Func<Manutencao, bool>> exManutencao);
        List<Manutencao> ListarManutencoesCustomizada(int idVeiculo);
    }
}
