using ListOfGame.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListOfGame.Services.Interfaces
{
    public interface IGameServices
    {
        Task<List<Game>> ObterJogosDoBanco();
        Task<bool> Salvar(Game game, string IdGame);

        Task<bool> Cadastrar(Game game);
        Task<bool> Alterar(Game game);
    }
}
