using Aplicacao.Interfaces;
using Dominio.Interfaces;
using Dominio.Interfaces.InterfacesServicos;
using Entidades.Entidades;
using Entidades.Entidades.ViewModel;

namespace Aplicacao.Aplicacoes
{
    public class AplicacaoManutencao : IAplicacaoManutencao
    {
        private IManutencaoServico _manutencaoServico;
        private IManutencao _manutencao;

        public AplicacaoManutencao(IManutencaoServico manutencaoServico, IManutencao manutencao)
        {
                _manutencaoServico = manutencaoServico;
                _manutencao = manutencao;
        }
        public void Adicionar(Manutencao Objeto)
        {
             _manutencao.Adicionar(Objeto);
        }

        public void  AdicionarManutencao(Manutencao manutencao)
        {
             _manutencaoServico.AdicionarManutencao(manutencao);
        }

        public async Task Atualizar(Manutencao Objeto)
        {
          await _manutencao.Atualizar(Objeto);
        }   

        public async Task AtualizarManutencao(Manutencao manutencao)
        {
            await _manutencaoServico.AtualizarManutencao(manutencao);
        }

        public async Task<List<Manutencao>> BuscarManutencoes()
        {
            return await _manutencaoServico.BuscarManutencoes();
        }

        public async Task<List<ViewModelManutencao>> BuscarManutencoesCustomizadas(int idVeiculo)
        {
            return await _manutencaoServico.BuscarManutencoesCustomizadas(idVeiculo);
        }

        public  Manutencao BuscarPorId(int id)
        {
            return _manutencao.BuscarPorId(id);
        }

        public async Task Excluir(Manutencao Objeto)
        {
            await _manutencao.Excluir(Objeto);
        }

        public async Task<List<Manutencao>> Listar()
        {
            return await _manutencao.Listar();
        }
    }
}
