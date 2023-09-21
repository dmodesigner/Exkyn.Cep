namespace Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity Search(int ID);
        void Delete(TEntity obj);
        void InsertOrUpdate(TEntity obj);
        void Dispose();
    }
}
