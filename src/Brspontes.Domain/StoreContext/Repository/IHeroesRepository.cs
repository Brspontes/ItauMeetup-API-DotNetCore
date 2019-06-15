using Brspontes.Domain.StoreContext.QueriesResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes.Domain.StoreContext.Repository
{
    public interface IHeroesRepository
    {
        void Save();
        IEnumerable<ListHeroesQueryResult> Get();
        GetHeroQueryResult Get(Guid Id);
    }
}
