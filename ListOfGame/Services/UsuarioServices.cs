using ListOfGame.Infra.Repositories.Interfaces;
using ListOfGame.Models;
using ListOfGame.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListOfGame.Services
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly IEmailService _emailService;
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioServices(IUsuarioRepositorio usuarioRepositorio, IEmailService emailService)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _emailService = emailService;
        }

        public async Task<Usuario> ObterUsuarioPorLoginESenha(string login, string senha)
        {
            var user = await _usuarioRepositorio.RetornaUsuarioPorLoginESenha(login, senha);
            return user;
        }

        public async Task<Usuario> ObterUsuarioPorLogin(string login)
        {
            var user = await _usuarioRepositorio.RetornaUsuarioPorLogin(login);
            return user;
        }

        public async Task<bool> TrocaSenha(Usuario usuario)
        {
            var user = await _usuarioRepositorio.SalvarAlteracoes(usuario);
            return user;
        }

        public async Task<bool> ObterUsuarioPorLoginEEmail(string usuario, string email)
        {
            var emailExiste = await _usuarioRepositorio.RetornaUsuarioPorEmailELogin(usuario, email);

            if (emailExiste == null)
                return false;

            return await _emailService.EnviarEmailRecuperacao(email, usuario, emailExiste.SenhaUsuario);

        }
    }
}
