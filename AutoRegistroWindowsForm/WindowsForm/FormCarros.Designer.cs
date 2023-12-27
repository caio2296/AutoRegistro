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
            btnAcessar = new Button();
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
            // 
            // textModelo
            // 
            textModelo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textModelo.Location = new Point(84, 406);
            textModelo.Name = "textModelo";
            textModelo.Size = new Size(227, 27);
            textModelo.TabIndex = 4;
            textModelo.Text = "Modelo";
            textModelo.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCadastroCarros
            // 
            lblCadastroCarros.AutoSize = true;
            lblCadastroCarros.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastroCarros.Location = new Point(84, 337);
            lblCadastroCarros.Name = "lblCadastroCarros";
            lblCadastroCarros.Size = new Size(271, 38);
            lblCadastroCarros.TabIndex = 3;
            lblCadastroCarros.Text = "Cadastro de Carros:";
            // 
            // textOleo
            // 
            textOleo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textOleo.Location = new Point(404, 473);
            textOleo.Name = "textOleo";
            textOleo.Size = new Size(227, 27);
            textOleo.TabIndex = 5;
            textOleo.Text = "prox de Óleo(Km)";
            textOleo.TextAlign = HorizontalAlignment.Center;
            // 
            // textKmAtual
            // 
            textKmAtual.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textKmAtual.Location = new Point(404, 406);
            textKmAtual.Name = "textKmAtual";
            textKmAtual.Size = new Size(227, 27);
            textKmAtual.TabIndex = 6;
            textKmAtual.Text = "KmAtual";
            textKmAtual.TextAlign = HorizontalAlignment.Center;
            // 
            // textPlaca
            // 
            textPlaca.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textPlaca.Location = new Point(84, 473);
            textPlaca.Name = "textPlaca";
            textPlaca.Size = new Size(227, 27);
            textPlaca.TabIndex = 7;
            textPlaca.Text = "Placa";
            textPlaca.TextAlign = HorizontalAlignment.Center;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblModel.Location = new Point(84, 375);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(174, 28);
            lblModel.TabIndex = 8;
            lblModel.Text = "Modelo do carro:";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlaca.Location = new Point(84, 442);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(67, 28);
            lblPlaca.TabIndex = 9;
            lblPlaca.Text = "Placa:";
            // 
            // lblKmAtual
            // 
            lblKmAtual.AutoSize = true;
            lblKmAtual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblKmAtual.Location = new Point(404, 375);
            lblKmAtual.Name = "lblKmAtual";
            lblKmAtual.Size = new Size(105, 28);
            lblKmAtual.TabIndex = 10;
            lblKmAtual.Text = "Km Atual:";
            // 
            // lblOleo
            // 
            lblOleo.AutoSize = true;
            lblOleo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblOleo.Location = new Point(404, 442);
            lblOleo.Name = "lblOleo";
            lblOleo.Size = new Size(147, 28);
            lblOleo.TabIndex = 11;
            lblOleo.Text = "Troca de Óleo:";
            // 
            // btnAcessar
            // 
            btnAcessar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAcessar.Location = new Point(656, 416);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(353, 84);
            btnAcessar.TabIndex = 12;
            btnAcessar.Text = "Cadastrar";
            btnAcessar.UseVisualStyleBackColor = true;
            // 
            // FormCarros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 538);
            Controls.Add(btnAcessar);
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
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnAcessar;
    }
}