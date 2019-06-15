using Brspontes.Domain.Core.Commands;
using Brspontes.Domain.Core.Entity;
using FluentValidator.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes.Domain.HeroContext.Commands.Inputs
{
    public class DeleteHeroCommand : Entity, ICommands
    {
        public DeleteHeroCommand(Guid id)
            : base(id)
        {

        }

        public void Valid()
        {
            AddNotifications(new ValidationContract().Requires()
                .IsNotNullOrEmpty(Id.ToString(), "Id", "id can not be null"));
        }
    }
}
