using Brspontes.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes.Domain.HeroContext.Commands.Outputs
{
    public class DeleteHeroesCommandResult : ICommandResult
    {
        public bool Success { get; set; }
        public object Message { get; set; }
    }
}
