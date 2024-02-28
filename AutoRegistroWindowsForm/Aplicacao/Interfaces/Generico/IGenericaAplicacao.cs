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
        void Atualizar(T Objeto);
        void Excluir(T Objeto);
        T BuscarPorId(int id);
        List<T> Listar();
    }
}
