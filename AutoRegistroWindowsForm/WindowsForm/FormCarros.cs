using AutoRegistro.Controllers;
using AutoRegistro.Models;
using AutoRegistro.Token;
using Dominio.Interfaces;
using Dominio.Interfaces.Generico;
using Dominio.Servicos;
using Entidades.Entidades;
using Entidades.Entidades.ViewModel;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Xml.Linq;
using Unity;

namespace AutoRegistro
{
    public partial class FormCarros : Form
    {
        private readonly VeiculoController _veiculoController;
        private readonly AutoEscolaController _autoEscolaController;
        private readonly ManutencaoController _manutencaoController;

        public FormCarros(VeiculoController veiculoController,
            AutoEscolaController autoEscolaController,
            ManutencaoController manutencaoController)
        {
            InitializeComponent();
            this.lblCadastroCarros.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.FormClosed += FormCarros_FormClosed;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            textModelo.Enter += text_Enter;
            textKmAtual.Enter += text_Enter;
            textKmAtual.MaxLength = 7;
            textOleo.Enter += text_Enter;
            textOleo.MaxLength = 7;
            textPlaca.Enter += text_Enter;
            dataGridView1.ScrollBars = ScrollBars.Both;
            dataGridView1.AutoGenerateColumns = false;

            _veiculoController = veiculoController ?? throw new ArgumentNullException(nameof(veiculoController));
            _autoEscolaController = autoEscolaController ?? throw new ArgumentException(nameof(autoEscolaController));
            _manutencaoController = manutencaoController ?? throw new ArgumentException(nameof(manutencaoController));
        }
        public Form1 MainFormInstance { get; set; }
        private void FormCarros_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormCarros_Load(object sender, EventArgs e)
        {
            ViewModelAutoEscola viewModel =
                 _autoEscolaController.BuscarPorId(int.Parse(ApplicationState.TokenData.IdUsuario));
            lblAutoEscola.Text = viewModel.NomeAutoEscola;
            // Manipula o evento de clique no botão na coluna "Ação"
            //dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            var veiculos = _veiculoController
                                           .BuscarVeiculosCustomizada(int.Parse(ApplicationState.TokenData.IdUsuario));
            foreach (var veiculo in veiculos)
            {
                dataGridView1.Rows.Add(veiculo.Id,veiculo.Modelo, veiculo.Placa, veiculo.KmAtual,
               veiculo.KmTrocaOleo);
            }
        }

