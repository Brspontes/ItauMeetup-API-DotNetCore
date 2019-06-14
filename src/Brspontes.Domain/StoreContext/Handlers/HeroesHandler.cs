using Brspontes.Domain.Core.Commands;
using Brspontes.Domain.StoreContext.Commands.Inputs;
using FluentValidator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes.Domain.StoreContext.Handlers
{
    public class HeroesHandler : Notifiable,
        ICommandHandler<RegisterHeroesCommand>,
        ICommandHandler<UpdateHeroesCommand>,
        ICommandHandler<DeleteHeroCommand>
    {
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
