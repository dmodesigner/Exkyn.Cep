namespace Domain.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        TEntity Search(int ID);
        void InsertOrUpdate(TEntity obj);
        void Delete(TEntity obj);
    }
}
