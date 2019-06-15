using Brspontes.Domain.Core.Entity;
using Brspontes.Domain.HeroContext.ValueObjects;
using FluentValidator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes.Domain.HeroContext.Entities
{
    public class Heroes : Entity
    {
        public Heroes(SecretyIdentity secretyIdentity, 
            SuperHeroName superHeroName, 
            string description, 
            string profilePicture)
        {
            SecretyIdentity = secretyIdentity;
            SuperHeroName = superHeroName;
            Description = description;
            ProfilePicture = profilePicture;

            AddNotifications(new FluentValidator.Validation.ValidationContract().Requires()
                .HasMinLen(Description, 5, "Description", "Description must contain at least 5 characters")
                .IsNotNullOrEmpty(ProfilePicture, "ProfilePicture", "Required profile photo"));
        }

        public SecretyIdentity SecretyIdentity { get; private set; }
        public SuperHeroName SuperHeroName{ get; private set; }
        public string Description { get; private set; }
        public string ProfilePicture { get; private set; }
    }
}
