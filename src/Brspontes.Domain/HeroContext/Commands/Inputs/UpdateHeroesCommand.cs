using Brspontes.Domain.Core.Commands;
using FluentValidator;
using FluentValidator.Validation;

namespace Brspontes.Domain.HeroContext.Commands.Inputs
{
    public class UpdateHeroesCommand : Notifiable, ICommands
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string SuperHeroName { get; set; }
        public string ProfilePicture { get; set; }

        public void Valid()
        {
            AddNotifications(new ValidationContract().Requires()
                .HasMinLen(FirstName, 3, "FirstName", "FirstName must be at least 3 characters")
                .HasMinLen(LastName, 3, "LastName", "LastName must be at least 3 characters")
                .HasMinLen(Description, 5, "Description", "Description must contain at least 5 characters")
                .HasMinLen(SuperHeroName, 3, "Name", "Duper Hero Name must be at least 3 characters")
                .IsNotNullOrEmpty(ProfilePicture, "ProfilePicture", "Required profile photo"));
        }
    }
}
