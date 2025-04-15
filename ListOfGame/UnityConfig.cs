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

            // Registrar os forms
            container.RegisterType<MDContext>();
            container.RegisterType<frmTelaGame>();

            // Registrar as dependências no Unity Container
            container.RegisterType<IGameServices, GameServices>();

            // Registrar outros repositorios
            container.RegisterType<IGameRepositorio, GameRepositorio>();

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
