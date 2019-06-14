using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes.Domain.Core.Commands
{
    public interface ICommandHandler<T> where T : ICommands
    {
        ICommandResult Handle(T command);
    }
}
