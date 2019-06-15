using Brspontes.Domain.HeroContext.Commands.Inputs;
using Brspontes.Domain.HeroContext.Commands.Outputs;
using Brspontes.Domain.HeroContext.Entities;
using Brspontes.Domain.HeroContext.QueriesResults;
using Brspontes.Domain.HeroContext.Repository;
using Brspontes.Infra.MySQLContext;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brspontes.Infra.Repository
{
    public class HeroRepository : IHeroesRepository
    {
        private readonly MySQLContexts _context;

        public HeroRepository(MySQLContexts context)
        {
            _context = context;
        }

        public DeleteHeroesCommandResult Delete(DeleteHeroCommand command)
        {
            _context.Connection.Execute
               (
                   "DELETE FROM heroes WHERE ID = @ID",
                   new { ID = command.Id.ToString() }
               );

                return new DeleteHeroesCommandResult
                {
                    Success = true,
                    Message = "Deleted hero successfully."
                };
        }

        public IEnumerable<ListHeroesQueryResult> Get()
        {
            return _context.Connection.Query<ListHeroesQueryResult>
                 (
                     "SELECT ID, FIRSTNAME, LASTNAME, SUPERHERONAME, IMAGE " +
                     "FROM HEROES", new { }
                 ).ToList();
        }

        public GetHeroQueryResult Get(string Id)
        {
            return _context.Connection.Query<GetHeroQueryResult>
                 (
                     "SELECT ID, FIRSTNAME, LASTNAME, SUPERHERONAME, DESCRIPTION, IMAGE " +
                     "FROM HEROES WHERE ID = @ID", new { ID = Id.ToString() }
                 ).FirstOrDefault();
        }

        public RegisterHeroesCommandResult Save(Heroes heroes)
        {
            if (_context.Connection.Execute
                             (
                                 "INSERT INTO heroes " +
                                 "(Id, FirstName, LastName, SUPERHERONAME, Image, Description)" +
                                 "VALUES (@ID, @FIRSTNAME, @LASTNAME, @SUPERHERONAME, @IMAGE, @DESCRIPTION)",
                                 new
                                 {
                                     ID = heroes.Id,
                                     FIRSTNAME = heroes.FirstName,
                                     LASTNAME = heroes.LastName,
                                     SUPERHERONAME = heroes.SuperHeroName,
                                     IMAGE = heroes.ProfilePicture,
                                     DESCRIPTION = heroes.Description
                                 }) > 0)
                return new RegisterHeroesCommandResult
                {
                    Success = true,
                    Message = "Registration successfully Complete"
                };
            else
                return new RegisterHeroesCommandResult
                {
                    Success = false,
                    Message = "Error registering to database"
                };
        }

        public UpdateHeroesCommandResult Update(Heroes heroes)
        {
            if (_context.Connection.Execute
                             (
                                 "UPDATE heroes SET " +
                                 "FIRSTNAME = @FIRSTNAME, LASTNAME = @LASTNAME, SUPERHERONAME = @SUPERHERONAME, " +
                                 "IMAGE = @IMAGE, DESCRIPTION = @DESCRIPTION WHERE ID = @ID",
                                 new
                                 {
                                     FIRSTNAME = heroes.FirstName,
                                     LASTNAME = heroes.LastName,
                                     SUPERHERONAME = heroes.SuperHeroName,
                                     IMAGE = heroes.ProfilePicture,
                                     DESCRIPTION = heroes.Description,
                                     ID = heroes.Id
                                 }) > 0)
                return new UpdateHeroesCommandResult
                {
                    Success = true,
                    Message = "Successive update"
                };
            else
                return new UpdateHeroesCommandResult
                {
                    Success = false,
                    Message = "Error updating to database"
                };
        }
    }
}
