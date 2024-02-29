using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Generico
{
    public interface IGenerico<T> where T : class
    {
        void Adicionar(T Objeto);
        void Atualizar(T Objecto);
        void Excluir(T Objeto);
        T? BuscarPorId(int id);
        List<T> Listar();
    }
}
