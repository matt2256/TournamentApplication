using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.CRUD
{
    public class Create
    {
        TournamentEntities context = new TournamentEntities();

        /// <summary>
        /// Represent method for creating matchup data 
        /// </summary>
        public void Creation()
        {
            Matchup matchup = new Matchup
            {

            };
        }

        /// <summary>
        /// Represent a method for creating MatchupEntries data
        /// </summary>
        public void CreateMatchupEntries()
        {
            MatchupEntries matchupEntries = new MatchupEntries
            {

            };
        }

        /// <summary>
        /// Represent a method for creating People Data
        /// </summary>
        public void CreatePeople()
        {
            People people = new People()
            {

            };
        }

        /// <summary>
        /// Represent a method for creating TeamMembers data
        /// </summary>
        public void CreateTeamMembers()
        {
            TeamMembers teamMembers = new TeamMembers()
            {

            };
        }

        /// <summary>
        /// Represent a method for creating Teams data
        /// </summary>
        public void CreateTeams()
        {
            Teams teams = new Teams
            {

            };
        }

        /// <summary>
        /// Represent a method for creating TournamentsEntries data 
        /// </summary>
        public void CreateTournamentEntries()
        {
            TournamentEntries tournamentEntries = new TournamentEntries
            {

            };
        }

        /// <summary>
        /// Represent a method for creating Tournaments
        /// </summary>
        public void CreateTournaments()
        {
            Tournaments tournaments = new Tournaments
            {

            };
        }

    }
}
