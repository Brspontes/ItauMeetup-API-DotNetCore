using FluentValidator;
using System;

namespace Brspontes.Domain.Core.Entity
{
    public class Entity : Notifiable
    {
        public Guid Id { get; set; }

        public Entity(Guid id)
        {
            Id = id;
        }
    }
}
