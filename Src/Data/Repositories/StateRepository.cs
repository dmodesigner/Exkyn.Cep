using Data.DB;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Data.Repositories
{
    public class StateRepository : BaseRepository<States>, IStateRepository
    {
        public StateRepository(CepBrasilDB ctx) : base(ctx) { }

        public List<States> SearchByState()
        {
            return _ctx
                .States
                .OrderBy(x => x.State)
                .ToList();
        }
    }
}
