using System.IdentityModel.Tokens.Jwt;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
using Dominio.Interfaces;
using Unity;
using System.Threading.Tasks;
using AutoRegistro.Controllers;

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
        public Form1(IUnityContainer container)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.container = container ?? throw new ArgumentNullException(nameof(container));

        }

        public FormCarros FormCarrosInstance { get; set; }

        private async void btnAcessar_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text != "" && textSenha.Text != "")
            {

                //using (con = new SqlConnection(cs))
                //{
                //    con.Open();
                //    cmd = new SqlCommand($"Select id from AutoEscola where NomeAuto={textUsuario.Text}, Senha={textSenha.Text}");
                //    using (SqlDataReader reader = cmd.ExecuteReader())
                //    {
                //        if (reader.HasRows)
                //        {
                //            while (reader.Read())
                //            {
                //                int idAutoEscola = reader.GetInt32(reader.GetOrdinal("id"));
                //                // Aqui você pode acessar outras colunas, se necessário
                //                // Exemplo: string nome = reader.GetString(reader.GetOrdinal("nome"));

                //                //Console.WriteLine($"ID: {id}");
                //            }
                //        }
                //        else
                //        {
                //            //usuario não encontrado
                //        }

                //    }

                //}
                var autoEscolaController = container.Resolve<AutoEscolaController>();

                this.Hide();
                    FormCarrosInstance.Show();
            }
        }
    }
}