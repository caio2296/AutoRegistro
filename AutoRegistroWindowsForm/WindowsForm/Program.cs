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

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            container = new UnityContainer();
            var dbContextOptions = new DbContextOptionsBuilder<Contexto>()
                .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AutoRegistroDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
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
    }
}