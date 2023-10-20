using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using Data.DB;

namespace Data.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly CepBrasilDB _ctx;

        public BaseRepository(CepBrasilDB ctx) => _ctx = ctx;

        public virtual List<TEntity> SearchAll() => _ctx.Set<TEntity>().ToList();

        public virtual List<TEntity> SearchAll(TEntity entity) => throw new NotImplementedException("A classe deve ser implementada de forma individual para cada método que deseja usar");

        public TEntity? Search(int ID) => _ctx.Set<TEntity>().Find(ID);

        public void Dispose() => _ctx.Dispose();

        public void InsertOrUpdate(TEntity obj)
        {
            EntityEntry<TEntity> entry = _ctx.Entry(obj);

            IKey? primaryKey = entry.Metadata.FindPrimaryKey();

            if (primaryKey != null)
            {
                object?[] keys = primaryKey.Properties.Select(x => x.FieldInfo?.GetValue(obj)).ToArray();

                TEntity? result = _ctx.Find<TEntity>(keys);

                if (result == null)
                    _ctx.Add(obj);
                else
                {
                    _ctx.Entry(result).State = EntityState.Detached;
                    _ctx.Update(obj);
                }

                _ctx.SaveChanges();
            }
        }

        public void Delete(TEntity obj)
        {
            _ctx.Set<TEntity>().Remove(obj);
            _ctx.SaveChanges();
        }
    }
}
