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

        public void Atualizar(Manutencao Objeto)
        {
           _manutencao.Atualizar(Objeto);
        }   

        public  void AtualizarManutencao(Manutencao manutencao)
        {
             _manutencaoServico.AtualizarManutencao(manutencao);
        }

        public List<Manutencao> BuscarManutencoes()
        {
            return  _manutencaoServico.BuscarManutencoes();
        }

        public  List<ViewModelManutencao> BuscarManutencoesCustomizadas(int idVeiculo)
        {
            return  _manutencaoServico.BuscarManutencoesCustomizadas(idVeiculo);
        }

        public  Manutencao BuscarPorId(int id)
        {
            return _manutencao.BuscarPorId(id);
        }

        public void Excluir(Manutencao Objeto)
        {
             _manutencao.Excluir(Objeto);
        }

        public List<Manutencao> Listar()
        {
            return  _manutencao.Listar();
        }
    }
}
