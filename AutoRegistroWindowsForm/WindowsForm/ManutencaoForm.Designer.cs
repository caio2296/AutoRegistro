namespace AutoRegistro
{
    partial class ManutencaoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnCadastrar = new Button();
            lblPreco = new Label();
            lblDataCompra = new Label();
            lblPNome = new Label();
            textPreco = new TextBox();
            textPNome = new TextBox();
            lblCadastroManutencao = new Label();
            lblAutoEscola = new Label();
            dateTimePickerCompra = new DateTimePicker();
            dateTimePickerInstalacao = new DateTimePicker();
            lblInstalacao = new Label();
            lblFabricante = new Label();
            txtFabricante = new TextBox();
            Id = new DataGridViewTextBoxColumn();
            Peça = new DataGridViewTextBoxColumn();
            Fabricante = new DataGridViewTextBoxColumn();
            DataDaCompra = new DataGridViewTextBoxColumn();
            DataDaInstalacao = new DataGridViewTextBoxColumn();
            Preço = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Atualizar = new DataGridViewButtonColumn();
            Deletar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Peça, Fabricante, DataDaCompra, DataDaInstalacao, Preço, Editar, Atualizar, Deletar });
            dataGridView1.Location = new Point(21, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1049, 265);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCadastrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(792, 405);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(278, 81);
            btnCadastrar.TabIndex = 24;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // lblPreco
            // 
            lblPreco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPreco.Location = new Point(288, 361);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(70, 28);
            lblPreco.TabIndex = 22;
            lblPreco.Text = "Preço:";
            lblPreco.Click += lblPreco_Click;
            // 
            // lblDataCompra
            // 
            lblDataCompra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblDataCompra.AutoSize = true;
            lblDataCompra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDataCompra.Location = new Point(34, 427);
            lblDataCompra.Name = "lblDataCompra";
            lblDataCompra.Size = new Size(170, 28);
            lblDataCompra.TabIndex = 21;
            lblDataCompra.Text = "Data da Compra:";
            // 
            // lblPNome
            // 
            lblPNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblPNome.AutoSize = true;
            lblPNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPNome.Location = new Point(34, 361);
            lblPNome.Name = "lblPNome";
            lblPNome.Size = new Size(152, 28);
            lblPNome.TabIndex = 20;
            lblPNome.Text = "Nome da Peça:";
            // 
            // textPreco
            // 
            textPreco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textPreco.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textPreco.Location = new Point(288, 391);
            textPreco.Name = "textPreco";
            textPreco.Size = new Size(227, 27);
            textPreco.TabIndex = 18;
            textPreco.Text = "Preço";
            textPreco.TextAlign = HorizontalAlignment.Center;
            textPreco.TextChanged += textPreco_TextChanged;
            // 
            // textPNome
            // 
            textPNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textPNome.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textPNome.Location = new Point(34, 391);
            textPNome.Name = "textPNome";
            textPNome.Size = new Size(227, 27);
            textPNome.TabIndex = 16;
            textPNome.Text = "Nome da Peça";
            textPNome.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCadastroManutencao
            // 
            lblCadastroManutencao.AutoSize = true;
            lblCadastroManutencao.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastroManutencao.Location = new Point(34, 323);
            lblCadastroManutencao.Name = "lblCadastroManutencao";
            lblCadastroManutencao.Size = new Size(352, 38);
            lblCadastroManutencao.TabIndex = 15;
            lblCadastroManutencao.Text = "Cadastro de Manutenção:";
            // 
            // lblAutoEscola
            // 
            lblAutoEscola.AutoSize = true;
            lblAutoEscola.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAutoEscola.Location = new Point(53, 11);
            lblAutoEscola.Name = "lblAutoEscola";
            lblAutoEscola.Size = new Size(170, 38);
            lblAutoEscola.TabIndex = 14;
            lblAutoEscola.Text = "Auto Escola";
            // 
            // dateTimePickerCompra
            // 
            dateTimePickerCompra.Format = DateTimePickerFormat.Short;
            dateTimePickerCompra.Location = new Point(34, 458);
            dateTimePickerCompra.Name = "dateTimePickerCompra";
            dateTimePickerCompra.Size = new Size(227, 27);
            dateTimePickerCompra.TabIndex = 26;
            dateTimePickerCompra.ValueChanged += dateTimePickerComprar_ValueChanged;
            // 
            // dateTimePickerInstalacao
            // 
            dateTimePickerInstalacao.Format = DateTimePickerFormat.Short;
            dateTimePickerInstalacao.Location = new Point(288, 459);
            dateTimePickerInstalacao.Name = "dateTimePickerInstalacao";
            dateTimePickerInstalacao.Size = new Size(227, 27);
            dateTimePickerInstalacao.TabIndex = 28;
            // 
            // lblInstalacao
            // 
            lblInstalacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblInstalacao.AutoSize = true;
            lblInstalacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInstalacao.Location = new Point(288, 428);
            lblInstalacao.Name = "lblInstalacao";
            lblInstalacao.Size = new Size(193, 28);
            lblInstalacao.TabIndex = 27;
            lblInstalacao.Text = "Data da Instalação:";
            // 
            // lblFabricante
            // 
            lblFabricante.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblFabricante.AutoSize = true;
            lblFabricante.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFabricante.Location = new Point(546, 402);
            lblFabricante.Name = "lblFabricante";
            lblFabricante.Size = new Size(115, 28);
            lblFabricante.TabIndex = 30;
            lblFabricante.Text = "Fabricante:";
            // 
            // txtFabricante
            // 
            txtFabricante.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtFabricante.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtFabricante.Location = new Point(546, 432);
            txtFabricante.Name = "txtFabricante";
            txtFabricante.Size = new Size(227, 27);
            txtFabricante.TabIndex = 29;
            txtFabricante.Text = "Fabricante";
            txtFabricante.TextAlign = HorizontalAlignment.Center;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // Peça
            // 
            Peça.HeaderText = "Peça";
            Peça.MinimumWidth = 6;
            Peça.Name = "Peça";
            Peça.ReadOnly = true;
            Peça.Width = 125;
            // 
            // Fabricante
            // 
            Fabricante.HeaderText = "Fabricante";
            Fabricante.MinimumWidth = 6;
            Fabricante.Name = "Fabricante";
            Fabricante.ReadOnly = true;
            Fabricante.Width = 125;
            // 
            // DataDaCompra
            // 
            DataDaCompra.HeaderText = "DataCompra";
            DataDaCompra.MinimumWidth = 6;
            DataDaCompra.Name = "DataDaCompra";
            DataDaCompra.ReadOnly = true;
            DataDaCompra.Width = 125;
            // 
            // DataDaInstalacao
            // 
            DataDaInstalacao.HeaderText = "DataInstalação";
            DataDaInstalacao.MinimumWidth = 6;
            DataDaInstalacao.Name = "DataDaInstalacao";
            DataDaInstalacao.ReadOnly = true;
            DataDaInstalacao.Width = 125;
            // 
            // Preço
            // 
            Preço.HeaderText = "Preço";
            Preço.MinimumWidth = 6;
            Preço.Name = "Preço";
            Preço.ReadOnly = true;
            Preço.Width = 125;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Text = "Editar";
            Editar.Width = 125;
            // 
            // Atualizar
            // 
            Atualizar.HeaderText = "Atualizar";
            Atualizar.MinimumWidth = 6;
            Atualizar.Name = "Atualizar";
            Atualizar.ReadOnly = true;
            Atualizar.Text = "Atualizar";
            Atualizar.Width = 125;
            // 
            // Deletar
            // 
            Deletar.HeaderText = "Deletar";
            Deletar.MinimumWidth = 6;
            Deletar.Name = "Deletar";
            Deletar.ReadOnly = true;
            Deletar.Text = "Deletar";
            Deletar.Width = 125;
            // 
            // ManutencaoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 497);
            Controls.Add(lblFabricante);
            Controls.Add(txtFabricante);
            Controls.Add(dateTimePickerInstalacao);
            Controls.Add(lblInstalacao);
            Controls.Add(dateTimePickerCompra);
            Controls.Add(dataGridView1);
            Controls.Add(btnCadastrar);
            Controls.Add(lblPreco);
            Controls.Add(lblDataCompra);
            Controls.Add(lblPNome);
            Controls.Add(textPreco);
            Controls.Add(textPNome);
            Controls.Add(lblCadastroManutencao);
            Controls.Add(lblAutoEscola);
            Name = "ManutencaoForm";
            Text = "ManutencaoForm";
            Load += ManutencaoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnCadastrar;
        private Label lblPreco;
        private Label lblDataCompra;
        private Label lblPNome;
        private TextBox textPreco;
        private TextBox textPNome;
        private Label lblCadastroManutencao;
        private Label lblAutoEscola;
        private DateTimePicker dateTimePickerCompra;
        private DateTimePicker dateTimePickerInstalacao;
        private Label lblInstalacao;
        private Label lblFabricante;
        private TextBox txtFabricante;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Peça;
        private DataGridViewTextBoxColumn Fabricante;
        private DataGridViewTextBoxColumn DataDaCompra;
        private DataGridViewTextBoxColumn DataDaInstalacao;
        private DataGridViewTextBoxColumn Preço;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Atualizar;
        private DataGridViewButtonColumn Deletar;
    }
}