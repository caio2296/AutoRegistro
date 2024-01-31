using AutoRegistro.Controllers;
using AutoRegistro.Models;
using Dominio.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRegistro
{
    public partial class ManutencaoForm : Form
    {
        private readonly ManutencaoController _manutencaoController;
        public ManutencaoForm(ManutencaoController manutencaoController)
        {
            InitializeComponent();
            _manutencaoController = manutencaoController ?? throw new ArgumentException(nameof(manutencaoController));
        }

        private void ManutencaoForm_Load(object sender, EventArgs e)
        {
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DataSource = _manutencaoController.BuscarManutencoesCustomizadas(VeiculoModel.IdVeiculo);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
