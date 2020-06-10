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
                //Represent the id of a match 
                MatchupID = // set to custom textbox in wpf 

                //Represent the score of a match
                Score = // set to custom textbox in wpf
            };
        }

        /// <summary>
        /// Represent a method for creating People Data
        /// </summary>
        public void CreatePeople()
        {
            People people = new People()
            {
                //Represent the first name of the player
                FirstName = //set to custom textbox in wpf
                
                //Represnt the last name of the player
                LastName = //set to custom textbox in wpf

                //Represent the ingame or game name of the player
                PeoplePlayerName = //set to cusom textbox in wpf
            };
        }

        /// <summary>
        /// Represent a method for creating TeamMembers data
        /// </summary>
        public void CreateTeamMembers()
        {
            TeamMembers teamMembers = new TeamMembers()
            {
                //Represent the name of the team 
                TeamID = //set to custom textbox in wpf 
            };
        }

        /// <summary>
        /// Represent a method for creating Teams data
        /// </summary>
        public void CreateTeams()
        {
            Teams teams = new Teams
            {
                //Represent the name of the team 
                TeamID = //set to custom textbox in wpf 
            };
        }

        /// <summary>
        /// Represent a method for creating TournamentsEntries data 
        /// </summary>
        public void CreateTournamentEntries()
        {
            TournamentEntries tournamentEntries = new TournamentEntries
            {
                TournamentID = // Set to custom textbox in wpf 
            };
        }

        /// <summary>
        /// Represent a method for creating Tournaments
        /// </summary>
        public void CreateTournaments()
        {
            Tournaments tournaments = new Tournaments
            {
                TournamentName = // Set to custom textbox in wpf 
            };
        }

    }
}
