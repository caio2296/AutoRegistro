using AutoRegistro.Controllers;
using AutoRegistro.Models;
using AutoRegistro.Token;
using Dominio.Interfaces;
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
            textOleo.Enter += text_Enter;
            textPlaca.Enter += text_Enter;
            dataGridView1.ScrollBars = ScrollBars.Both;

            _veiculoController = veiculoController ?? throw new ArgumentNullException(nameof(veiculoController));
            _autoEscolaController = autoEscolaController ?? throw new ArgumentException(nameof(autoEscolaController));
            _manutencaoController= manutencaoController ?? throw new ArgumentException(nameof(manutencaoController));
        }
        public Form1 MainFormInstance { get; set; }
        private void FormCarros_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormCarros_Load(object sender, EventArgs e)
        {
            ViewModelAutoEscola viewModel =
                _autoEscolaController.BuscarPorId(int.Parse(ApplicationState.TokenData.IdUsuario)).Result;
            lblAutoEscola.Text = viewModel.NomeAutoEscola;
            // Manipula o evento de clique no botão na coluna "Ação"
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DataSource = _veiculoController
                                           .BuscarVeiculosCustomizada(int.Parse(ApplicationState.TokenData.IdUsuario));

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
                    DataGridViewRow dr = dataGridView1.SelectedRows[0];

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
                    DataGridViewRow atualizar = dataGridView1.SelectedRows[0];

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
                }
            }
        }

        private void DeletarGrid(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Deletar"].Index)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Deletar")
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                    //Deletar aplicação 
                }
            }
        }

        private void ManutencaoGrid(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Manuteção"].Index)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Manutenção")
                {
                    DataGridViewRow dr = dataGridView1.SelectedRows[0];
                    //pesquisar pelo id do veiculo a lista de manutenções 
                    VeiculoModel.IdVeiculo = int.Parse(dr.Cells[0].Value.ToString());

                    ManutencaoForm formManutencao = MainFormInstance.FormManutencaoInstance;

                    formManutencao.Show(); 
                }
            }
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (textModelo.Text != "" &&
                textPlaca.Text != ""  &&
                textOleo.Text  != ""  &&
                textKmAtual.Text !="")
            {
                string modelo = textModelo.Text;
                string placa = textPlaca.Text;
                string oleo = textOleo.Text;
                string kmAtual = textKmAtual.Text;

                var veiculoNovo = new Veiculo
                {
                    Modelo = modelo,
                    Placa = placa,
                    KmTrocaOleo = int.Parse(oleo),
                    KmAtual = int.Parse(kmAtual)
                };

               await _veiculoController.AdicionarVeiculo(veiculoNovo);
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

        private void lblOleo_Click(object sender, EventArgs e)
        {
        }

        private void textKmAtual_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblKmAtual_Click(object sender, EventArgs e)
        {
        }
    }
}