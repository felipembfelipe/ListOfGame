using AutoMapper;
using ListOfGame.Models;
using ListOfGame.Services.Interfaces;
using ListOfGame.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListOfGame.Services
{
    public class LoginServices : ILoginServices
    {
        private readonly IMapper _mapper;
        private readonly IUsuarioServices _usuarioService;


        public LoginServices(IMapper mapper, IUsuarioServices usuarioService)
        {
            _mapper = mapper;
            _usuarioService = usuarioService;
        }

        public async Task<Usuario> Login(string login, string senha)
        {
            Usuario usuario = new Usuario();

            try
            {
                usuario = await _usuarioService.ObterUsuarioPorLoginESenha(login, senha);
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro + "No Banco");
            }
            return usuario;
        }

        public async Task<Usuario> ValidaUsuarioExistente(string login)
        {
            Usuario usuario = new Usuario();

            try
            {
                usuario = await _usuarioService.ObterUsuarioPorLogin(login);
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro + "No Banco");
            }
            return usuario;
        }

        public async Task<bool> TrocaSenha(Usuario usuario)
        {
            bool sucesso = false;
            try
            {
               sucesso = await _usuarioService.TrocaSenha(usuario);
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro + "No Banco");
            }
            return sucesso;
        }
    }
}
