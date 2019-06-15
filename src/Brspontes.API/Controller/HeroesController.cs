using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Brspontes.Domain.Core.Commands;
using Brspontes.Domain.HeroContext.Commands.Inputs;
using Brspontes.Domain.HeroContext.Entities;
using Brspontes.Domain.HeroContext.Handlers;
using Brspontes.Domain.HeroContext.QueriesResults;
using Brspontes.Domain.HeroContext.Repository;
using Microsoft.AspNetCore.Mvc;

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
        [Route("heroes/register")]
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
    }
}