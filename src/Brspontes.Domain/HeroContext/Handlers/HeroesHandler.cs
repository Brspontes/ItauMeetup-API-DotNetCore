using AutoMapper;
using Brspontes.Domain.Core.Commands;
using Brspontes.Domain.HeroContext.Commands.Inputs;
using Brspontes.Domain.HeroContext.Commands.Outputs;
using Brspontes.Domain.HeroContext.Entities;
using Brspontes.Domain.HeroContext.QueriesResults;
using Brspontes.Domain.HeroContext.Repository;
using FluentValidator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes.Domain.HeroContext.Handlers
{
    public class HeroesHandler : Notifiable,
        ICommandHandler<RegisterHeroesCommand>,
        ICommandHandler<UpdateHeroesCommand>,
        ICommandHandler<DeleteHeroCommand>
    {
        private readonly IHeroesRepository _heroesRepository;
        private readonly IMapper _mapper;

        public HeroesHandler(IHeroesRepository heroesRepository, IMapper mapper)
        {
            _heroesRepository = heroesRepository;
            _mapper = mapper;
        }

        public ICommandResult Handle(UpdateHeroesCommand command)
        {
            throw new NotImplementedException();
        }

        public ICommandResult Handle(RegisterHeroesCommand command)
        {
            AddNotifications(command.Notifications);
            var mapping = _mapper.Map<Heroes>(command);
            AddNotifications(mapping.Notifications);

            if (Invalid)
                return new RegisterHeroesCommandResult
                {
                    Success = false,
                    Message = Notifications
                };

            return _heroesRepository.Save(mapping);
        }

        public ICommandResult Handle(DeleteHeroCommand command)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ListHeroesQueryResult> Get()
        {
            return _heroesRepository.Get();
        }

        public GetHeroQueryResult Get(string id)
        {
            return _heroesRepository.Get(id);
        }
    }
}
