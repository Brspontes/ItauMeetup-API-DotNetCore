using Brspontes.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes.Domain.StoreContext.Commands.Outputs
{
    public class UpdateHeroesCommandResult : ICommandResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
