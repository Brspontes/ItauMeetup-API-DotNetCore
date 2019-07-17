using Brspontes.Domain.Core.Commands;

namespace Brspontes.Domain.HeroContext.Commands.Outputs
{
    public class UpdateHeroesCommandResult : ICommandResult
    {
        public bool Success { get; set; }
        public object Message { get; set; }
    }
}
