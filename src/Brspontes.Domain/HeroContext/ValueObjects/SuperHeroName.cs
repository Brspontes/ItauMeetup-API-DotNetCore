using FluentValidator;
using FluentValidator.Validation;

namespace Brspontes.Domain.HeroContext.ValueObjects
{
    public class SuperHeroName : Notifiable
    {
        public SuperHeroName(string name)
        {
            Name = name;

            AddNotifications(new ValidationContract().Requires()
                .HasMinLen(Name, 3, "Name", "Duper Hero Name must be at least 3 characters"));
        }

        public string Name { get; private set; }
    }
}
