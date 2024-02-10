using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Interfaces.Generico
{
    public interface IGenericaAplicacao<T> where T : class
    {
        void Adicionar(T Objeto);
        Task Atualizar(T Objeto);
        Task Excluir(T Objeto);
        T BuscarPorId(int id);
        Task<List<T>> Listar();
    }
}
