using Brspontes.Domain.Core.Entity;
using System;

namespace Brspontes.Domain.HeroContext.Entities
{
    public class Heroes : Entity
    {
        public Heroes(
             Guid Id, 
             string firstName,
             string lastName,
             string superHeroName,
             string description,
             string profilePicture) : base (Id)
        {
            FirstName = firstName;
            LastName = lastName;
            SuperHeroName = superHeroName;
            Description = description;
            ProfilePicture = profilePicture;

            AddNotifications(new FluentValidator.Validation.ValidationContract().Requires()
                .HasMinLen(SuperHeroName, 3, "Name", "Duper Hero Name must be at least 3 characters"));

            AddNotifications(new FluentValidator.Validation.ValidationContract().Requires()
                .HasMinLen(FirstName, 3, "FirstName", "FirstName must be at least 3 characters")
                .HasMinLen(LastName, 3, "LastName", "LastName must be at least 3 characters"));

            AddNotifications(new FluentValidator.Validation.ValidationContract().Requires()
                .HasMinLen(Description, 5, "Description", "Description must contain at least 5 characters")
                .IsNotNullOrEmpty(ProfilePicture, "ProfilePicture", "Required profile photo"));
        }

        public string ProfilePicture { get; private set; }
        public string Description { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string SuperHeroName { get; private set; }
    }
}
