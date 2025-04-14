using ListOfGame.Infra.Contexto;
using ListOfGame.Infra.Repositories.Generico;
using ListOfGame.Infra.Repositories.Interfaces;
using ListOfGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListOfGame.Infra.Repositories
{
    public class GameRepositorio : RepositorioGeneric<Game>, IGameRepositorio
    {
        private readonly MDContext _context;

        public GameRepositorio(MDContext context) : base(context) { _context = context; }


    }
}
