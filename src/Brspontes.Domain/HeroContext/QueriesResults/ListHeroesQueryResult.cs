using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes.Domain.HeroContext.QueriesResults
{
    public class ListHeroesQueryResult
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string SuperHeroName { get; set; }
    }
}
