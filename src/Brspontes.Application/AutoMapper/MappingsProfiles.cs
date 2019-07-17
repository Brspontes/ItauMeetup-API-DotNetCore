using AutoMapper;
using Brspontes.Domain.HeroContext.Commands.Inputs;
using Brspontes.Domain.HeroContext.Entities;

namespace Brspontes.Application.AutoMapper
{
    public class MappingsProfiles : Profile
    {
        public MappingsProfiles()
        {
            CreateMap<RegisterHeroesCommand, Heroes>();
            CreateMap<UpdateHeroesCommand, Heroes>();
        }
    }
}
