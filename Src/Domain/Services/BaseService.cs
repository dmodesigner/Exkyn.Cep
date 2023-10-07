using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _Repository;

        public BaseService(IBaseRepository<TEntity> Repository) => _Repository = Repository;

        public TEntity? Search(int ID) => _Repository.Search(ID);

        public void Delete(TEntity obj) => _Repository.Delete(obj);

        public void InsertOrUpdate(TEntity obj) => _Repository.InsertOrUpdate(obj);
    }
}
