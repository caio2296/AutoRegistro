using Dominio.Interfaces;
using Entidades.Entidades;
using InfraEstrutura.Configuracao;
using InfraEstrutura.Repositorio.Generico;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InfraEstrutura.Repositorio
{
    public class RepositorioAutoEscola : RepositorioGenerico<AutoEscola>, IAutoEscola
    {
        private readonly DbContextOptions<Contexto> _optionsBuilder;
        public RepositorioAutoEscola()
        {
                _optionsBuilder= new DbContextOptions<Contexto>();
        }
        public List<AutoEscola> ListarAutoEscola(Expression<Func<AutoEscola, bool>> exAutoEscola)
        {
            using (var banco = new Contexto(_optionsBuilder))
            {
                return  banco.autoEscolas.Where(exAutoEscola).AsNoTracking().ToList();
            }
        }

        public List<AutoEscola> ListarAutoEscolasCustomizada()
        {
            using (var banco = new Contexto(_optionsBuilder))
            {
                var listarAutoEscola = (from AutoEscola in banco.autoEscolas
                                        select new AutoEscola
                                        {
                                            Id=AutoEscola.Id,
                                            NomeAutoEscola=AutoEscola.NomeAutoEscola,
                                            Senha =AutoEscola.Senha
                                        }).AsNoTracking().ToList();
                return listarAutoEscola;
            }
        }
        public bool ExisteAutoEscola(string nome, string senha)
        {
            try
            {
                using (var data = new Contexto(_optionsBuilder))
                {
                    return  data.autoEscolas.
                          Where(u => u.NomeAutoEscola.Equals(nome) && u.Senha.Equals(senha))
                          .AsNoTracking()
                          .Any();

                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string RetornarIdAutoEscola(string nome)
        {
            try
            {
                using (var data = new Contexto(_optionsBuilder))
                {
                    var autoEscola =  data.autoEscolas.
                          Where(u => u.NomeAutoEscola.Equals(nome))
                          .AsNoTracking()
                          .FirstOrDefault();

                    return autoEscola.Id.ToString();

                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

    }
}
