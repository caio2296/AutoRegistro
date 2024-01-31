using System.IdentityModel.Tokens.Jwt;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
using Dominio.Interfaces;
using Unity;
using System.Threading.Tasks;
using AutoRegistro.Controllers;
using AutoRegistro.Models;

namespace AutoRegistro
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;


        private readonly IUnityContainer container;
        private readonly AutoEscolaController _autoEscolaController;
        private readonly UsuarioController _usuarioController;
        public Form1(IUnityContainer container,
            AutoEscolaController autoEscolaController,
            UsuarioController usuarioController)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.container = container ?? throw new ArgumentNullException(nameof(container));
            _autoEscolaController = autoEscolaController ?? throw new ArgumentNullException(nameof(autoEscolaController));
            _usuarioController= usuarioController ?? throw new ArgumentNullException(nameof(usuarioController));
        }

        public FormCarros FormCarrosInstance { get; set; }
        public ManutencaoForm FormManutencaoInstance { get; set; }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text != "" && textSenha.Text != "")
            {
                string nome = textUsuario.Text;
                string senha = textSenha.Text;
                var login = new Login
                {
                    Nome = nome,
                    Senha = senha
                };
                var tokenData = _autoEscolaController.CriarToken(login).Result;
                if (tokenData != null)
                {
                    this.Hide();
                    FormCarrosInstance.Show();
                }
                else
                {
                    textUsuario.Text = "";
                    textSenha.Text = "";
                    MessageBox.Show("Usuário não encontrado. Verifique suas credenciais.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}