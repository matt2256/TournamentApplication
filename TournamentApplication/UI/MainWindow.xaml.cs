using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataAccess.CRUD;
using System.Data;
using Entities;
using System.Data.Entity;


namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Window eventhandlers
        public MainWindow()
        {
            InitializeComponent();
            LoadPlayerDtg();
            LoadTeamMemberDtg();
            LoadTeamDtg();
            LoadTournamentDtg();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadPlayerDtg();
            LoadTeamMemberDtg();
            LoadTeamDtg();
            LoadTournamentDtg();
        }
        #endregion

        #region Player
        private void BtnPlayerCreate_Click(object sender, RoutedEventArgs e)
        {
            Create _create = new Create();

            _create.CreatePeople(TBPlayerFirstName.Text, TBPlayerLastName.Text, TBPlayerInGameName.Text);

            LoadPlayerDtg();
        }

        private void BtnPlayerEdit_Click(object sender, RoutedEventArgs e)
        {
            Update _update = new Update();

            _update.UpdatePerson(Convert.ToInt32(TBPlayerId.Text), TBPlayerFirstName.Text, TBPlayerLastName.Text);

            LoadPlayerDtg();
        }

        private void BtnPlayerDelete_Click(object sender, RoutedEventArgs e)
        {
            Delete delete = new Delete();

            delete.DeletePerson(Convert.ToInt32(TBPlayerId.Text));

            LoadPlayerDtg();
        }

        public void LoadPlayerDtg()
        {
            CollectionViewSource PlayerSource = ((CollectionViewSource)(this.FindResource("PlayerSource")));

            TournamentEntities _context = new TournamentEntities();

            _context.People.Load();

            PlayerSource.Source = _context.People.Local;
        }


        #endregion

        #region TeamMembers
        private void BtnTeamMemberCreate_Click(object sender, RoutedEventArgs e)
        {
            Create _Create = new Create();

            _Create.CreateTeamMembers(TBTeamMemberName.Text, TBTeamMemberTeamId.Text);

            LoadTeamMemberDtg();
        }

        private void BtnTeamMemberEdit_Click(object sender, RoutedEventArgs e)
        {
            Update update = new Update();

            update.UpdateTeamMember(Convert.ToInt32(TBTeamMemberID.Text), TBTeamMemberTeamId.Text, TBTeamMemberName.Text);

            LoadTeamMemberDtg();
        }

        private void BtnTeamMemberDelete_Click(object sender, RoutedEventArgs e)
        {
            Delete delete = new Delete();

            delete.DeleteTeamMember(Convert.ToInt32(TBTeamMemberID.Text));

            LoadTeamMemberDtg();
        }

        public void LoadTeamMemberDtg()
        {
            CollectionViewSource TeamMemberSource = ((CollectionViewSource)(this.FindResource("TeamMemberSource")));

            TournamentEntities _context = new TournamentEntities();

            _context.TeamMembers.Load();

            TeamMemberSource.Source = _context.TeamMembers.Local;
        }
        #endregion

        #region Team
        private void BtnTeamCreate_Click(object sender, RoutedEventArgs e)
        {
            Create _create = new Create();

            _create.CreateTeams(TBTeamTeamID.Text);
        }

        //VIRKER FØRST NÅR "TeamID" IKKE ER PRIMARY KEY!!! - DET SKAL ÆNDRES
        private void BtnTeamEdit_Click(object sender, RoutedEventArgs e)
        {
            Update update = new Update();

            update.UpdateTeam(Convert.ToInt32(TBTeamID.Text), TBTeamTeamID.Text);

            LoadTeamDtg();
        }

        private void BtnTeamDelete_Click(object sender, RoutedEventArgs e)
        {
            Delete delete = new Delete();

            delete.DeleteTeam(Convert.ToInt32(TBTeamID.Text));

            LoadTeamDtg();
        }

        public void LoadTeamDtg()
        {
            CollectionViewSource Team = ((CollectionViewSource)(this.FindResource("TeamSource")));

            TournamentEntities _context = new TournamentEntities();

            _context.Teams.Load();

            Team.Source = _context.Teams.Local;
        }

        #endregion

        #region Tournament
        private void BtnTournamentCreate_Click(object sender, RoutedEventArgs e)
        {
            Create _create = new Create();

            _create.CreateTournaments(TBTournamentName.Text);

            LoadTournamentDtg();
        }
   

        private void BtnTournamentEdit_Click(object sender, RoutedEventArgs e)
        {
            Update update = new Update();

            update.UpdateTournament(Convert.ToInt32(TBTournamentID.Text), TBTournamentName.Text, Convert.ToInt32(TBTournamentNameID.Text));

            LoadTournamentDtg();
        }

        private void BtnTournamentDelete_Click(object sender, RoutedEventArgs e)
        {
            Delete delete = new Delete();

            delete.DeleteTournament(Convert.ToInt32(TBTournamentID.Text));

            LoadTournamentDtg();
        }

        public void LoadTournamentDtg()
        {
            CollectionViewSource TournamentSource = ((CollectionViewSource)(this.FindResource("TournamentSource")));

            TournamentEntities _context = new TournamentEntities();

            _context.Tournaments.Load();

            TournamentSource.Source = _context.Tournaments.Local;
        }
        #endregion
    }
}
