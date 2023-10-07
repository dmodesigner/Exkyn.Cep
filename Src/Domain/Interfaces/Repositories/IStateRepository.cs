﻿using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IStateRepository : IBaseRepository<States>
    {
        List<States> SearchByState();
    }
}
