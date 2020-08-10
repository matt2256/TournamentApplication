using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;

namespace DataAccess.CRUD
{
    public class Create
    {
        

        /// <summary>
        /// Represent method for creating matchup data 
        /// </summary>
        public void CreationMatchup()
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
            //Represent a object of of TournamentEntities called context
            TournamentEntities context = new TournamentEntities();

            MatchupEntry matchupEntries = new MatchupEntry
            {
                //Represent the id of a match 
                //MatchupID = // set to custom textbox in wpf 

                //Represent the score of a match
                //Score = // set to custom textbox in wpf
            };
        }

        /// <summary>
        /// Represent a method for creating People Data (Player)
        /// </summary>
        public void CreatePeople(string _Fname, string _Lname, string _IGname)
        {
            //Represent a object of of TournamentEntities called context
            TournamentEntities context = new TournamentEntities();

            Person people = new Person()
            {
                //Represent the first name (string) of the player
                FirstName = _Fname, //set to custom textbox in wpf

                //Represnt the last name (string) of the player
                LastName = _Lname, //set to custom textbox in wpf

                //Represent the ingame or game name (string) of the player
                PeoplePlayerName = _IGname//set to cusom textbox in wpf
            };

            context.People.Add(people);

            context.SaveChanges();
        }

        /// <summary>
        /// Represent a method for creating TeamMembers data
        /// </summary>
        public void CreateTeamMembers(string _teamMembers)
        {
            //Represent a object of of TournamentEntities called context
            TournamentEntities context = new TournamentEntities();

            TeamMember teamMembers = new TeamMember()
            {
                //Represent the name (string) of the team 
                TeamID = _teamMembers//set to custom textbox in wpf 
            };

            context.TeamMembers.Add(teamMembers);

            context.SaveChanges();
        }

        /// <summary>
        /// Represent a method for creating Teams data
        /// </summary>
        public void CreateTeams(string _teamName)
        {
            //Represent a object of of TournamentEntities called context
            TournamentEntities context = new TournamentEntities();

            Team teams = new Team
            {
                //Represent the name (string) of the team 
                TeamID = _teamName//set to custom textbox in wpf 
            };

            context.Teams.Add(teams);

            context.SaveChanges();
        }

        /// <summary>
        /// Represent a method for creating TournamentsEntries data 
        /// </summary>
        public void CreateTournamentEntries(int _tourID)
        {
            //Represent a object of of TournamentEntities called context
            TournamentEntities context = new TournamentEntities();

            TournamentEntry tournamentEntries = new TournamentEntry
            {
                //Represent the id (int) of the entries to the tournament
                TournamentID = _tourID // Set to custom textbox in wpf 
            };

            context.TournamentEntries.Add(tournamentEntries);

            context.SaveChanges();
        }

        /// <summary>
        /// Represent a method for creating Tournaments
        /// </summary>
        public void CreateTournaments(string _tourName)
        {
            //Represent a object of of TournamentEntities called context
            TournamentEntities context = new TournamentEntities();

            Tournament tournaments = new Tournament
            {
                //Represent the name (string) of the tournament
                TournamentName = _tourName // Set to custom textbox in wpf 
            };

            context.Tournaments.Add(tournaments);

            context.SaveChanges();
        }

    }
}
