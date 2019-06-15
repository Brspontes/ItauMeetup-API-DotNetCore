using Brspontes.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes.Domain.HeroContext.Commands.Outputs
{
    public class RegisterHeroesCommandResult : ICommandResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
