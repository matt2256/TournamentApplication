using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.CRUD
{
    public class Delete
    {
        #region Person
        /// <summary>
        /// Represent a method for deleting a specifik persons data set
        /// </summary>
        /// <param name="_Id">int</param>
        public void DeletePerson(int _Id)
        {
            TournamentEntities context = new TournamentEntities();

            Person people = context.People.First(i => i.Id == _Id);

            context.People.Remove(people);

            context.SaveChanges();
        }
        #endregion

        #region Matchup and MatchupEntry
        /// <summary>
        /// Represent a method for deleting a specifik matchups data set
        /// </summary>
        /// <param name="_id">int</param>
        public void DeleteMatchup(int _id)
        {
            TournamentEntities context = new TournamentEntities();

            Matchup matchup = context.Matchups.First(i => i.Id == _id);

            context.Matchups.Remove(matchup);

            context.SaveChanges();
        }

        /// <summary>
        /// Represent a method for deleting a specifik matchup entry data set
        /// </summary>
        /// <param name="_id"></param>
        public void DeleteMatchupEntry(int _id)
        {
            TournamentEntities context = new TournamentEntities();

            MatchupEntry matchupEntry = context.MatchupEntries.First(i => i.Id == _id);

            context.MatchupEntries.Remove(matchupEntry);

            context.SaveChanges();
        }
        #endregion

        #region Team and TeamMember
        /// <summary>
        /// Represent a method for deleting a specifk team members data set 
        /// </summary>
        /// <param name="_id">int</param>
        public void DeleteTeamMember(int _id)
        {
            TournamentEntities context = new TournamentEntities();

            TeamMember teamMember = context.TeamMembers.First(i => i.Id == _id);

            context.TeamMembers.Remove(teamMember);

            context.SaveChanges();
        }

        /// <summary>
        /// Represent a method for deleting a specifik team data set
        /// </summary>
        /// <param name="_id">int</param>
        public void DeleteTeam(int _id)
        {
            TournamentEntities context = new TournamentEntities();

            Team team = context.Teams.First(i => i.Id == _id);

            context.Teams.Remove(team);

            context.SaveChanges();
        }
        #endregion

        #region Tournament and TournamentEntry
        /// <summary>
        /// Represent a method for deleting a specifik tournament data set
        /// </summary>
        /// <param name="_id">int</param>
        public void DeleteTournament(int _id)
        {
            TournamentEntities context = new TournamentEntities();

            Tournament tournament = context.Tournaments.First(i => i.Id == _id);

            context.Tournaments.Remove(tournament);

            context.SaveChanges();
        }



        /// <summary>
        /// Represent a method for deleting a specifik tournament entry data set
        /// </summary>
        /// <param name="_id">int</param>
        public void DeleteTournamentEntry(int _id)
        {
            TournamentEntities context = new TournamentEntities();

            TournamentEntry tournamentEntry = context.TournamentEntries.First(i => i.Id == _id);

            context.TournamentEntries.Remove(tournamentEntry);

            context.SaveChanges();
        }
        #endregion
    }
}
