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

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
