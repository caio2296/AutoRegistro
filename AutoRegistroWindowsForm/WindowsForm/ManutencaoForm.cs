using AutoRegistro.Controllers;
using AutoRegistro.Models;
using AutoRegistro.Token;
using Dominio.Interfaces;
using Dominio.Servicos;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace AutoRegistro
{
    public partial class ManutencaoForm : Form
    {

        public ManutencaoForm(ManutencaoController manutencaoController)
        {
            InitializeComponent();
           
        }

        private void ManutencaoForm_Load(object sender, EventArgs e)
        {
             var manutencaoController = Program.container.Resolve<ManutencaoController>();
             var manutencoes=manutencaoController.BuscarManutencoesCustomizadas(VeiculoModel.IdVeiculo);
                    
            foreach (var manutencao in manutencoes)
            {
               dataGridView1.Rows.Add(manutencao.Id, manutencao.NomePeca, manutencao.Fabricante, manutencao.DataDaCompra,
               manutencao.DataDaInstalacao,manutencao.Preco);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                EditarGrid(e);
                AtualizarGrid(e);
                DeletarGrid(e);
            }
            catch (Exception)
            {

                throw;

            }
        }

        private void EditarGrid(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Editar"].Index)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    DataGridViewRow dr = dataGridView1.Rows[rowIndex];

                    textPNome.Text = dr.Cells[1].Value.ToString();
                    txtFabricante.Text = dr.Cells[2].Value.ToString();
                    dateTimePickerCompra.Text = dr.Cells[3].Value.ToString();
                    dateTimePickerInstalacao.Text = dr.Cells[4].Value.ToString();
                    textPreco.Text = dr.Cells[5].Value.ToString();

                }
            }
        }

        private void AtualizarGrid(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Atualizar"].Index)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Atualizar")
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    DataGridViewRow atualizar = dataGridView1.Rows[rowIndex];

                    atualizar.Cells[1].Value = textPNome.Text;
                    atualizar.Cells[2].Value = txtFabricante.Text;
                    atualizar.Cells[3].Value = dateTimePickerCompra.Text;
                    atualizar.Cells[4].Value = dateTimePickerInstalacao.Text;
                    atualizar.Cells[5].Value = textPreco.Text;

                    var novaManutencao = new Manutencao
                    {
                        Id = int.Parse(atualizar.Cells[0].Value.ToString()),
                        NomePeca = atualizar.Cells[1].Value.ToString(),
                        Fabricante = atualizar.Cells[2].Value.ToString(),
                        DataDaCompra = DateTime.Parse(atualizar.Cells[3].Value.ToString()),
                        DataDaInstalacao = DateTime.Parse(atualizar.Cells[4].Value.ToString()),
                        Preco = decimal.Parse(atualizar.Cells[5].Value.ToString()),
                        IdVeiculo = VeiculoModel.IdVeiculo
                    };
                    var manutencaoController = Program.container.Resolve<ManutencaoController>();
                    manutencaoController.AtualizarManutencao(novaManutencao);
                    MessageBox.Show("Manutenção atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Manutenção não pode ser atualizado!");
                }

            }
        }

        private void DeletarGrid(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Deletar"].Index)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Deletar")
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    DataGridViewRow deletar = dataGridView1.Rows[rowIndex];

                    dataGridView1.Rows.Remove(deletar);
                    var manutencaoExcluir = new Manutencao
                    {      
                     Id = int.Parse(deletar.Cells[0].Value.ToString()),
                     NomePeca = deletar.Cells[1].Value.ToString(),
                     Fabricante = deletar.Cells[2].Value.ToString(),
                     DataDaCompra = DateTime.Parse(deletar.Cells[3].Value.ToString()),
                     DataDaInstalacao = DateTime.Parse( deletar.Cells[4].Value.ToString()),
                     Preco = decimal.Parse(deletar.Cells[5].Value.ToString()),
                     IdVeiculo= VeiculoModel.IdVeiculo 
                    };
                    var manutencaoController = Program.container.Resolve<ManutencaoController>();
                    manutencaoController.Excluir(manutencaoExcluir);
                }
            }
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (textPNome.Text != "" &&
               textPreco.Text != "" &&
               decimal.Parse(textPreco.Text) > 0 &&
               dateTimePickerCompra.Text != "" &&
               dateTimePickerInstalacao.Text != "" &&
               txtFabricante.Text !="")
            {
                string nome = textPNome.Text.ToUpper();
                string preco = textPreco.Text;
                string dataCompra = dateTimePickerCompra.Text;
                string dataInstalacao = dateTimePickerInstalacao.Text;
                string fabricante = txtFabricante.Text;

                var manutencaoNovo = new Manutencao
                {
                    NomePeca = nome,
                    Preco = decimal.Parse(preco.Replace(".",",")),
                    DataDaCompra = DateTime.Parse(dataCompra),
                    DataDaInstalacao = DateTime.Parse(dataInstalacao),
                    Fabricante=fabricante,
                    IdVeiculo = VeiculoModel.IdVeiculo,
                   
                };
                var manutencaoController = Program.container.Resolve<ManutencaoController>();

                dataGridView1.Rows.Clear();
                manutencaoController.AdicionarManutencao(manutencaoNovo);
                var manutencoes = manutencaoController
                    .BuscarManutencoesCustomizadas(VeiculoModel.IdVeiculo);

                foreach (var manutencao in manutencoes)
                {
                    dataGridView1.Rows.Add(manutencao.Id, manutencao.NomePeca, manutencao.Fabricante, manutencao.DataDaCompra,
                    manutencao.DataDaInstalacao, manutencao.Preco);
                }
                dataGridView1.Refresh();
                

                    MessageBox.Show("Manutenção cadastrado com sucesso!");


            }
            else if(textPreco.Text != "" &&
                    decimal.Parse(textPreco.Text) <= 0)
            {
                MessageBox.Show("Manutenção não pode ser cadastrado, insira um valor no preço!");
            }
            else
            {
                MessageBox.Show("Manutenção não pode ser cadastrado!");
            }
        }

        private void dateTimePickerComprar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblPreco_Click(object sender, EventArgs e)
        {

        }

        private void textPreco_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
