using FluentValidator;
using FluentValidator.Validation;

namespace Brspontes.Domain.StoreContext.ValueObjects
{
    public class SecretyIdentity : Notifiable
    { 
        public SecretyIdentity(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new ValidationContract().Requires()
                .HasMinLen(FirstName, 3, "FirstName", "FirstName must be at least 3 characters")
                .HasMinLen(LastName, 3, "LastName", "LastName must be at least 3 characters"));
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
