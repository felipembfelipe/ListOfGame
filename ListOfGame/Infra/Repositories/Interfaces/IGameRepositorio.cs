using ListOfGame.Infra.Repositories.Generico;
using ListOfGame.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListOfGame.Infra.Repositories.Interfaces
{
    public interface IGameRepositorio : IRepositorioGeneric<Game>
    {
        Task<List<Game>> ObterJogosDoBanco();
        Task<Game> GetGameById(int id);
    }
}
