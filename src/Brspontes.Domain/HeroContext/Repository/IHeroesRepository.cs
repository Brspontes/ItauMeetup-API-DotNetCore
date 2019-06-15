using Brspontes.Domain.HeroContext.QueriesResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes.Domain.HeroContext.Repository
{
    public interface IHeroesRepository
    {
        void Save();
        IEnumerable<ListHeroesQueryResult> Get();
        GetHeroQueryResult Get(Guid Id);
    }
}
