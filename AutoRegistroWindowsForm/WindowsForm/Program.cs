using Aplicacao.Aplicacoes;
using Aplicacao.Interfaces;
using AutoRegistro.Controllers;
using Dominio.Interfaces;
using Dominio.Interfaces.Generico;
using Dominio.Interfaces.InterfacesServicos;
using Dominio.Servicos;
using Entidades.Entidades;
using InfraEstrutura.Configuracao;
using InfraEstrutura.Repositorio;
using InfraEstrutura.Repositorio.Generico;
using System;
using System.Windows.Forms;
using Unity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Configuration;
using MySqlConnector;

namespace AutoRegistro
{

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static IUnityContainer container;
        [STAThread]
        static void Main()
        {
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();

                container = new UnityContainer();
                var dbContextOptions = new DbContextOptionsBuilder<Contexto>()

                    //.UseMySql(ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString, new MySqlServerVersion(new Version(8, 0, 37)))
                    //.UseSqlServer("Server=tcp:profilecaio.database.windows.net,1433;Initial Catalog=AutoRegistro;Persist Security Info=False;User ID=caio;Password=zxcasd384!A;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
                    .UseMySql("Server=mysql.autoregistro.kinghost.net;DataBase=autoregistro;User=autoregistro;Password=zxcasd384" ,new MySqlServerVersion(new Version(10, 2, 36)))
                    .Options;


                using (var dbContext = new Contexto(dbContextOptions))
                {
                    dbContext.Database.Migrate();

                    container.RegisterInstance(dbContext);



                    container.RegisterSingleton(typeof(IGenerico<>), typeof(RepositorioGenerico<>));
                    container.RegisterSingleton<IUsuario, RepositorioUsuario>();
                    container.RegisterSingleton<IAutoEscola, RepositorioAutoEscola>();
                    container.RegisterSingleton<IManutencao, RepositorioManutencao>();
                    container.RegisterSingleton<IVeiculo, RepositorioVeiculo>();

                    // Configuração da injeção de dependência
                    container.RegisterSingleton<IAutoEscolaServico, AutoEscolaServico>();
                    container.RegisterSingleton<IManutencaoServico, ManutencaoServico>();
                    container.RegisterSingleton<IVeiculoServico, VeiculoServico>();

                    container.RegisterSingleton<IAplicacaoAutoEscola, AplicacaoAutoEscola>();
                    container.RegisterSingleton<IAplicacaoManutencao, AplicacaoManutencao>();
                    container.RegisterSingleton<IAplicacaoVeiculo, AplicacaoVeiculo>();
                    container.RegisterSingleton<IAplicacaoUsuario, AplicacaoUsuario>();




                    // Resolva instâncias específicas
                    var usuarioRepositorio = container.Resolve<IUsuario>();
                    var autoEscolaRepositorio = container.Resolve<IAutoEscola>();
                    var manutencaoRepositorio = container.Resolve<IManutencao>();
                    var veiculoRepositorio = container.Resolve<IVeiculo>();

                    // Resolva instâncias genéricas com argumentos específicos
                    var repositorioUsuario = container.Resolve<IGenerico<Usuario>>();
                    var repositorioAutoEscola = container.Resolve<IGenerico<AutoEscola>>();
                    var repositorioManutencao = container.Resolve<IGenerico<Manutencao>>();
                    var repositorioVeiculo = container.Resolve<IGenerico<Veiculo>>();

                    var autoEscolaServico = container.Resolve<AutoEscolaServico>();
                    var manutencaoServico = container.Resolve<ManutencaoServico>();
                    var veiculoServico = container.Resolve<VeiculoServico>();

                    // Resolução do controlador com injeção de dependência
                    container.RegisterType<AutoEscolaController>();
                    var autoEscolaController = container.Resolve<AutoEscolaController>();
                    //container.RegisterInstance(autoEscolaController);

                    container.RegisterType<ManutencaoController>();
                    var ManutencaoController = container.Resolve<ManutencaoController>();
                    //container.RegisterInstance(ManutencaoController);

                    container.RegisterType<UsuarioController>();
                    var usuarioController = container.Resolve<UsuarioController>();
                    //container.RegisterInstance(usuarioController);

                    container.RegisterType<VeiculoController>();
                    var veiculoController = container.Resolve<VeiculoController>();
                    //container.RegisterInstance(veiculoController);

                    var mainForm = container.Resolve<Form1>();
                    var formCarros = container.Resolve<FormCarros>();
                    var formManutencao = container.Resolve<ManutencaoForm>();
                    formCarros.MainFormInstance = mainForm;
                    mainForm.FormCarrosInstance = formCarros;
                    mainForm.FormManutencaoInstance = formManutencao;
                    Application.Run(mainForm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro durante a inicialização do aplicativo: \n" + ex.Message);

                throw new Exception("Ocorreu um erro durante a inicialização do aplicativo: " + ex.Message); ;
            }
          
        }
    }
}