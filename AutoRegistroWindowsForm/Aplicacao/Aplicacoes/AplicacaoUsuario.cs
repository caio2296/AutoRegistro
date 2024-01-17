using Aplicacao.Interfaces;
using Dominio.Interfaces;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Aplicacoes
{
    public class AplicacaoUsuario : IAplicacaoUsuario
    {
        private IUsuario _usuario;

        public AplicacaoUsuario(IUsuario usuario)
        {
                _usuario = usuario;
        }

        public async Task<bool> AdicionarUsuario(string nome, string email, string senha)
        {
           return await _usuario.AdicionarUsuario(nome,email,senha);
        }



        public async Task<bool> ExisteUsuario(string email, string senha)
        {
            return await _usuario.ExisteUsuario(email, senha);
        }


        public async Task<string> RetornarIdUsuario(string email)
        {
            return await _usuario.RetornarIdUsuario(email);
        }
#warning inserir depois o tipo do usuario
        public Task<string> RetornarTipoUsuario(string email)
        {
            throw new NotImplementedException();
        }
    }
}
