using Dominio.Interfaces;
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
        
        public FormCarros()
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

        }
        private void FormCarros_FormClosed(object sender, FormClosedEventArgs e)
        {
            //carregar dados grid
            Application.Exit();
        }

        private void FormCarros_Load(object sender, EventArgs e)
        {
            // Manipula o evento de clique no botão na coluna "Ação"
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

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
                // Verifica se o clique ocorreu na coluna "Ação" e em uma linha válida
                if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Ação"].Index)
                {
                    // Obtém a célula na coluna "Modelo" da linha clicada
                    DataGridViewCell modeloCell = dataGridView1.Rows[e.RowIndex].Cells["Modelo"];

                    // Verifica se a célula e o valor não são null
                    if (modeloCell != null && modeloCell.Value != null)
                    {
                        string modelo = modeloCell.Value.ToString();

                        // Agora você pode usar a variável 'modelo' conforme necessário
                        MessageBox.Show("Modelo: " + modelo);
                    }
                    else
                    {
                        // Adicione um tratamento para o caso em que a célula ou o valor é null
                        MessageBox.Show("Erro: Célula ou valor de célula é null.");
                    }
                }
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
                    DataGridViewRow dr = dataGridView1.SelectedRows[0];

                    textModelo.Text = dr.Cells[0].Value.ToString();
                    textPlaca.Text = dr.Cells[1].Value.ToString();
                    textKmAtual.Text = dr.Cells[2].Value.ToString();
                    textOleo.Text = dr.Cells[3].Value.ToString();
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

                    atualizar.Cells[0].Value = textModelo.Text;
                    atualizar.Cells[1].Value = textPlaca.Text;
                    atualizar.Cells[2].Value = textKmAtual.Text;
                    atualizar.Cells[3].Value = textOleo.Text;

                    //aplicação atualizar inserir a entidade Veiculo
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

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