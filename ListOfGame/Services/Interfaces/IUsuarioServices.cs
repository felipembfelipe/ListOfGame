using ListOfGame.Models;
using System.Threading.Tasks;

namespace ListOfGame.Services.Interfaces
{
    public interface IUsuarioServices
    {
        Task<Usuario> ObterUsuarioPorLoginESenha(string usuario, string senha);

        Task<Usuario> ObterUsuarioPorLogin(string login);

        Task<bool> TrocaSenha(Usuario usuario);

        Task<bool> ObterUsuarioPorLoginEEmail(string usuario, string email);
    }
}
