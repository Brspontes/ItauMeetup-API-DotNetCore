using Brspontes.Domain.Core.Commands;
using Brspontes.Domain.HeroContext.Commands.Inputs;
using Brspontes.Domain.HeroContext.Handlers;
using Brspontes.Domain.HeroContext.QueriesResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Brspontes.API.Controller
{
    public class HeroesController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly HeroesHandler _handler;
        public HeroesController(HeroesHandler heroesHandler)
        {
            _handler = heroesHandler;
        }

        [HttpPost]
        [Route("heroes")]
        public ICommandResult Post([FromBody] RegisterHeroesCommand command)
        {
            return _handler.Handle(command);
        }
        
        [HttpGet]
        [Route("heroes")]
        public IEnumerable<ListHeroesQueryResult> Get()
        {
            return _handler.Get();
        }

        [HttpGet]
        [Route("heroes/{Id}")]
        public GetHeroQueryResult Get(string Id)
        {
            return _handler.Get(Id);
        }

        [HttpPut]
        [Route("heroes")] 
        public ICommandResult Put([FromBody] UpdateHeroesCommand command)
        {
            return _handler.Handle(command);
        }

        [HttpDelete]
        [Route("heroes/{Id}")]
        public ICommandResult Delete(string Id)
        {
            DeleteHeroCommand command = new DeleteHeroCommand(Id);
            return _handler.Handle(command);
        }
    }
}