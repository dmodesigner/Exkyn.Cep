namespace Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        List<TEntity>? SearchAll();
        List<TEntity>? SearchAll(TEntity entity);
        TEntity? Search(int ID);
        void Delete(TEntity obj);
        void InsertOrUpdate(TEntity obj);
        void Dispose();
    }
}