        private void text_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            switch (textBox.Text)
            {
                case "Modelo":
                    textBox.Text = string.Empty; // Limpar o TextBox
                    break;
                case "KmAtual":
                    textBox.Text = string.Empty;
                    break;
                case "prox de Óleo(Km)":
                    textBox.Text = string.Empty;
                    break;
                case "Placa":
                    textBox.Text = string.Empty;
                    break;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                EditarGrid(e);
                AtualizarGrid(e);
                DeletarGrid(e);
                ManutencaoGrid(e);
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

                    dataGridView1.Rows[rowIndex].Selected = true;

                    textModelo.Text = dr.Cells[1].Value.ToString();
                    textPlaca.Text = dr.Cells[2].Value.ToString();
                    textKmAtual.Text = dr.Cells[3].Value.ToString();
                    textOleo.Text = dr.Cells[4].Value.ToString();

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

                    atualizar.Cells[1].Value = textModelo.Text;
                    atualizar.Cells[2].Value = textPlaca.Text;
                    atualizar.Cells[3].Value = textKmAtual.Text;
                    atualizar.Cells[4].Value = textOleo.Text;
                    var novoVeiculo = new Veiculo
                    {
                        Id = int.Parse(atualizar.Cells[0].Value.ToString()),
                        Modelo = atualizar.Cells[1].Value.ToString(),
                        Placa = atualizar.Cells[2].Value.ToString(),
                        KmAtual = int.Parse(atualizar.Cells[3].Value.ToString()),
                        KmTrocaOleo = int.Parse(atualizar.Cells[4].Value.ToString())
                    };
                    _veiculoController.AtualizarVeiculo(novoVeiculo);
                    MessageBox.Show("Veiculo atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Veículo não pode ser atualizado!");
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
                    var veiculoExcluir = new Veiculo
                    {
                        Id = int.Parse(deletar.Cells[0].Value.ToString()),
                        Modelo = deletar.Cells[1].Value.ToString(),
                        Placa = deletar.Cells[2].Value.ToString(),
                        KmAtual = int.Parse(deletar.Cells[3].Value.ToString()),
                        KmTrocaOleo = int.Parse(deletar.Cells[4].Value.ToString()),
                        IdAutoEscola = int.Parse(ApplicationState.TokenData.IdUsuario)
                    };
                    var manutencaoController = Program.container.Resolve<ManutencaoController>();
                    var manutencoes = manutencaoController.BuscarManutencoesCustomizadas(veiculoExcluir.Id);
                    foreach (var manutencao in manutencoes)
                    {
                        var manu = new Manutencao
                        {
                            Id = manutencao.Id,
                            NomePeca = manutencao.NomePeca,
                            Preco = manutencao.Preco,
                            DataDaCompra = manutencao.DataDaCompra,
                            DataDaInstalacao = manutencao.DataDaInstalacao,
                            Fabricante = manutencao.Fabricante,
                            IdVeiculo = manutencao.IdVeiculo
                        };
                        manutencaoController.Excluir(manu);
                    }
                    _veiculoController.Excluir(veiculoExcluir);
                }
            }
        }

        private void ManutencaoGrid(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Manutenção"].Index)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Manutenção")
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    DataGridViewRow manutencao = dataGridView1.Rows[rowIndex];
                    //pesquisar pelo id do veiculo a lista de manutenções 
                    VeiculoModel.IdVeiculo = int.Parse(manutencao.Cells[0].Value.ToString());


                    var manutencaoController = Program.container.Resolve<ManutencaoController>();
                    

                    manutencaoController.BuscarManutencoesCustomizadas(VeiculoModel.IdVeiculo);
                    

                    if (MainFormInstance.FormManutencaoInstance != null)
                    {
                        MainFormInstance.FormManutencaoInstance.Close();
                        MainFormInstance.FormManutencaoInstance.Dispose();
                        MainFormInstance.FormManutencaoInstance = null;
                    }

                    ManutencaoForm formManutencao = new ManutencaoForm(manutencaoController);
                    MainFormInstance.FormManutencaoInstance = formManutencao;
                    formManutencao.Show();
                }
            }
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (textModelo.Text != "" &&
                textPlaca.Text != "" &&
                textOleo.Text != "" &&
                textKmAtual.Text != "")
            {
                string modelo = textModelo.Text.ToUpper();
                string placa = textPlaca.Text.ToUpper();
                string oleo = textOleo.Text;
                string kmAtual = textKmAtual.Text;

                var veiculoNovo = new Veiculo
                {
                    Modelo = modelo,
                    Placa = placa,
                    KmTrocaOleo = int.Parse(oleo),
                    KmAtual = int.Parse(kmAtual),
                    IdAutoEscola = int.Parse(ApplicationState.TokenData.IdUsuario)
                };

                if (!_veiculoController.ExisteVeiculo(veiculoNovo.Placa))
                {
                    dataGridView1.Rows.Clear();
                    _veiculoController.AdicionarVeiculo(veiculoNovo);
                    var veiculos = _veiculoController
                                              .BuscarVeiculosCustomizada(int.Parse(ApplicationState.TokenData.IdUsuario));

                    foreach (var veiculo in veiculos)
                    {
                        dataGridView1.Rows.Add(veiculo.Id,veiculo.Modelo, veiculo.Placa, veiculo.KmAtual,
                       veiculo.KmTrocaOleo);
                    }
                    dataGridView1.Refresh();
                }
                else
                {
                    MessageBox.Show("Veiculo ja existe, e não pode ser cadastrado!");
                }

            }
        }

        private void lblAutoEscola_Click(object sender, EventArgs e)
        {

        }

        private void lblCadastroCarros_Click(object sender, EventArgs e)
        {
        }

        private void lblModel_Click(object sender, EventArgs e)
        {
        }

        private void textModelo_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblPlaca_Click(object sender, EventArgs e)
        {
        }

        private void textPlaca_TextChanged(object sender, EventArgs e)
        {
        }

        private void textOleo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textOleo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void lblOleo_Click(object sender, EventArgs e)
        {
        }

        private void textKmAtual_TextChanged(object sender, EventArgs e)
        {
        }

        private void textKmAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void lblKmAtual_Click(object sender, EventArgs e)
        {
        }
    }
}