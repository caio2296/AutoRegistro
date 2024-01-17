using Dominio.Interfaces;
using Dominio.Interfaces.InterfacesServicos;
using Entidades.Entidades;
using Entidades.Entidades.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Servicos
{
    public class AutoEscolaServico : IAutoEscolaServico
    {
        private readonly IAutoEscola _IAutoEscola;

        public AutoEscolaServico(IAutoEscola autoEscola)
        {
                _IAutoEscola = autoEscola;
        }
        public async Task AdicionarAutoEscola(AutoEscola AutoEscola)
        {
            var validarNome = AutoEscola.ValidarPropriedadeString(AutoEscola.NomeAutoEscola,"Nome da AutoEscola");
            var validarSenha = AutoEscola.ValidarPropriedadeString(AutoEscola.Senha, "Senha");
            if (validarNome && validarSenha)
            {
                await _IAutoEscola.Adicionar(AutoEscola);
            }
        }

        public async Task AtualizarAutoEscola(AutoEscola AutoEscola)
        {
            var validarNome = AutoEscola.ValidarPropriedadeString(AutoEscola.NomeAutoEscola, "Nome da AutoEscola");
            var validarSenha = AutoEscola.ValidarPropriedadeString(AutoEscola.Senha, "Senha");
            if (validarNome && validarSenha)
            {
                await _IAutoEscola.Atualizar(AutoEscola);
            }
        }

        public async Task<List<ViewModelAutoEscola>> BuscarAutoEscolaCustomizada()
        {
            var listaCustomizada = await _IAutoEscola.ListarAutoEscolasCustomizada();

            var retorno = (from AutoEscola in listaCustomizada
                           select new ViewModelAutoEscola
                           {
                               Id = AutoEscola.Id,
                               NomeAutoEscola =AutoEscola.NomeAutoEscola
                           }).ToList();
            return retorno;
        }
#warning buscar Auto Escolas
        public Task<List<AutoEscola>> BuscarAutoEscolas()
        {
            throw new NotImplementedException();
        }
    }
}
