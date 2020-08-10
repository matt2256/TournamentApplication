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
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadPlayerDtg();
        }
        #endregion

        #region Player
        

        public void LoadPlayerDtg()
        {
            CollectionViewSource PlayerSource = ((CollectionViewSource)(this.FindResource("PlayerSource")));

            TournamentEntities _context = new TournamentEntities();

            _context.People.Load();

            PlayerSource.Source = _context.People.Local;
        }
        #endregion


    }
}
