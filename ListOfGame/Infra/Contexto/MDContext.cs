using System.Data.Entity;
using System.Configuration;
using ListOfGame.Models;

namespace ListOfGame.Infra.Contexto
{
    public class MDContext : DbContext
    {
        public MDContext() : base(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<StatusGame> TipoStatusGames { get; set; }
    }
}
