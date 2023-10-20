using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository) => _repository = repository;

        public TEntity? Search(int ID) => _repository.Search(ID);

        public void Delete(TEntity obj) => _repository.Delete(obj);

        public void InsertOrUpdate(TEntity obj) => _repository.InsertOrUpdate(obj);
    }
}
