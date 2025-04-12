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
            x.LoginUsuario.ToUpper() == login && 
            x.SenhaUsuario.ToUpper() == senha);

        public async Task<Usuario> RetornaUsuarioPorLogin(string login) =>
            await _context.Usuarios.FirstOrDefaultAsync(x =>
            x.LoginUsuario.ToUpper() == login);
    }
}
