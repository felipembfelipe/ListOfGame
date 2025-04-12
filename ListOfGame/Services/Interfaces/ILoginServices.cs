using ListOfGame.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListOfGame.Services.Interfaces
{
    public interface ILoginServices
    {
        Task<Usuario> Login(string login, string senha);

        Task<Usuario> ValidaUsuarioExistente(string login);
    }
}
