namespace AutoRegistro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            lblSenha = new Label();
            textUsuario = new TextBox();
            textSenha = new TextBox();
            btnAcessar = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.Location = new Point(217, 76);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(149, 38);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "USUÁRIO:";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSenha.Location = new Point(217, 193);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(119, 38);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "SENHA:";
            // 
            // textUsuario
            // 
            textUsuario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textUsuario.Location = new Point(217, 126);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(227, 27);
            textUsuario.TabIndex = 2;
            textUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // textSenha
            // 
            textSenha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textSenha.Location = new Point(217, 248);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(227, 27);
            textSenha.TabIndex = 3;
            textSenha.TextAlign = HorizontalAlignment.Center;
            textSenha.UseSystemPasswordChar = true;
            textSenha.PasswordChar = '*';
            // 
            // btnAcessar
            // 
            btnAcessar.Location = new Point(267, 311);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(130, 62);
            btnAcessar.TabIndex = 4;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 427);
            Controls.Add(btnAcessar);
            Controls.Add(textSenha);
            Controls.Add(textUsuario);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Name = "Form1";
            Text = "AutoRegistro";
            ResumeLayout(false);
            PerformLayout();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblUsuario;
        private Label lblSenha;
        private TextBox textUsuario;
        private TextBox textSenha;
        private Button btnAcessar;
    }
}