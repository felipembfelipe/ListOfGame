using ListOfGame.Infra.Repositories.Interfaces;
using ListOfGame.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListOfGame.Services
{
    public class GameServices : IGameServices
    {
        private readonly IGameRepositorio _gameRepositorio;

        public GameServices(IGameRepositorio gameRepositorio)
        {
            _gameRepositorio = gameRepositorio;
        }


    }
}
