using Brspontes.Domain.Core.Commands;
using FluentValidator;
using FluentValidator.Validation;

namespace Brspontes.Domain.HeroContext.Commands.Inputs
{
    public class DeleteHeroCommand : Notifiable, ICommands
    {
        public string Id { get; set; }

        public DeleteHeroCommand(string id)
        {
            Id = id;
            Valid();
        }

        public void Valid()
        {
            AddNotifications(new ValidationContract().Requires()
                .IsNotNullOrEmpty(Id.ToString(), "Id", "id can not be null"));
        }
    }
}
