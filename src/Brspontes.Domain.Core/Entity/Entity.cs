﻿using FluentValidator;
using FluentValidator.Validation;
using System;

namespace Brspontes.Domain.Core.Entity
{
    public class Entity : Notifiable
    {
        public Guid Id { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}