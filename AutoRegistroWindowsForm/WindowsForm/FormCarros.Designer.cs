namespace AutoRegistro
{
    partial class FormCarros
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
            lblAutoEscola = new Label();
            textModelo = new TextBox();
            lblCadastroCarros = new Label();
            textOleo = new TextBox();
            textKmAtual = new TextBox();
            textPlaca = new TextBox();
            lblModel = new Label();
            lblPlaca = new Label();
            lblKmAtual = new Label();
            lblOleo = new Label();
            btnCadastrar = new Button();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            Placa = new DataGridViewTextBoxColumn();
            KmAtual = new DataGridViewTextBoxColumn();
            KmTroca = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Atualizar = new DataGridViewButtonColumn();
            Deletar = new DataGridViewButtonColumn();
            Manutenção = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblAutoEscola
            // 
            lblAutoEscola.AutoSize = true;
            lblAutoEscola.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAutoEscola.Location = new Point(33, 25);
            lblAutoEscola.Name = "lblAutoEscola";
            lblAutoEscola.Size = new Size(170, 38);
            lblAutoEscola.TabIndex = 1;
            lblAutoEscola.Text = "Auto Escola";
            lblAutoEscola.Click += lblAutoEscola_Click;
            // 
            // textModelo
            // 
            textModelo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textModelo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textModelo.Location = new Point(85, 405);
            textModelo.Name = "textModelo";
            textModelo.Size = new Size(227, 27);
            textModelo.TabIndex = 4;
            textModelo.Text = "Modelo";
            textModelo.TextAlign = HorizontalAlignment.Center;
            textModelo.TextChanged += textModelo_TextChanged;
            textModelo.Enter += text_Enter;
            // 
            // lblCadastroCarros
            // 
            lblCadastroCarros.AutoSize = true;
            lblCadastroCarros.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastroCarros.Location = new Point(85, 337);
            lblCadastroCarros.Name = "lblCadastroCarros";
            lblCadastroCarros.Size = new Size(271, 38);
            lblCadastroCarros.TabIndex = 3;
            lblCadastroCarros.Text = "Cadastro de Carros:";
            lblCadastroCarros.Click += lblCadastroCarros_Click;
            // 
            // textOleo
            // 
            textOleo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textOleo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textOleo.Location = new Point(405, 473);
            textOleo.MaxLength = 7;
            textOleo.Name = "textOleo";
            textOleo.Size = new Size(227, 27);
            textOleo.TabIndex = 5;
            textOleo.Text = "0000000";
            textOleo.TextAlign = HorizontalAlignment.Center;
            textOleo.TextChanged += textOleo_TextChanged;
            textOleo.KeyPress += textOleo_KeyPress;
            // 
            // textKmAtual
            // 
            textKmAtual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textKmAtual.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textKmAtual.Location = new Point(405, 405);
            textKmAtual.MaxLength = 7;
            textKmAtual.Name = "textKmAtual";
            textKmAtual.Size = new Size(227, 27);
            textKmAtual.TabIndex = 6;
            textKmAtual.Text = "000000";
            textKmAtual.TextAlign = HorizontalAlignment.Center;
            textKmAtual.TextChanged += textKmAtual_TextChanged;
            textKmAtual.KeyPress += textKmAtual_KeyPress;
            // 
            // textPlaca
            // 
            textPlaca.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textPlaca.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textPlaca.Location = new Point(85, 473);
            textPlaca.Name = "textPlaca";
            textPlaca.Size = new Size(227, 27);
            textPlaca.TabIndex = 7;
            textPlaca.Text = "Placa";
            textPlaca.TextAlign = HorizontalAlignment.Center;
            textPlaca.TextChanged += textPlaca_TextChanged;
            // 
            // lblModel
            // 
            lblModel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblModel.Location = new Point(85, 375);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(174, 28);
            lblModel.TabIndex = 8;
            lblModel.Text = "Modelo do carro:";
            lblModel.Click += lblModel_Click;
            // 
            // lblPlaca
            // 
            lblPlaca.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlaca.Location = new Point(85, 443);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(67, 28);
            lblPlaca.TabIndex = 9;
            lblPlaca.Text = "Placa:";
            lblPlaca.Click += lblPlaca_Click;
            // 
            // lblKmAtual
            // 
            lblKmAtual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblKmAtual.AutoSize = true;
            lblKmAtual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblKmAtual.Location = new Point(405, 375);
            lblKmAtual.Name = "lblKmAtual";
            lblKmAtual.Size = new Size(105, 28);
            lblKmAtual.TabIndex = 10;
            lblKmAtual.Text = "Km Atual:";
            lblKmAtual.Click += lblKmAtual_Click;
            // 
            // lblOleo
            // 
            lblOleo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblOleo.AutoSize = true;
            lblOleo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblOleo.Location = new Point(405, 443);
            lblOleo.Name = "lblOleo";
            lblOleo.Size = new Size(147, 28);
            lblOleo.TabIndex = 11;
            lblOleo.Text = "Troca de Óleo:";
            lblOleo.Click += lblOleo_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCadastrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(656, 419);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(353, 81);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Modelo, Placa, KmAtual, KmTroca, Editar, Atualizar, Deletar, Manutenção });
            dataGridView1.Location = new Point(1, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1049, 265);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 125;
            // 
            // Modelo
            // 
            Modelo.HeaderText = "Modelo";
            Modelo.MinimumWidth = 6;
            Modelo.Name = "Modelo";
            Modelo.ReadOnly = true;
            Modelo.Width = 125;
            // 
            // Placa
            // 
            Placa.HeaderText = "Placa";
            Placa.MinimumWidth = 6;
            Placa.Name = "Placa";
            Placa.ReadOnly = true;
            Placa.Width = 125;
            // 
            // KmAtual
            // 
            KmAtual.HeaderText = "KmAtual";
            KmAtual.MinimumWidth = 6;
            KmAtual.Name = "KmAtual";
            KmAtual.ReadOnly = true;
            KmAtual.Width = 125;
            // 
            // KmTroca
            // 
            KmTroca.HeaderText = "KmTroca";
            KmTroca.MinimumWidth = 6;
            KmTroca.Name = "KmTroca";
            KmTroca.ReadOnly = true;
            KmTroca.Width = 125;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            Editar.Width = 125;
            // 
            // Atualizar
            // 
            Atualizar.HeaderText = "Atualizar";
            Atualizar.MinimumWidth = 6;
            Atualizar.Name = "Atualizar";
            Atualizar.ReadOnly = true;
            Atualizar.Text = "Atualizar";
            Atualizar.UseColumnTextForButtonValue = true;
            Atualizar.Width = 125;
            // 
            // Deletar
            // 
            Deletar.HeaderText = "Deletar";
            Deletar.MinimumWidth = 6;
            Deletar.Name = "Deletar";
            Deletar.ReadOnly = true;
            Deletar.Text = "Deletar";
            Deletar.UseColumnTextForButtonValue = true;
            Deletar.Width = 125;
            // 
            // Manutenção
            // 
            Manutenção.HeaderText = "Manutenção";
            Manutenção.MinimumWidth = 6;
            Manutenção.Name = "Manutenção";
            Manutenção.ReadOnly = true;
            Manutenção.Text = "Manutenção";
            Manutenção.UseColumnTextForButtonValue = true;
            Manutenção.Width = 125;
            // 
            // FormCarros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 539);
            Controls.Add(dataGridView1);
            Controls.Add(btnCadastrar);
            Controls.Add(lblOleo);
            Controls.Add(lblKmAtual);
            Controls.Add(lblPlaca);
            Controls.Add(lblModel);
            Controls.Add(textPlaca);
            Controls.Add(textKmAtual);
            Controls.Add(textOleo);
            Controls.Add(textModelo);
            Controls.Add(lblCadastroCarros);
            Controls.Add(lblAutoEscola);
            Name = "FormCarros";
            Text = "FormCarros";
            Load += FormCarros_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void TextKmAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblAutoEscola;
        private TextBox textModelo;
        private Label lblCadastroCarros;
        private TextBox textOleo;
        private TextBox textKmAtual;
        private TextBox textPlaca;
        private Label lblModel;
        private Label lblPlaca;
        private Label lblKmAtual;
        private Label lblOleo;
        private Button btnCadastrar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Placa;
        private DataGridViewTextBoxColumn KmAtual;
        private DataGridViewTextBoxColumn KmTroca;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Atualizar;
        private DataGridViewButtonColumn Deletar;
        private DataGridViewButtonColumn Manutenção;
    }
}