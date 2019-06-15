using Brspontes.Domain.Core.Commands;
using Brspontes.Domain.HeroContext.Commands.Inputs;
using Brspontes.Domain.HeroContext.Repository;
using FluentValidator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes.Domain.HeroContext.Handlers
{
    public class HeroesHandler : Notifiable,
        ICommandHandler<RegisterHeroesCommand>,
        ICommandHandler<UpdateHeroesCommand>,
        ICommandHandler<DeleteHeroCommand>
    {
        private readonly IHeroesRepository _heroesRepository;

        public HeroesHandler(IHeroesRepository heroesRepository)
        {
            _heroesRepository = heroesRepository;
        }

        public ICommandResult Handle(UpdateHeroesCommand command)
        {
            throw new NotImplementedException();
        }

        public ICommandResult Handle(RegisterHeroesCommand command)
        {
            throw new NotImplementedException();
        }

        public ICommandResult Handle(DeleteHeroCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
