using ListOfGame.Infra.Contexto;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ListOfGame.Infra.Repositories.Generico
{
    public class RepositorioGeneric<TEntity> : IRepositorioGeneric<TEntity> where TEntity : class
    {
        private readonly MDContext _mdContext;
        private DbSet<TEntity> dbset { get; set; }

        public RepositorioGeneric(MDContext mdContext)
        {
            _mdContext = mdContext;
            dbset = _mdContext.Set<TEntity>();
        }

        public virtual async Task<bool> GravarObjeto(TEntity obj)
        {
            using (var transaction = _mdContext.Database.BeginTransaction())  // BeginTransaction para EF6
            {
                try
                {
                    dbset.Add(obj);
                    _mdContext.Entry(obj).State = EntityState.Added;
                    var result = await Task.Run(() => _mdContext.SaveChanges()) > 0;  // Síncrono em EF6, mas use Task.Run para compatibilidade assíncrona

                    if (result)
                        transaction.Commit();

                    return result;
                }
                catch (Exception ex)
                {
                    _mdContext.Set<TEntity>().Remove(obj);
                    transaction.Rollback();  // Certifique-se de fazer o rollback em caso de erro
                    return false;
                }
            }
        }

        public virtual async Task<bool> SalvarAlteracoes(TEntity obj)
        {
            bool boolAlterado = false;

            try
            {
                dbset.Attach(obj);
                _mdContext.Entry(obj).State = EntityState.Modified;
                boolAlterado = await Task.Run(() => _mdContext.SaveChanges()) > 0;  // Usando Task.Run para compatibilidade assíncrona
            }
            catch (Exception erro)
            {
                // Tratar erro
            }
            return boolAlterado;
        }

        public virtual async Task<bool> AtualizarObjetoTracking(TEntity obj)
        {
            using (var transaction = _mdContext.Database.BeginTransaction())  // Usando BeginTransaction para EF6
            {
                try
                {
                    bool result = await Task.Run(() => _mdContext.SaveChanges()) > 0;  // Síncrono em EF6, mas usando Task.Run para compatibilidade assíncrona
                    if (result)
                        transaction.Commit();
                    else
                        transaction.Rollback();

                    return result;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public void Alterar(TEntity model)
        {
            _mdContext.Entry(model).State = EntityState.Modified;
        }

        public void Cadastrar(params TEntity[] models)
        {
            _mdContext.Set<TEntity>().AddRange(models);
        }
    }
}
