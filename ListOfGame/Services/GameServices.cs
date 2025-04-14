using ListOfGame.Infra.Repositories.Interfaces;
using ListOfGame.Models;
using ListOfGame.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListOfGame.Services
{
    public class GameServices : IGameServices
    {
        private readonly IGameRepositorio _gameRepositorio;

        public GameServices(IGameRepositorio gameRepositorio)
        {
            _gameRepositorio = gameRepositorio;
        }

        public async Task<List<Game>> ObterJogosDoBanco()
        {
            var listaGames = await _gameRepositorio.ObterJogosDoBanco();
            return listaGames;
        }

        public async Task<bool> Salvar(Game game, string IdGame)
        {
            if (!String.IsNullOrEmpty(IdGame))
            {
                int id = int.Parse(IdGame);
                Game gameBase = await _gameRepositorio.GetGameById(id);

                if (gameBase != null)
                {
                    gameBase.NomeDoGame = game.NomeDoGame;
                    gameBase.Tempo = game.Tempo;
                    gameBase.PossuiOnline = game.PossuiOnline;
                    gameBase.IdStatusGame = game.IdStatusGame;
                    gameBase.AnoConcluido = game.AnoConcluido;
                    gameBase.GameConcluido = game.GameConcluido;

                    return await Alterar(gameBase);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return await Cadastrar(game);
            }
        }

        public async Task<bool> Cadastrar(Game game)
        {
            return await _gameRepositorio.GravarObjeto(game);
        }

        public async Task<bool> Alterar(Game game)
        {
            return await _gameRepositorio.SalvarAlteracoes(game);
        }
    }
}
