using System.Threading.Tasks;

namespace ListOfGame.Infra.Repositories.Generico
{
    public interface IRepositorioGeneric<TEntity> where TEntity : class
    {
        Task<bool> GravarObjeto(TEntity obj);
        Task<bool> SalvarAlteracoes(TEntity obj);
        Task<bool> AtualizarObjetoTracking(TEntity obj);

    }
}
