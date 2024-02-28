using Dominio.Interfaces.Generico;
using InfraEstrutura.Configuracao;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InfraEstrutura.Repositorio.Generico
{
    public class RepositorioGenerico<T> : IGenerico<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<Contexto> _optionBuilder;

        public RepositorioGenerico()
        {
            _optionBuilder = new DbContextOptionsBuilder<Contexto>()
            .UseSqlServer("Server=tcp:profilecaio.database.windows.net,1433;Initial Catalog=AutoRegistro;Persist Security Info=False;User ID=caio;Password=zxcasd384!A;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
            .Options;
        }

        public void Adicionar(T Objeto)
        {
            using (var data = new Contexto(_optionBuilder))
            {
                 data.Set<T>().Add(Objeto);
                 data.SaveChanges();
            }
        }

        public void  Atualizar(T Objeto)
        {
            using (var data = new Contexto(_optionBuilder))
            {
                data.Set<T>().Update(Objeto);
                data.SaveChanges();
            }
        }

        public  T? BuscarPorId(int id)
        {
            using (var data = new Contexto(_optionBuilder))
            {
                return  data.Set<T>()
                    .Find(id);
            }
        }


        public void Excluir(T Objeto)
        {
            using (var data = new Contexto(_optionBuilder))
            {
                data.Set<T>().Remove(Objeto);
                data.SaveChanges();
            }
        }

        public List<T> Listar()
        {
            using (var data = new Contexto(_optionBuilder))
            {
                return data.Set<T>().AsNoTracking().ToList();
            }
        }

        #region Disposed https://learn.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose
        // To detect redundant calls
        private bool _disposedValue;

        // Instantiate a SafeHandle instance.
        private SafeHandle? _safeHandle = new SafeFileHandle(IntPtr.Zero, true);

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _safeHandle?.Dispose();
                    _safeHandle = null;
                }

                _disposedValue = true;
            }
        }
        #endregion
    }
}
