using Dominio.Interfaces;
using Entidades.Entidades;
using InfraEstrutura.Configuracao;
using InfraEstrutura.Repositorio.Generico;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraEstrutura.Repositorio
{
    public class RepositorioUsuario : RepositorioGenerico<Usuario>, IUsuario
    {
        private readonly DbContextOptions<Contexto> _optionsBuilder;
        public RepositorioUsuario()
        {
            _optionsBuilder = new DbContextOptions<Contexto>();
        }
        public async Task<bool> AdicionarUsuario(string nome, string email, string senha)
        {
            try
            {
                using (var banco = new Contexto(_optionsBuilder))
                {
                    await banco.usuarios.AddAsync(new Usuario
                    {
                        UserName = email,
                        PasswordHash = senha
                    });
                    await banco.SaveChangesAsync();
                }
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public async Task<bool> ExisteUsuario(string email, string senha)
        {
            try
            {
                using (var data = new Contexto(_optionsBuilder))
                {
                    return await data.usuarios.
                          Where(u => u.Email.Equals(email) && u.PasswordHash.Equals(senha))
                          .AsNoTracking()
                          .AnyAsync();

                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<string> RetornarIdUsuario(string email)
        {
            try
            {
                using (var data = new Contexto(_optionsBuilder))
                {
                    var usuario = await data.usuarios.
                          Where(u => u.Email.Equals(email))
                          .AsNoTracking()
                          .FirstOrDefaultAsync();

                    return usuario.Id;

                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public Task<string> RetornarTipoUsuario(string email)
        {
            throw new NotImplementedException();
#if DEBUG
            //    try
            //    {
            //        using (var data = new Contexto(_optionsBuilder))
            //        {
            //            var usuario = await data.User.Where(u => u.Email.Equals(email))
            //                .AsNoTracking()
            //                .FirstOrDefaultAsync();
            //            if (usuario.Tipo == TipoUsuario.Administrador)
            //            {
            //                return "Administrador";
            //            }
            //            else if (usuario.Tipo == TipoUsuario.Comum)
            //            {
            //                return "Comum";
            //            }
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        return string.Empty;
            //    }
            //    return string.Empty;
            //}
#endif

        }
}
