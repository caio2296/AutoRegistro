﻿using Dominio.Interfaces.Generico;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IVeiculo:IGenerico<Veiculo>
    {
        Task<List<Veiculo>> ListarVeiculos(Expression<Func<Veiculo, bool>> exVeiculo);
        List<Veiculo> ListarVeiculosCustomizada(int idAutoEscola);

        bool ExisteVeiculo(string placa);
    }
}
