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
using System.Windows.Shapes;
using DataAccess.CRUD;
using Entities;
using System.Data.Entity;
using UI.Windows;

namespace UI.Windows
{
    /// <summary>
    /// Interaction logic for Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void BtnEditPlayer_Click(object sender, RoutedEventArgs e)
        {
            Update update = new Update();
            update.UpdatePeople(Convert.ToInt32(TBPlayerId.Text), TBPlayerFirstName.Text, TBPlayerLastName.Text, TBPlayerInGameName.Text);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDtg();
        }

        public void LoadDtg()
        {
            CollectionViewSource EditSource = ((CollectionViewSource)(this.FindResource("EditSource")));

            TournamentEntities _context = new TournamentEntities();

            _context.People.Load();

            EditSource.Source = _context.People.Local;
        }

        
    }
}
