using ListOfGame.Infra.Contexto;
using ListOfGame.Infra.Repositories.Generico;
using ListOfGame.Infra.Repositories.Interfaces;
using ListOfGame.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfGame.Infra.Repositories
{
    public class GameRepositorio : RepositorioGeneric<Game>, IGameRepositorio
    {
        private readonly MDContext _context;

        public GameRepositorio(MDContext context) : base(context) { _context = context; }

        public async Task<List<Game>> ObterJogosDoBanco()
        {
            return await _context.Games.ToListAsync();
        }

        public async Task<Game> GetGameById(int id)
        {
            return await _context.Games
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
