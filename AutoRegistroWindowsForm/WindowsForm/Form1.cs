using System.IdentityModel.Tokens.Jwt;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace AutoRegistro
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text != "" && textSenha.Text != "")
            {

                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    cmd = new SqlCommand($"Select id from AutoEscola where NomeAuto={textUsuario.Text}, Senha={textSenha.Text}");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int idAutoEscola = reader.GetInt32(reader.GetOrdinal("id"));
                                // Aqui você pode acessar outras colunas, se necessário
                                // Exemplo: string nome = reader.GetString(reader.GetOrdinal("nome"));

                                //Console.WriteLine($"ID: {id}");
                            }
                        }
                        else
                        {
                            //usuario não encontrado
                        }

                    }

                }
                FormCarros formCarros = new FormCarros();

                this.Hide();
                formCarros.Show();
            }
        }
    }
}