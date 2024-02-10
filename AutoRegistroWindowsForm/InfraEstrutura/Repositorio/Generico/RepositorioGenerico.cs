﻿using Dominio.Interfaces.Generico;
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
            .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AutoRegistroDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
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

        public async Task Atualizar(T Objeto)
        {
            using (var data = new Contexto(_optionBuilder))
            {
                data.Set<T>().Update(Objeto);
                await data.SaveChangesAsync();
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


        public async Task Excluir(T Objeto)
        {
            using (var data = new Contexto(_optionBuilder))
            {
                data.Set<T>().Remove(Objeto);
                await data.SaveChangesAsync();
            }
        }

        public async Task<List<T>> Listar()
        {
            using (var data = new Contexto(_optionBuilder))
            {
                return await data.Set<T>().AsNoTracking().ToListAsync();
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
