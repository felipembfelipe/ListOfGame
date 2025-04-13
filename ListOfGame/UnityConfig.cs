using Unity;
using AutoMapper;
using ListOfGame.Infra.Contexto;
using ListOfGame.View;
using ListOfGame.Services.Interfaces;
using ListOfGame.Services;
using ListOfGame.Infra.Repositories.Interfaces;
using ListOfGame.Infra.Repositories;
using ListOfGame.Infra.AutoMapper;

namespace ListOfGame
{
    public class UnityConfig
    {
        public static IUnityContainer RegisterComponents()
        {
            var container = new UnityContainer();

            // Regsitrar os forms
            container.RegisterType<MDContext>();
            container.RegisterType<frmLogin>();

            // Registrar as dependências no Unity Container
            container.RegisterType<IUsuarioServices, UsuarioServices>();
            container.RegisterType<IEmailService, EmailService>();

            // Registrar outros repositorios
            container.RegisterType<IUsuarioRepositorio, UsuarioRepositorio>();

            // Registrar o perfil do AutoMapper e criar uma instância de IMapper
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());  // Adiciona o perfil de mapeamento
            });

            var mapper = mapperConfig.CreateMapper();
            container.RegisterInstance<IMapper>(mapper);

            return container;
        }
    }
}
