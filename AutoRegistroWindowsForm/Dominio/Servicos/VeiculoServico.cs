﻿using Dominio.Interfaces;
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
    public class VeiculoServico : IVeiculoServico
    {
        private readonly IVeiculo _iVeiculos;
        public VeiculoServico(IVeiculo veiculo)
        {
                _iVeiculos = veiculo;
        }
        public void  AdicionarVeiculo(Veiculo veiculo)
        {
            var validarModelo = veiculo.ValidarPropriedadeString(veiculo.Modelo, "Modelo");
            var validarPlaca = veiculo.ValidarPropriedadeString(veiculo.Placa, "Placa");
            var validarKmTrocaOleo = veiculo.ValidarPropriedadeString(veiculo.KmTrocaOleo.ToString(), "kmTrocaOleao");
            if (validarModelo && validarPlaca && validarKmTrocaOleo)
            {
                 _iVeiculos.Adicionar(veiculo);
            }
        }

        public void AtualizarVeiculo(Veiculo veiculo)
        {
            var validarModelo = veiculo.ValidarPropriedadeString(veiculo.Modelo, "Modelo");
            var validarPlaca = veiculo.ValidarPropriedadeString(veiculo.Placa, "Placa");
            var validarKmTrocaOleo = veiculo.ValidarPropriedadeString(veiculo.KmTrocaOleo.ToString(), "kmTrocaOleao");
            if (validarModelo && validarPlaca && validarKmTrocaOleo)
            {
                 _iVeiculos.Atualizar(veiculo);
            }
        }

        public async Task<List<Veiculo>> BuscarVeiculosPertoTrocarOleo()
        {                                                           
            return await _iVeiculos.ListarVeiculos(v => 2000 > (v.KmTrocaOleo - v.KmAtual));
        }

        public  List<ModelViewVeiculo> BuscarVeiculosCustomizada(int idAutoEscola)
        {
            var listarVeiculosCustomizada =  _iVeiculos.ListarVeiculosCustomizada(idAutoEscola);

            var retorno = (from Veiculo in listarVeiculosCustomizada
                           select new ModelViewVeiculo
                           {
                               Id = Veiculo.Id,
                               Modelo = Veiculo.Modelo,
                               Placa = Veiculo.Placa,
                               KmAtual = Veiculo.KmAtual,
                               KmTrocaOleo = Veiculo.KmTrocaOleo
                           }).ToList();
            return retorno;
        }
    }
}
