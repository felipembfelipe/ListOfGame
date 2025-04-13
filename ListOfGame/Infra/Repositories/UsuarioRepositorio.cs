using ListOfGame.Infra.Contexto;
using ListOfGame.Infra.Repositories.Generico;
using ListOfGame.Infra.Repositories.Interfaces;
using ListOfGame.Models;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ListOfGame.Infra.Repositories
{
    public class UsuarioRepositorio : RepositorioGeneric<Usuario>, IUsuarioRepositorio
    {
        private readonly MDContext _context;

        public UsuarioRepositorio(MDContext context) : base(context) { _context = context; }

        public async Task<Usuario> RetornaUsuarioPorLoginESenha(string login, string senha) => 
            await _context.Usuarios.FirstOrDefaultAsync(x => 
            x.LoginUsuario.ToUpper() == login.ToUpper() && 
            x.SenhaUsuario.ToUpper() == senha.ToUpper());

        public async Task<Usuario> RetornaUsuarioPorLogin(string login) =>
            await _context.Usuarios.FirstOrDefaultAsync(x =>
            x.LoginUsuario.ToUpper() == login.ToUpper());

        public async Task<Usuario> RetornaUsuarioPorEmailELogin(string usuario, string email) =>
            await _context.Usuarios.FirstOrDefaultAsync(x =>
            x.LoginUsuario.ToUpper() == usuario.ToUpper() && 
            x.EmailLogin.ToUpper() == email.ToUpper());
    }
}
