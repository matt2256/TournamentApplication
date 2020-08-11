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

        }

        private void BtnPlayerDelete_Click(object sender, RoutedEventArgs e)
        {

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
        }

        private void BtnTeamMemberEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTeamMemberDelete_Click(object sender, RoutedEventArgs e)
        {

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

        private void BtnTeamEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTeamDelete_Click(object sender, RoutedEventArgs e)
        {

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
        }

        private void BtnTournamentEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTournamentDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        public void LoadTournamentDtg()
        {
            CollectionViewSource Tournament = ((CollectionViewSource)(this.FindResource("TournamentSource")));

            TournamentEntities _context = new TournamentEntities();

            _context.Teams.Load();

            Tournament.Source = _context.Teams.Local;
        }
        #endregion
    }
}
