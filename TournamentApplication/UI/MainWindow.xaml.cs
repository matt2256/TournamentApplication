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
        public MainWindow()
        {
            InitializeComponent();
            LoadDtg();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            Create create = new Create();
            create.CreatePeople(TBPlayerFirstName.Text, TBPlayerLastName.Text, TBPlayerInGameName.Text);

            LoadDtg();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDtg();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            
        }

        public void LoadDtg()
        {
            CollectionViewSource PlayerSource = ((CollectionViewSource)(this.FindResource("PlayerSource")));

            TournamentEntities _context = new TournamentEntities();

            _context.People.Load();

            PlayerSource.Source = _context.People.Local;
        }
    }
}
