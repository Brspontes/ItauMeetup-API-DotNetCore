using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes.Domain.Core.Commands
{
    public interface ICommandResult
    {
        bool Success { get; set; }
        string Message { get; set; }
    }
}
