using Data.DB;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class NeighborhoodRepository : BaseRepository<Neighborhoods>, INeighborhoodRepository
    {
        public NeighborhoodRepository(CepBrasilDB ctx) : base(ctx)
        {
        }
    }
}
