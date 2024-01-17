using Aplicacao.Interfaces.Generico;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Interfaces
{
    public interface IAplicacaoUsuario
    {
        Task<bool> AdicionarUsuario(string nome, string email, string senha);
        Task<bool> ExisteUsuario(string email, string senha);
        Task<string> RetornarIdUsuario(string email);
        Task<string> RetornarTipoUsuario(string email);
    }
}
