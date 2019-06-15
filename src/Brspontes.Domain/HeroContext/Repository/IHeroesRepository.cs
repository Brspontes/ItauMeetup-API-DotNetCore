using Brspontes.Domain.HeroContext.Commands.Inputs;
using Brspontes.Domain.HeroContext.Commands.Outputs;
using Brspontes.Domain.HeroContext.Entities;
using Brspontes.Domain.HeroContext.QueriesResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes.Domain.HeroContext.Repository
{
    public interface IHeroesRepository
    {
        RegisterHeroesCommandResult Save(Heroes heroes);
        UpdateHeroesCommandResult Update(UpdateHeroesCommand command);
        IEnumerable<ListHeroesQueryResult> Get();
        GetHeroQueryResult Get(string Id);
        DeleteHeroesCommandResult Delete(DeleteHeroCommand command);
    }
}
