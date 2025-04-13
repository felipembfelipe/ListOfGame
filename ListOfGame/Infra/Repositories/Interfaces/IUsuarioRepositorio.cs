using ListOfGame.Infra.Repositories.Generico;
using ListOfGame.Models;
using System.Threading.Tasks;

namespace ListOfGame.Infra.Repositories.Interfaces
{
    public interface IUsuarioRepositorio : IRepositorioGeneric<Usuario>
    {
        Task<Usuario> RetornaUsuarioPorLoginESenha(string login, string senha);

        Task<Usuario> RetornaUsuarioPorLogin(string login);

        Task<Usuario> RetornaUsuarioPorEmailELogin(string usuario, string email);

    }
}
