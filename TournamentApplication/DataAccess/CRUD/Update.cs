using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.CRUD
{
    public class Update
    {
        #region Person
        /// <summary>
        /// Represent a method for updating a specifik persons data set 
        /// </summary>
        /// <param name="_fname">string</param>
        /// <param name="_lname">string</param>
        public void UpdatePerson(int _id, string _fname, string _lname)
        {
            TournamentEntities context = new TournamentEntities();

            Person people = context.People.First(i => i.Id == _id);

            people.FirstName = _fname;
            people.LastName = _lname;

            context.SaveChanges();
        }
        #endregion

        #region Team and TeamMember
        /// <summary>
        /// Represent a method for updating a specifik team members data set
        /// </summary>
        /// <param name="_teamId">string</param>
        /// <param name="_playerName">string</param>
        public void UpdateTeamMember(int _id, string _teamId, string _playerName)
        {
            TournamentEntities context = new TournamentEntities();

            TeamMember teamMember = context.TeamMembers.First(i => i.Id == _id);

            teamMember.TeamID = _teamId;
            teamMember.PlayerName = _playerName;

            context.SaveChanges();
        }

        /// <summary>
        /// Represent a method for updating a specifik teams data set
        /// </summary>
        /// <param name="_teamId">string</param>
        public void UpdateTeam(int _id, string _teamId)
        {
            TournamentEntities context = new TournamentEntities();

            Team team = context.Teams.First(i => i.Id == _id);

            team.TeamID = _teamId;

            context.SaveChanges();
        }
        #endregion

        #region Matchup and MatchupEntitries
        /// <summary>
        /// Represent a method for updating a specifik matchups data set
        /// </summary>
        /// <param name="_winId">int</param>
        /// <param name="_matchRound">int</param>
        /// <param name="_teamOne">string</param>
        /// <param name="_teamTwo">string</param>
        public void UpdateMatchup(int _id, int _winId, int _matchRound, string _teamOne, string _teamTwo)
        {
            TournamentEntities context = new TournamentEntities();

            Matchup matchup = context.Matchups.First(i => i.Id == _id);

            matchup.WinnerID = _winId;
            matchup.MatchupRound = _matchRound;
            matchup.TeamID_One = _teamOne;
            matchup.TeamID_Two = _teamTwo;

            context.SaveChanges();
        }

        /// <summary>
        /// Represent a method for updating a specifik matchup entry´s data set
        /// </summary>
        /// <param name="_matchupId">int</param>
        /// <param name="_parrentMatchupId">int</param>
        /// <param name="_teamCompedingId">int</param>
        /// <param name="_score">int</param>
        public void UpdateMatchupEntitries(int _id, int _matchupId, int _parrentMatchupId, int _teamCompedingId, int _score)
        {
            TournamentEntities context = new TournamentEntities();

            MatchupEntry matchupEntry = context.MatchupEntries.First(i => i.Id == _id);

            matchupEntry.MatchupID = _matchupId;
            matchupEntry.ParrentMatchupID = _parrentMatchupId;
            matchupEntry.TeamCompedingID = _teamCompedingId;
            matchupEntry.Score = _score;

            context.SaveChanges();
        }
        #endregion

        #region Tournament and TournamentEntitries
        /// <summary>
        /// Represent a method for updating a specifik tournaments data set
        /// </summary>
        /// <param name="_tournamentName">string</param>
        /// <param name="_tournamentId">int</param>
        public void UpdateTournament(int _id, string _tournamentName, int _tournamentId)
        {
            TournamentEntities context = new TournamentEntities();

            Tournament tournament = context.Tournaments.First(i => i.Id == _id);

            tournament.TournamentName = _tournamentName;
            tournament.TournamentID = _tournamentId;

            context.SaveChanges();
        }

        /// <summary>
        /// Represent a method for updating a specifik tournament entry´s data set
        /// </summary>
        /// <param name="_tournamentTeamId">string</param>
        public void UpdateTournamentEntitries(int _id, string _tournamentTeamId)
        {
            TournamentEntities context = new TournamentEntities();

            TournamentEntry tournamentEntry = context.TournamentEntries.First(i => i.Id == _id);

            tournamentEntry.TeamID_Tournament = _tournamentTeamId;

            context.SaveChanges();
        }
        #endregion
    }
}
