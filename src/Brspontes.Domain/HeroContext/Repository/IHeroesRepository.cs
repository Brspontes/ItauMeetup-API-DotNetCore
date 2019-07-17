using Brspontes.Domain.HeroContext.Commands.Inputs;
using Brspontes.Domain.HeroContext.Commands.Outputs;
using Brspontes.Domain.HeroContext.Entities;
using Brspontes.Domain.HeroContext.QueriesResults;
using System.Collections.Generic;

namespace Brspontes.Domain.HeroContext.Repository
{
    public interface IHeroesRepository
    {
        RegisterHeroesCommandResult Save(Heroes heroes);
        UpdateHeroesCommandResult Update(Heroes command);
        IEnumerable<ListHeroesQueryResult> Get();
        GetHeroQueryResult Get(string Id);
        DeleteHeroesCommandResult Delete(DeleteHeroCommand command);
    }
}
