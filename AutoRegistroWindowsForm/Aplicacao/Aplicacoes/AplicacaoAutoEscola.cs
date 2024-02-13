using Aplicacao.Interfaces;
using Dominio.Interfaces;
using Dominio.Interfaces.InterfacesServicos;
using Entidades.Entidades;
using Entidades.Entidades.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Aplicacoes
{
    public class AplicacaoAutoEscola : IAplicacaoAutoEscola
    {
        private IAutoEscolaServico _autoEscolaServico;
        private IAutoEscola _autoEscola;
        public AplicacaoAutoEscola(IAutoEscolaServico autoEscolaServico, IAutoEscola autoEscola)
        {
                _autoEscola = autoEscola;
            _autoEscolaServico = autoEscolaServico;
        }
        public void Adicionar(AutoEscola Objeto)
        {
             _autoEscola.Adicionar(Objeto);
        }

        public void AdicionarAutoEscola(AutoEscola AutoEscola)
        {
             _autoEscolaServico.AdicionarAutoEscola(AutoEscola);
        }

        public async Task Atualizar(AutoEscola Objeto)
        {
            await _autoEscola.Atualizar(Objeto);
        }

        public async Task AtualizarAutoEscola(AutoEscola AutoEscola)
        {
            await _autoEscolaServico.AtualizarAutoEscola(AutoEscola);
        }

        public async Task<List<ViewModelAutoEscola>> BuscarAutoEscolaCustomizada()
        {
            return await _autoEscolaServico.BuscarAutoEscolaCustomizada();
        }

        public async Task<List<AutoEscola>> BuscarAutoEscolas()
        {
            return await _autoEscolaServico.BuscarAutoEscolas();
        }

        public  AutoEscola BuscarPorId(int id)
        {
            return  _autoEscola.BuscarPorId(id);
        }

        public void Excluir(AutoEscola Objeto)
        {
             _autoEscola.Excluir(Objeto);
        }

        public  bool ExisteAutoEscola(string nome, string senha)
        {
            return  _autoEscola.ExisteAutoEscola(nome, senha);
        }

        public async Task<List<AutoEscola>> Listar()
        {
            return await _autoEscola.Listar();
        }

        public string RetornarIdAutoEscola(string nome)
        {
            return  _autoEscola.RetornarIdAutoEscola(nome);
        }
    }
}
