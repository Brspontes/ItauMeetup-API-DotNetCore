using AutoMapper;
using Brspontes.Domain.HeroContext.Commands.Inputs;
using Brspontes.Domain.HeroContext.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes.Application.AutoMapper
{
    public class MappingsProfiles : Profile
    {
        public MappingsProfiles()
        {
            CreateMap<RegisterHeroesCommand, Heroes>();
        }
    }
}
